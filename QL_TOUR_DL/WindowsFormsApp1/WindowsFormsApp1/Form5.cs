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

        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            LoadCustomerList();
        }

        private void LoadCustomerList()
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                // Hiển thị ID (CCCD) ra bảng luôn vì nó là thông tin quan trọng
                string query = "SELECT ID as 'CCCD/ID', TEN_KH as 'Họ Tên', SDT as 'Số điện thoại', EMAIL as 'Email', DIACHI as 'Địa chỉ' FROM KHACHHANG";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvKhachHang.DataSource = dt;
            }
        }

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

        // 1. THÊM MỚI
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string id = txtID.Text.Trim();
            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(txtTenKH.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ CCCD và Tên khách hàng!");
                return;
            }

            if (IsIdExists(id))
            {
                MessageBox.Show("Số CCCD này đã tồn tại trong hệ thống!");
                return;
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
        }

        // 2. CẬP NHẬT
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!isEditMode) { MessageBox.Show("Vui lòng chọn khách hàng từ bảng để sửa!"); return; }

            using (SqlConnection conn = new SqlConnection(connString))
            {
                // Không sửa ID (CCCD) ở đây vì nó là khóa chính
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
        }

        // 3. XÓA
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text)) { MessageBox.Show("Vui lòng chọn khách hàng cần xóa!"); return; }

            if (MessageBox.Show("Xóa khách hàng có CCCD: " + txtID.Text + "?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    string query = "DELETE FROM KHACHHANG WHERE ID=@id";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", txtID.Text);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Đã xóa dữ liệu!");
                    LoadCustomerList();
                    ResetInputs();
                }
            }
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvKhachHang.Rows[e.RowIndex];
                txtID.Text = row.Cells["CCCD/ID"].Value.ToString();
                txtTenKH.Text = row.Cells["Họ Tên"].Value.ToString();
                txtSDT.Text = row.Cells["Số điện thoại"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
                txtDiaChi.Text = row.Cells["Địa chỉ"].Value.ToString();

                // Khi đang sửa, khóa ô ID lại để tránh người dùng sửa nhầm khóa chính
                txtID.ReadOnly = true;
                isEditMode = true;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetInputs();
        }

        private void ResetInputs()
        {
            txtID.Clear();
            txtID.ReadOnly = false; // Mở khóa để nhập mới
            txtTenKH.Clear();
            txtSDT.Clear();
            txtEmail.Clear();
            txtDiaChi.Clear();
            isEditMode = false;
        }
    }
}