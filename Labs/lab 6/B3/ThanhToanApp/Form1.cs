using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace ThanhToanApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Validate name input: only letters and spaces
        void txtTenKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
                return;

            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
                MessageBox.Show("Họ tên chỉ được nhập chữ cái và khoảng trắng!",
                    "Lỗi định dạng",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        // Validate CMND input: only digits
        void txtCMND_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
                return;

            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Số CMND chỉ được nhập số!",
                    "Lỗi định dạng",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        // Validate money input: only digits
        void txtSoTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
                return;

            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Số tiền chỉ được nhập số!",
                    "Lỗi định dạng",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        // Validate name format
        bool KiemTraTenHopLe(string ten)
        {
            if (string.IsNullOrWhiteSpace(ten))
                return false;

            if (ten.Trim().Length < 2)
                return false;

            return Regex.IsMatch(ten.Trim(), @"^[\p{L}\s]+$");
        }

        // Validate CMND format
        bool KiemTraCMNDHopLe(string cmnd)
        {
            if (string.IsNullOrWhiteSpace(cmnd))
                return false;

            string trimmed = cmnd.Trim();
            return (trimmed.Length > 0) &&
                   Regex.IsMatch(trimmed, @"^\d+$");
        }

        // Validate money format
        bool KiemTraSoTienHopLe(string soTien)
        {
            if (string.IsNullOrWhiteSpace(soTien))
                return false;

            if (decimal.TryParse(soTien.Trim(), out decimal value))
            {
                return value > 0;
            }
            return false;
        }

        // Custom draw for combobox to show booked rooms in gray
        void cboPhong_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            DataRowView item = (DataRowView)cboPhong.Items[e.Index];
            int maPhong = (int)item["MaPhong"];
            string tenPhong = item["TenPhong"].ToString();

            bool phongTrong = KiemTraPhongTrong(maPhong);

            e.DrawBackground();

            Color textColor = phongTrong ? Color.Black : Color.Gray;

            using (SolidBrush brush = new SolidBrush(textColor))
            {
                string displayText = phongTrong ? tenPhong : tenPhong + " (Đã đặt)";
                e.Graphics.DrawString(displayText, e.Font, brush, e.Bounds);
            }

            e.DrawFocusRectangle();
        }

        // Check if room is available
        bool KiemTraPhongTrong(int maPhong)
        {
            clsData.OpenConnection();

            string sql = "SELECT COUNT(*) FROM KhachHang WHERE Phong = @MaPhong";
            SqlCommand cmd = new SqlCommand(sql, clsData.con);
            cmd.Parameters.AddWithValue("@MaPhong", maPhong);

            int count = (int)cmd.ExecuteScalar();

            clsData.CloseConnection();

            return count == 0;
        }

        void KiemTraDuLieu(object sender, EventArgs e)
        {
            bool phongHopLe = false;

            if (cboPhong.SelectedIndex >= 0)
            {
                DataRowView item = (DataRowView)cboPhong.SelectedItem;
                int maPhong = (int)item["MaPhong"];
                phongHopLe = KiemTraPhongTrong(maPhong);
            }

            btnLuu.Enabled = !string.IsNullOrWhiteSpace(txtSoHD.Text) &&
                            KiemTraTenHopLe(txtTenKH.Text) &&
                            KiemTraCMNDHopLe(txtCMND.Text) &&
                            KiemTraSoTienHopLe(txtSoTien.Text) &&
                            phongHopLe;
        }

        void LoadPhong()
        {
            clsData.OpenConnection();
            string sql = "SELECT MaPhong, TenPhong FROM Phong ORDER BY MaPhong";
            SqlDataAdapter da = new SqlDataAdapter(sql, clsData.con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cboPhong.DataSource = dt;
            cboPhong.DisplayMember = "TenPhong";
            cboPhong.ValueMember = "MaPhong";
            cboPhong.SelectedIndex = -1;

            clsData.CloseConnection();
        }

        int? LayPhongTrong()
        {
            clsData.OpenConnection();

            string sql = @"SELECT TOP 1 MaPhong 
                          FROM Phong 
                          WHERE MaPhong NOT IN (SELECT DISTINCT Phong FROM KhachHang)
                          ORDER BY MaPhong";

            SqlCommand cmd = new SqlCommand(sql, clsData.con);
            object result = cmd.ExecuteScalar();

            clsData.CloseConnection();

            return result != null ? (int?)Convert.ToInt32(result) : null;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadPhong();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            int? phongTrong = LayPhongTrong();

            if (!phongTrong.HasValue)
            {
                MessageBox.Show("Không còn phòng trống! Không thể tạo hóa đơn mới.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            clsData.OpenConnection();

            string sql = "SELECT ISNULL(MAX(SoHD), 0) + 1 FROM KhachHang";
            SqlCommand cmd = new SqlCommand(sql, clsData.con);
            object result = cmd.ExecuteScalar();
            int soHD = result != null ? Convert.ToInt32(result) : 1;

            txtSoHD.Text = soHD.ToString();
            txtTenKH.Clear();
            txtCMND.Clear();
            txtSoTien.Clear();
            dtNgayTT.Value = DateTime.Now;

            clsData.CloseConnection();

            cboPhong.SelectedValue = phongTrong.Value;

            btnLuu.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (!KiemTraTenHopLe(txtTenKH.Text))
                {
                    MessageBox.Show("Họ tên không hợp lệ! Vui lòng chỉ nhập chữ cái (tối thiểu 2 ký tự).",
                        "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTenKH.Focus();
                    return;
                }

                if (!KiemTraCMNDHopLe(txtCMND.Text))
                {
                    MessageBox.Show("Số CMND không hợp lệ! Vui lòng nhập số.",
                        "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCMND.Focus();
                    return;
                }

                if (!KiemTraSoTienHopLe(txtSoTien.Text))
                {
                    MessageBox.Show("Số tiền không hợp lệ! Vui lòng nhập số lớn hơn 0.",
                        "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSoTien.Focus();
                    return;
                }

                DataRowView item = (DataRowView)cboPhong.SelectedItem;
                int maPhong = (int)item["MaPhong"];

                if (!KiemTraPhongTrong(maPhong))
                {
                    MessageBox.Show("Phòng này đã được đặt! Vui lòng chọn phòng khác.",
                        "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                clsData.OpenConnection();

                string sql = @"INSERT INTO KhachHang (SoHD, TenKH, SoCMND, SoTien, NgayTT, Phong) 
                               VALUES(@SoHD, @TenKH, @SoCMND, @SoTien, @NgayTT, @MaPhong)";

                SqlCommand cmd = new SqlCommand(sql, clsData.con);
                cmd.Parameters.AddWithValue("@SoHD", int.Parse(txtSoHD.Text));
                cmd.Parameters.AddWithValue("@TenKH", txtTenKH.Text.Trim());
                cmd.Parameters.AddWithValue("@SoCMND", txtCMND.Text.Trim());
                cmd.Parameters.AddWithValue("@SoTien", decimal.Parse(txtSoTien.Text.Trim()));
                cmd.Parameters.AddWithValue("@NgayTT", dtNgayTT.Value);
                cmd.Parameters.AddWithValue("@MaPhong", maPhong);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Lưu thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtSoHD.Clear();
                txtTenKH.Clear();
                txtCMND.Clear();
                txtSoTien.Clear();
                cboPhong.SelectedIndex = -1;
                btnLuu.Enabled = false;

                LoadPhong();

                clsData.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                clsData.CloseConnection();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}