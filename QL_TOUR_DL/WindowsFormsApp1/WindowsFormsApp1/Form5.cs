using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form5 : Form
    {
        string connString = "Data Source=.;Initial Catalog=QL_TOUR_DULICH;Integrated Security=true";
        bool isEditMode = false; // Biến để biết đang ở chế độ Sửa hay Thêm

        // Bảng lưu trữ toàn bộ khách hàng trên RAM để phục vụ tìm kiếm
        DataTable dtAllCustomers = new DataTable();

        public Form5()
        {
            InitializeComponent();
        }

        // =========================================================================
        // PHẦN 1: CÁC HÀM SỰ KIỆN GIAO DIỆN (ĐƯA LÊN ĐẦU)
        // =========================================================================

        private void Form5_Load(object sender, EventArgs e)
        {
            // Tắt tự động đẻ cột để dùng cột tạo trên UI
            dgvKhachHang.AutoGenerateColumns = false;
            LoadCustomerList();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            bool flowControl = tim();
            if (!flowControl)
            {
                return;
            }
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            // Trả lại toàn bộ bảng nếu xóa trắng ô tìm kiếm
            if (string.IsNullOrEmpty(txtSearch.Text.Trim()))
            {
                dgvKhachHang.DataSource = dtAllCustomers;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool flowControl = them();
            if (!flowControl)
            {
                return;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            bool flowControl = sua();
            if (!flowControl)
            {
                return;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            bool flowControl = xoa();
            if (!flowControl)
            {
                return;
            }
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            hien(e);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetInputs();
        }

        // =========================================================================
        // PHẦN 2: CÁC HÀM REFACTOR CHỨA LOGIC CHÍNH (NẰM Ở GIỮA)
        // =========================================================================
        private bool tim()
        {
            string query = txtSearch.Text.Trim();

            // Nếu người dùng không nhập gì, hiển thị lại toàn bộ
            if (string.IsNullOrEmpty(query))
            {
                dgvKhachHang.DataSource = dtAllCustomers;
                return false;
            }

            DataTable dtFiltered = dtAllCustomers.Clone();
            dtFiltered.Columns.Add("LCS_Score", typeof(int)); // Cột ẩn để lưu điểm số LCS

            foreach (DataRow row in dtAllCustomers.Rows)
            {
                string id = row["ID"].ToString();
                string tenKH = row["TEN_KH"].ToString();
                string sdt = row["SDT"].ToString();

                // Tính điểm LCS cho cả 3 trường quan trọng
                int scoreID = GetLCSLength(query, id);
                int scoreTen = GetLCSLength(query, tenKH);
                int scoreSDT = GetLCSLength(query, sdt);

                // Lấy điểm cao nhất trong 3 trường
                int maxScore = Math.Max(scoreID, Math.Max(scoreTen, scoreSDT));

                // Lọc điều kiện: Độ trùng khớp đạt tối thiểu 40% độ dài từ khóa
                if (maxScore >= Math.Max(1, query.Length * 0.4))
                {
                    DataRow newRow = dtFiltered.NewRow();
                    newRow.ItemArray = row.ItemArray;
                    newRow["LCS_Score"] = maxScore;
                    dtFiltered.Rows.Add(newRow);
                }
            }

            // Sắp xếp đưa những khách hàng giống từ khóa nhất lên đầu
            dtFiltered.DefaultView.Sort = "LCS_Score DESC";
            DataTable sortedDt = dtFiltered.DefaultView.ToTable();
            sortedDt.Columns.Remove("LCS_Score"); // Xóa cột điểm đi trước khi hiển thị

            dgvKhachHang.DataSource = sortedDt;
            return true;
        }
        private void LoadCustomerList()
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                // Lấy đúng tên cột gốc, không dùng AS nữa vì đã map bằng DataPropertyName trên UI
                string query = "SELECT ID, TEN_KH, SDT, EMAIL, DIACHI FROM KHACHHANG";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                dtAllCustomers = new DataTable();
                adapter.Fill(dtAllCustomers);
                dgvKhachHang.DataSource = dtAllCustomers;
            }
        }

        private bool them()
        {
            string id = txtID.Text.Trim();
            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(txtTenKH.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ CCCD và Tên khách hàng!");
                return false;
            }

            if (IsIdExists(id))
            {
                MessageBox.Show("Số CCCD này đã tồn tại trong hệ thống!");
                return false;
            }

            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = "INSERT INTO KHACHHANG (ID, TEN_KH, SDT, EMAIL, DIACHI) VALUES (@id, @ten, @sdt, @email, @diachi)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@ten", txtTenKH.Text);
                cmd.Parameters.AddWithValue("@sdt", txtSDT.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@diachi", txtDiaChi.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm khách hàng thành công!");
                LoadCustomerList();
                ResetInputs();
            }

            return true;
        }

        private bool sua()
        {
            if (!isEditMode) { MessageBox.Show("Vui lòng chọn khách hàng từ bảng để sửa!"); return false; }

            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = "UPDATE KHACHHANG SET TEN_KH=@ten, SDT=@sdt, EMAIL=@email, DIACHI=@diachi WHERE ID=@id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", txtID.Text);
                cmd.Parameters.AddWithValue("@ten", txtTenKH.Text);
                cmd.Parameters.AddWithValue("@sdt", txtSDT.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@diachi", txtDiaChi.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cập nhật thông tin thành công!");
                LoadCustomerList();
                ResetInputs();
            }

            return true;
        }

        private bool xoa()
        {
            if (string.IsNullOrEmpty(txtID.Text)) { MessageBox.Show("Vui lòng chọn khách hàng cần xóa!"); return false; }

            if (MessageBox.Show("Xóa khách hàng có CCCD: " + txtID.Text + "?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    string query = "DELETE FROM KHACHHANG WHERE ID=@id";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", txtID.Text);

                    conn.Open();
                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Đã xóa dữ liệu!");
                        LoadCustomerList();
                        ResetInputs();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Không thể xóa khách hàng này (Có thể khách hàng đã có thông tin Đặt Tour).");
                    }
                }
            }

            return true;
        }

        private void hien(DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvKhachHang.Rows[e.RowIndex];

                // Gọi bằng tên Name của cột được tạo trên UI
                txtID.Text = row.Cells["colID"].Value.ToString();
                txtTenKH.Text = row.Cells["colTenKH"].Value.ToString();
                txtSDT.Text = row.Cells["colSDT"].Value.ToString();
                txtEmail.Text = row.Cells["colEmail"].Value.ToString();
                txtDiaChi.Text = row.Cells["colDiaChi"].Value.ToString();

                txtID.ReadOnly = true;
                isEditMode = true;
            }
        }

        private void ResetInputs()
        {
            txtID.Clear();
            txtID.ReadOnly = false;
            txtTenKH.Clear();
            txtSDT.Clear();
            txtEmail.Clear();
            txtDiaChi.Clear();
            txtSearch.Clear();
            isEditMode = false;
        }

        // =========================================================================
        // PHẦN 3: CÁC HÀM HỖ TRỢ THUẬT TOÁN / DATABASE (NẰM Ở CUỐI)
        // =========================================================================

        // Hàm kiểm tra trùng ID (CCCD)
        private bool IsIdExists(string id)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = "SELECT COUNT(*) FROM KHACHHANG WHERE ID = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                conn.Open();
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }

        // Thuật toán Quy hoạch động tìm chiều dài chuỗi con chung (LCS)
        private int GetLCSLength(string s1, string s2)
        {
            s1 = RemoveDiacritics(s1);
            s2 = RemoveDiacritics(s2);

            int m = s1.Length;
            int n = s2.Length;
            int[,] dp = new int[m + 1, n + 1];

            for (int i = 1; i <= m; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (s1[i - 1] == s2[j - 1])
                        dp[i, j] = dp[i - 1, j - 1] + 1;
                    else
                        dp[i, j] = Math.Max(dp[i - 1, j], dp[i, j - 1]);
                }
            }
            return dp[m, n];
        }

        // Hàm hỗ trợ xóa dấu Tiếng Việt
        private string RemoveDiacritics(string text)
        {
            if (string.IsNullOrWhiteSpace(text)) return text;
            text = text.ToLower();
            string[] arr1 = { "á", "à", "ả", "ã", "ạ", "â", "ấ", "ầ", "ẩ", "ẫ", "ậ", "ă", "ắ", "ằ", "ẳ", "ẵ", "ặ", "đ", "é", "è", "ẻ", "ẽ", "ẹ", "ê", "ế", "ề", "ể", "ễ", "ệ", "í", "ì", "ỉ", "ĩ", "ị", "ó", "ò", "ỏ", "õ", "ọ", "ô", "ố", "ồ", "ổ", "ỗ", "ộ", "ơ", "ớ", "ờ", "ở", "ỡ", "ợ", "ú", "ù", "ủ", "ũ", "ụ", "ư", "ứ", "ừ", "ử", "ữ", "ự", "ý", "ỳ", "ỷ", "ỹ", "ỵ" };
            string[] arr2 = { "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "d", "e", "e", "e", "e", "e", "e", "e", "e", "e", "e", "e", "i", "i", "i", "i", "i", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "u", "u", "u", "u", "u", "u", "u", "u", "u", "u", "u", "y", "y", "y", "y", "y" };
            for (int i = 0; i < arr1.Length; i++)
            {
                text = text.Replace(arr1[i], arr2[i]);
            }
            return text;
        }
    }
}