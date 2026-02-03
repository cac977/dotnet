using System;
using System.Data;
using System.Data.SqlClient; // Thư viện kết nối SQL
using System.Windows.Forms;

namespace Lab_6_Bài_2  
{
    public partial class Form1 : Form
    {
        // 1. Cấu hình chuỗi kết nối (Sửa lại tên Server của bạn nếu cần)
        // Dấu chấm (.) nghĩa là máy local. Database là QLCB.
        string strConn = "Data Source=.;Initial Catalog=QLCB;Integrated Security=True";
        SqlConnection conn = null;

        public Form1()
        {
            InitializeComponent(); // Hàm này để nạp giao diện từ file Designer
            conn = new SqlConnection(strConn);
        }

        // --- SỰ KIỆN 1: LOAD FORM ---
        // Tự động chạy khi mở form lên
        private void Form1_Load(object sender, EventArgs e)
        {
            //ApplyDarkMode();
            LoadComboBoxChucVu();
        }

        // Hàm phụ để đổ dữ liệu vào ComboBox
        private void LoadComboBoxChucVu()
        {
            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();

                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM ChucVu", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                // Complex Binding (Yêu cầu 1 của đề bài)
                cbChucVu.DataSource = dt;
                cbChucVu.DisplayMember = "TenCV"; // Hiển thị tên (Giảng viên)
                cbChucVu.ValueMember = "MaCV";    // Giá trị ngầm (GV)
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load chức vụ: " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
            }
        }

        // --- SỰ KIỆN 2: NÚT THÊM ---
        private void btnThem_Click(object sender, EventArgs e)
        {
            // 1. Xóa trắng các ô nhập
            txtTenCB.Text = "";
            txtSoGioGiang.Text = "";
            txtDonGia.Text = "";
            if (cbChucVu.Items.Count > 0) cbChucVu.SelectedIndex = 0;

            // 2. Tính Mã số mới (Max + 1)
            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();

                SqlCommand cmd = new SqlCommand("SELECT MAX(MaCB) FROM CanBo", conn);
                object result = cmd.ExecuteScalar();

                int newId = 1; // Mặc định là 1 nếu bảng rỗng
                if (result != DBNull.Value && result != null)
                {
                    newId = Convert.ToInt32(result) + 1;
                }

                // Gán vào ô Mã CB
                txtMaCB.Text = newId.ToString();

                // 3. Đổi trạng thái nút
                btnThem.Enabled = false; // Tắt nút Thêm
                btnLuu.Enabled = true;   // Bật nút Lưu
                txtTenCB.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tạo mã: " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
            }
        }

        // --- SỰ KIỆN 3: NÚT LƯU ---
        private void btnLuu_Click(object sender, EventArgs e)
        {
            // Kiểm tra nhập liệu
            if (txtTenCB.Text == "" || txtSoGioGiang.Text == "" || txtDonGia.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();

                // Câu lệnh INSERT
                string sql = "INSERT INTO CanBo(MaCB, TenCB, MaCV, SoGioGiang, DonGia) VALUES(@Ma, @Ten, @MaCV, @Gio, @Gia)";

                SqlCommand cmd = new SqlCommand(sql, conn);

                // Truyền tham số
                cmd.Parameters.AddWithValue("@Ma", int.Parse(txtMaCB.Text));
                cmd.Parameters.AddWithValue("@Ten", txtTenCB.Text);
                cmd.Parameters.AddWithValue("@MaCV", cbChucVu.SelectedValue); // Lấy ValueMember
                cmd.Parameters.AddWithValue("@Gio", int.Parse(txtSoGioGiang.Text));
                cmd.Parameters.AddWithValue("@Gia", decimal.Parse(txtDonGia.Text));

                cmd.ExecuteNonQuery();

                MessageBox.Show("Thêm mới thành công!");

                // Reset lại giao diện sau khi lưu
                txtMaCB.Text = "";
                txtTenCB.Text = "";
                txtSoGioGiang.Text = "";
                txtDonGia.Text = "";

                btnThem.Enabled = true;  // Bật lại nút Thêm
                btnLuu.Enabled = false; // Tắt nút Lưu
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lưu dữ liệu: " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
            }
        }

        // --- SỰ KIỆN 4: NÚT ĐÓNG (Cái này sửa lỗi btnDong_Click của bạn) ---
        private void btnDong_Click(object sender, EventArgs e)
        {
            DialogResult tl = MessageBox.Show("Bạn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo);
            if (tl == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void txtMaCB_Enter(object sender, EventArgs e)
        {
            label1.Focus();
        }
    }

}