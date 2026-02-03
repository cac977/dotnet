using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace ThanhToanApp
{
    public partial class Form1 : Form
    {
        TextBox txtSoHD, txtTenKH, txtCMND, txtSoTien;
        ComboBox cboPhong;
        DateTimePicker dtNgayTT;
        Button btnThem, btnLuu, btnThoat;
        Label lblSoHD, lblTenKH, lblCMND, lblSoTien, lblPhong, lblNgayTT;

        public Form1()
        {
            InitializeComponent();
            TaoGiaoDien();
        }

        void TaoGiaoDien()
        {
            this.Text = "Thanh toán";
            this.Size = new Size(580, 300);
            this.StartPosition = FormStartPosition.CenterScreen;

            lblSoHD = new Label() { Text = "Số HD", Location = new Point(20, 25) };
            txtSoHD = new TextBox() { Location = new Point(120, 20), Width = 130, ReadOnly = true };

            lblTenKH = new Label() { Text = "Họ tên", Location = new Point(20, 65) };
            txtTenKH = new TextBox() { Location = new Point(120, 60), Width = 400 };

            lblCMND = new Label() { Text = "Số CMND", Location = new Point(20, 105) };
            txtCMND = new TextBox() { Location = new Point(120, 100), Width = 130, MaxLength = 12 };

            lblSoTien = new Label() { Text = "Số tiền TT", Location = new Point(20, 145) };
            txtSoTien = new TextBox() { Location = new Point(120, 140), Width = 130 };

            lblPhong = new Label() { Text = "Số phòng", Location = new Point(270, 105) };
            cboPhong = new ComboBox() { Location = new Point(370, 105), Width = 150 };
            cboPhong.DrawMode = DrawMode.OwnerDrawFixed;
            cboPhong.DrawItem += cboPhong_DrawItem;

            lblNgayTT = new Label() { Text = "Ngày TT", Location = new Point(270, 145) };
            dtNgayTT = new DateTimePicker() { Location = new Point(370, 145), Width = 150 };
            dtNgayTT.Format = DateTimePickerFormat.Custom;
            dtNgayTT.CustomFormat = "dd/MM/yyyy HH:mm:ss";

            btnThem = new Button() { Text = "Thêm", Location = new Point(150, 200), Width = 80 };
            btnLuu = new Button() { Text = "Lưu", Location = new Point(250, 200), Width = 80 };
            btnThoat = new Button() { Text = "Thoát", Location = new Point(350, 200), Width = 80 };

            btnLuu.Enabled = false;

            btnThem.Click += btnThem_Click;
            btnLuu.Click += btnLuu_Click;
            btnThoat.Click += btnThoat_Click;

            // Attach validation events
            txtTenKH.TextChanged += KiemTraDuLieu;
            txtCMND.TextChanged += KiemTraDuLieu;
            txtSoTien.TextChanged += KiemTraDuLieu;
            cboPhong.SelectedIndexChanged += KiemTraDuLieu;

            // Add input validation events
            txtTenKH.KeyPress += txtTenKH_KeyPress;
            txtCMND.KeyPress += txtCMND_KeyPress;
            txtSoTien.KeyPress += txtSoTien_KeyPress;

            this.Controls.AddRange(new Control[] {
                lblSoHD, txtSoHD,
                lblTenKH, txtTenKH,
                lblCMND, txtCMND,
                lblPhong, cboPhong,
                lblSoTien, txtSoTien,
                lblNgayTT, dtNgayTT,
                btnThem, btnLuu, btnThoat
            });
        }

        // Validate name input: only letters and spaces
        void txtTenKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow control keys (Backspace, Delete, etc.)
            if (char.IsControl(e.KeyChar))
                return;

            // Allow letters, spaces, and Vietnamese characters
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
            // Allow control keys
            if (char.IsControl(e.KeyChar))
                return;

            // Only allow digits
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
            // Allow control keys
            if (char.IsControl(e.KeyChar))
                return;

            // Only allow digits
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

            // Name must have at least 2 characters
            if (ten.Trim().Length < 2)
                return false;

            // Name should only contain letters and spaces
            return Regex.IsMatch(ten.Trim(), @"^[\p{L}\s]+$");
        }

        // Validate CMND format
        bool KiemTraCMNDHopLe(string cmnd)
        {
            if (string.IsNullOrWhiteSpace(cmnd))
                return false;

            // CMND must be 9 or 12 digits
            string trimmed = cmnd.Trim();
            return (trimmed.Length == 9 || trimmed.Length == 12) &&
                   Regex.IsMatch(trimmed, @"^\d+$");
        }

        // Validate money format
        bool KiemTraSoTienHopLe(string soTien)
        {
            if (string.IsNullOrWhiteSpace(soTien))
                return false;

            // Must be valid decimal and greater than 0
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
            // Validate selected room is available
            bool phongHopLe = false;

            if (cboPhong.SelectedIndex >= 0)
            {
                DataRowView item = (DataRowView)cboPhong.SelectedItem;
                int maPhong = (int)item["MaPhong"];
                phongHopLe = KiemTraPhongTrong(maPhong);
            }

            // Enable save button only when all data is valid
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
            // Check if any room is available
            int? phongTrong = LayPhongTrong();

            if (!phongTrong.HasValue)
            {
                MessageBox.Show("Không còn phòng trống! Không thể tạo hóa đơn mới.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            // Room available, create new invoice
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
                // Validate all inputs before saving
                if (!KiemTraTenHopLe(txtTenKH.Text))
                {
                    MessageBox.Show("Họ tên không hợp lệ! Vui lòng chỉ nhập chữ cái (tối thiểu 2 ký tự).",
                        "Lỗi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    txtTenKH.Focus();
                    return;
                }

                if (!KiemTraCMNDHopLe(txtCMND.Text))
                {
                    MessageBox.Show("Số CMND không hợp lệ! Vui lòng nhập 9 hoặc 12 chữ số.",
                        "Lỗi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    txtCMND.Focus();
                    return;
                }

                if (!KiemTraSoTienHopLe(txtSoTien.Text))
                {
                    MessageBox.Show("Số tiền không hợp lệ! Vui lòng nhập số lớn hơn 0.",
                        "Lỗi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    txtSoTien.Focus();
                    return;
                }

                // Final check: verify room is still available
                DataRowView item = (DataRowView)cboPhong.SelectedItem;
                int maPhong = (int)item["MaPhong"];

                if (!KiemTraPhongTrong(maPhong))
                {
                    MessageBox.Show("Phòng này đã được đặt! Vui lòng chọn phòng khác.",
                        "Lỗi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                clsData.OpenConnection();

                string sql = @"INSERT INTO KhachHang 
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

                // Clear form after successful save
                txtSoHD.Clear();
                txtTenKH.Clear();
                txtCMND.Clear();
                txtSoTien.Clear();
                cboPhong.SelectedIndex = -1;
                btnLuu.Enabled = false;

                // Refresh room list to update status
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