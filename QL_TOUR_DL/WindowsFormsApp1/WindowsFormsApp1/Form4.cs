using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form4 : Form
    {
        string connectionString = "Data Source=.;Initial Catalog=QL_TOUR_DULICH;Integrated Security=true";
        int currentTourID = -1;
        int currentLichID = -1;

        // Bổ sung biến lưu toàn bộ danh sách tour để tiện lợi cho việc tìm kiếm
        DataTable dtAllTours = new DataTable();

        public Form4()
        {
            InitializeComponent();
        }

        // =========================================================================
        // PHẦN 1: CÁC HÀM SỰ KIỆN GIAO DIỆN (ĐƯA LÊN ĐẦU)
        // =========================================================================

        private void Form4_Load(object sender, EventArgs e)
        {
            dgvTour.AutoGenerateColumns = false;
            LoadComboBoxData();
            LoadTourList();
            CalculateNgayVe(null, null); // Tính ngày về mặc định khi vừa mở Form
        }

        // --- HÀM TỰ ĐỘNG TÍNH NGÀY VỀ (Đóng vai trò như hàm sự kiện ValueChanged) ---
        private void CalculateNgayVe(object sender, EventArgs e)
        {
            int soNgay = (int)numSoNgay.Value;
            if (soNgay > 0)
            {
                dtpNgayVe.Value = dtpNgayDi.Value.AddDays(soNgay - 1);
            }
            else
            {
                dtpNgayVe.Value = dtpNgayDi.Value;
            }
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
            if (string.IsNullOrEmpty(txtSearch.Text.Trim()))
            {
                dgvTour.DataSource = dtAllTours;
                HideColumns();
            }
        }

        private void dgvTour_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvTour.Rows[e.RowIndex];

                // Lấy dữ liệu bằng Name của cột trên UI (colID, colTenTour...)
                currentTourID = Convert.ToInt32(row.Cells["colID"].Value);
                currentLichID = row.Cells["colIdLich"].Value != DBNull.Value ? Convert.ToInt32(row.Cells["colIdLich"].Value) : -1;

                txtTenTour.Text = row.Cells["colTenTour"].Value.ToString();
                cboDiemDi.SelectedValue = row.Cells["colIdDiemDi"].Value;
                cboDiemDen.SelectedValue = row.Cells["colIdDiemDen"].Value;
                numSoNgay.Value = Convert.ToDecimal(row.Cells["colSoNgay"].Value);
                txtGia.Text = row.Cells["colGia"].Value.ToString();
                txtMoTa.Text = row.Cells["colMoTa"].Value.ToString();

                if (row.Cells["colNgayDi"].Value != DBNull.Value) dtpNgayDi.Value = Convert.ToDateTime(row.Cells["colNgayDi"].Value);
                if (row.Cells["colNgayVe"].Value != DBNull.Value) dtpNgayVe.Value = Convert.ToDateTime(row.Cells["colNgayVe"].Value);
                if (row.Cells["colSoCho"].Value != DBNull.Value) numSoCho.Value = Convert.ToDecimal(row.Cells["colSoCho"].Value);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            them();
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

        private void btnReset_Click(object sender, EventArgs e)
        {
            tai();
        }

        // =========================================================================
        // PHẦN 2: CÁC HÀM REFACTOR CHỨA LOGIC CHÍNH (NẰM Ở GIỮA)
        // =========================================================================

        private void LoadComboBoxData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = "SELECT * FROM DIADIEM";
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dtDi = new DataTable();
                DataTable dtDen = new DataTable();

                da.Fill(dtDi);
                da.Fill(dtDen);

                cboDiemDi.DataSource = dtDi;
                cboDiemDi.DisplayMember = "TEN_DD";
                cboDiemDi.ValueMember = "ID";

                cboDiemDen.DataSource = dtDen;
                cboDiemDen.DisplayMember = "TEN_DD";
                cboDiemDen.ValueMember = "ID";
            }
        }

        private void LoadTourList()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                // Tên cột AS ra phải TRÙNG KHỚP với thuộc tính DataPropertyName bạn nhập ở UI
                string sql = @"
                    SELECT T.ID, T.TEN_TOUR, D1.TEN_DD AS DIEM_DI, D2.TEN_DD AS DIEM_DEN, 
                           T.SO_NGAY, T.GIA, L.NGAY_DI, L.NGAY_VE, 
                           L.SO_CHO, T.MOTA, T.ID_DIEMDI, T.ID_DIEMDEN, L.ID as ID_LICH
                    FROM TOUR T
                    JOIN DIADIEM D1 ON T.ID_DIEMDI = D1.ID
                    JOIN DIADIEM D2 ON T.ID_DIEMDEN = D2.ID
                    LEFT JOIN LICHKHOIHANH L ON T.ID = L.ID_TOUR";

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                dtAllTours = new DataTable();
                da.Fill(dtAllTours);
                // Vì đã set AutoGenerateColumns = false nên nó tự động đổ dữ liệu vào đúng các cột trên UI
                dgvTour.DataSource = dtAllTours;
            }
        }

        private void HideColumns()
        {
            if (dgvTour.Columns["ID"] != null) dgvTour.Columns["ID"].Visible = false;
            if (dgvTour.Columns["ID_DIEMDI"] != null) dgvTour.Columns["ID_DIEMDI"].Visible = false;
            if (dgvTour.Columns["ID_DIEMDEN"] != null) dgvTour.Columns["ID_DIEMDEN"].Visible = false;
            if (dgvTour.Columns["ID_LICH"] != null) dgvTour.Columns["ID_LICH"].Visible = false;
            if (dgvTour.Columns["MOTA"] != null) dgvTour.Columns["MOTA"].Visible = false;
        }

        private bool tim()
        {
            string query = txtSearch.Text.Trim();

            if (string.IsNullOrEmpty(query))
            {
                dgvTour.DataSource = dtAllTours; // Trả về toàn bộ nếu query rỗng
                HideColumns();
                return false;
            }

            DataTable dtFiltered = dtAllTours.Clone();
            dtFiltered.Columns.Add("LCS_Score", typeof(int)); // Thêm cột phụ để sắp xếp

            foreach (DataRow row in dtAllTours.Rows)
            {
                string tenTour = row["Tên Tour"].ToString();
                int score = GetLCSLength(query, tenTour);

                // Nếu độ dài LCS đạt tối thiểu 40% độ dài từ khóa (chấp nhận gõ tắt/sai nhẹ)
                if (score >= Math.Max(1, query.Length * 0.4))
                {
                    DataRow newRow = dtFiltered.NewRow();
                    newRow.ItemArray = row.ItemArray;
                    newRow["LCS_Score"] = score;
                    dtFiltered.Rows.Add(newRow);
                }
            }

            // Sắp xếp các kết quả có độ trùng khớp LCS cao nhất lên đầu
            dtFiltered.DefaultView.Sort = "LCS_Score DESC";
            DataTable sortedDt = dtFiltered.DefaultView.ToTable();
            sortedDt.Columns.Remove("LCS_Score"); // Xóa cột điểm

            dgvTour.DataSource = sortedDt;
            HideColumns();
            return true;
        }

        private void them()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlTransaction trans = conn.BeginTransaction();

                try
                {
                    string sqlTour = "INSERT INTO TOUR (TEN_TOUR, ID_DIEMDI, ID_DIEMDEN, SO_NGAY, GIA, MOTA) OUTPUT INSERTED.ID VALUES (@ten, @di, @den, @ngay, @gia, @mota)";
                    SqlCommand cmdTour = new SqlCommand(sqlTour, conn, trans);
                    cmdTour.Parameters.AddWithValue("@ten", txtTenTour.Text);
                    cmdTour.Parameters.AddWithValue("@di", cboDiemDi.SelectedValue);
                    cmdTour.Parameters.AddWithValue("@den", cboDiemDen.SelectedValue);
                    cmdTour.Parameters.AddWithValue("@ngay", numSoNgay.Value);
                    cmdTour.Parameters.AddWithValue("@gia", decimal.Parse(txtGia.Text));
                    cmdTour.Parameters.AddWithValue("@mota", txtMoTa.Text);

                    int newTourID = (int)cmdTour.ExecuteScalar();

                    string sqlLich = "INSERT INTO LICHKHOIHANH (ID_TOUR, NGAY_DI, NGAY_VE, SO_CHO) VALUES (@idTour, @ngayDi, @ngayVe, @soCho)";
                    SqlCommand cmdLich = new SqlCommand(sqlLich, conn, trans);
                    cmdLich.Parameters.AddWithValue("@idTour", newTourID);
                    cmdLich.Parameters.AddWithValue("@ngayDi", dtpNgayDi.Value);
                    cmdLich.Parameters.AddWithValue("@ngayVe", dtpNgayVe.Value);
                    cmdLich.Parameters.AddWithValue("@soCho", numSoCho.Value);

                    cmdLich.ExecuteNonQuery();

                    trans.Commit();
                    MessageBox.Show("Thêm Tour và Lịch khởi hành thành công!");
                    LoadTourList();
                    tai(); // Gọi hàm tai() để clear UI thay cho btnReset_Click
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private bool sua()
        {
            if (currentTourID == -1) { MessageBox.Show("Vui lòng chọn tour cần sửa!"); return false; }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlTransaction trans = conn.BeginTransaction();

                try
                {
                    string sqlTour = "UPDATE TOUR SET TEN_TOUR=@ten, ID_DIEMDI=@di, ID_DIEMDEN=@den, SO_NGAY=@ngay, GIA=@gia, MOTA=@mota WHERE ID=@id";
                    SqlCommand cmdTour = new SqlCommand(sqlTour, conn, trans);
                    cmdTour.Parameters.AddWithValue("@id", currentTourID);
                    cmdTour.Parameters.AddWithValue("@ten", txtTenTour.Text);
                    cmdTour.Parameters.AddWithValue("@di", cboDiemDi.SelectedValue);
                    cmdTour.Parameters.AddWithValue("@den", cboDiemDen.SelectedValue);
                    cmdTour.Parameters.AddWithValue("@ngay", numSoNgay.Value);
                    cmdTour.Parameters.AddWithValue("@gia", decimal.Parse(txtGia.Text));
                    cmdTour.Parameters.AddWithValue("@mota", txtMoTa.Text);
                    cmdTour.ExecuteNonQuery();

                    if (currentLichID > 0)
                    {
                        string sqlLich = "UPDATE LICHKHOIHANH SET NGAY_DI=@ngayDi, NGAY_VE=@ngayVe, SO_CHO=@soCho WHERE ID=@idLich";
                        SqlCommand cmdLich = new SqlCommand(sqlLich, conn, trans);
                        cmdLich.Parameters.AddWithValue("@idLich", currentLichID);
                        cmdLich.Parameters.AddWithValue("@ngayDi", dtpNgayDi.Value);
                        cmdLich.Parameters.AddWithValue("@ngayVe", dtpNgayVe.Value);
                        cmdLich.Parameters.AddWithValue("@soCho", numSoCho.Value);
                        cmdLich.ExecuteNonQuery();
                    }

                    trans.Commit();
                    MessageBox.Show("Cập nhật thông tin thành công!");
                    LoadTourList();
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }

            return true;
        }

        private bool xoa()
        {
            if (currentTourID == -1) { MessageBox.Show("Vui lòng chọn tour cần xóa!"); return false; }

            var result = MessageBox.Show("Bạn có chắc chắn muốn xóa Tour này?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlTransaction trans = conn.BeginTransaction();

                    try
                    {
                        string sqlLich = "DELETE FROM LICHKHOIHANH WHERE ID_TOUR=@idTour";
                        SqlCommand cmdLich = new SqlCommand(sqlLich, conn, trans);
                        cmdLich.Parameters.AddWithValue("@idTour", currentTourID);
                        cmdLich.ExecuteNonQuery();

                        string sqlTour = "DELETE FROM TOUR WHERE ID=@id";
                        SqlCommand cmdTour = new SqlCommand(sqlTour, conn, trans);
                        cmdTour.Parameters.AddWithValue("@id", currentTourID);
                        cmdTour.ExecuteNonQuery();

                        trans.Commit();
                        MessageBox.Show("Đã xóa Tour!");
                        LoadTourList();
                        tai(); // Gọi hàm tai() để clear UI thay cho btnReset_Click
                    }
                    catch (Exception)
                    {
                        trans.Rollback();
                        MessageBox.Show("Không thể xóa Tour này (Có thể đã có khách hàng đặt Booking liên kết với lịch này).");
                    }
                }
            }

            return true;
        }

        private void tai()
        {
            currentTourID = -1;
            currentLichID = -1;
            txtTenTour.Clear();
            txtGia.Clear();
            txtMoTa.Clear();
            txtSearch.Clear(); // Xóa khung tìm kiếm
            numSoNgay.Value = 0;
            numSoCho.Value = 0;
            dtpNgayDi.Value = DateTime.Now;
            CalculateNgayVe(null, null);
            if (cboDiemDi.Items.Count > 0) cboDiemDi.SelectedIndex = 0;
            if (cboDiemDen.Items.Count > 0) cboDiemDen.SelectedIndex = 0;
        }

        // =========================================================================
        // PHẦN 3: CÁC HÀM HỖ TRỢ THUẬT TOÁN / DATABASE (NẰM Ở CUỐI)
        // =========================================================================

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

        // Hàm hỗ trợ xóa dấu Tiếng Việt để tìm kiếm linh hoạt hơn
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