using System;
using System.Data;
//using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace Lab_6_Bài_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadComboBoxChucVu();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            XuLyThemMoi();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            XuLyLuuDuLieu();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            XuLyThoat();
        }

        private void txtMaCB_Enter(object sender, EventArgs e)
        {
            //XuLyFocusLabel();
        }

        private void LoadComboBoxChucVu()
        {
            try
            {
                if (clsDatabase.openConnection() == false) return;
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM ChucVu", clsDatabase.con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    cbChucVu.DataSource = dt;
                    cbChucVu.DisplayMember = "TenCV";
                    cbChucVu.ValueMember = "MaCV";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load chức vụ: " + ex.Message);
            }
            finally
            {
                clsDatabase.closeConnection();
            }
        }

        private void XuLyThemMoi()
        {
            txtTenCB.Text = "";
            txtSoGioGiang.Text = "";
            txtDonGia.Text = "";
            if (cbChucVu.Items.Count > 0) cbChucVu.SelectedIndex = 0;
            txtMaCB.Text = TaoMaMoi().ToString();
            btnThem.Enabled = false;
            btnLuu.Enabled = true;
            txtTenCB.Focus();
        }

        private int TaoMaMoi()
        {
            int newId = 1;
            try
            {
                if (clsDatabase.openConnection() == false) return 0;
                SqlCommand cmd = new SqlCommand("SELECT MAX(MaCB) FROM CanBo", clsDatabase.con);
                object result = cmd.ExecuteScalar();
                if (result != DBNull.Value && result != null)
                {
                    newId = Convert.ToInt32(result) + 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tạo mã: " + ex.Message);
            }
            finally
            {
                clsDatabase.closeConnection();
            }
            return newId;
        }

        private void XuLyLuuDuLieu()
        {
            if (txtTenCB.Text == "" || txtSoGioGiang.Text == "" || txtDonGia.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            bool ketQua = ThucThiLuuSQL();

            if (ketQua)
            {
                MessageBox.Show("Thêm mới thành công!");
                txtMaCB.Text = "";
                txtTenCB.Text = "";
                txtSoGioGiang.Text = "";
                txtDonGia.Text = "";
                btnThem.Enabled = true;
                btnLuu.Enabled = false;
            }
        }

        private bool ThucThiLuuSQL()
        {
            try
            {
                if (clsDatabase.openConnection() == false) return false;
                string sql = "INSERT INTO CanBo(MaCB, TenCB, MaCV, SoGioGiang, DonGia) VALUES(@Ma, @Ten, @MaCV, @Gio, @Gia)";
                SqlCommand cmd = new SqlCommand(sql, clsDatabase.con);
                cmd.Parameters.AddWithValue("@Ma", int.Parse(txtMaCB.Text));
                cmd.Parameters.AddWithValue("@Ten", txtTenCB.Text);
                cmd.Parameters.AddWithValue("@MaCV", cbChucVu.SelectedValue);
                cmd.Parameters.AddWithValue("@Gio", int.Parse(txtSoGioGiang.Text));
                cmd.Parameters.AddWithValue("@Gia", decimal.Parse(txtDonGia.Text));
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lưu dữ liệu: " + ex.Message);
                return false;
            }
            finally
            {
                clsDatabase.closeConnection();
            }
        }

        private void XuLyThoat()
        {
            DialogResult tl = MessageBox.Show("Bạn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo);
            if (tl == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void XuLyFocusLabel()
        {
            label1.Focus();
            //this.activeControl = null;
        }
    }
}