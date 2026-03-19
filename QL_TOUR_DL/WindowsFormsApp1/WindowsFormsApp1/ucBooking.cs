using Microsoft.Data.SqlClient;
using WindowsFormsApp1;
using System;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ucBooking : UserControl
    {
        private Form6 _parent;
        private int _lichId;
        private int _choConLai;
        private bool _isNewCustomer = false;

        public ucBooking()
        {
            InitializeComponent();
        }

        public ucBooking(Form6 parent, int lichId, int choConLai, CustomerDTO oldCustomer = null, int oldQty = 1)
        {
            InitializeComponent();
            _parent = parent;
            _lichId = lichId;

            LoadInfoLich();

            numSoLuong.Minimum = 1;

            if (oldCustomer != null)
            {
                txtSearchID.Text = oldCustomer.ID;
                txtHoTen.Text = oldCustomer.Ten;
                txtSDT.Text = oldCustomer.SDT;
                numSoLuong.Value = oldQty;
                _isNewCustomer = oldCustomer.IsNew;

                txtHoTen.ReadOnly = !_isNewCustomer;
                txtSDT.ReadOnly = !_isNewCustomer;
            }
            else
            {
                txtHoTen.ReadOnly = true;
                txtSDT.ReadOnly = true;
                numSoLuong.Value = 1;
            }
        }

        private void LoadInfoLich()
        {

            string sql = @"SELECT t.TEN_TOUR, l.NGAY_DI, l.NGAY_VE, (l.SO_CHO - l.DA_DAT) as CON_LAI 
                          FROM LICHKHOIHANH l 
                          JOIN TOUR t ON l.ID_TOUR = t.ID 
                          WHERE l.ID = @LichID";

            SqlParameter[] p = { new SqlParameter("@LichID", _lichId) };
            DataTable dt = DbConnector.GetDataTable(sql, p);

            if (dt.Rows.Count > 0)
            {
                _choConLai = Convert.ToInt32(dt.Rows[0]["CON_LAI"]);

                lblTourInfo.Text = $"Tour: {dt.Rows[0]["TEN_TOUR"]}";
                lblNgayDiInfo.Text = $"Ngày đi: {Convert.ToDateTime(dt.Rows[0]["NGAY_DI"]):dd/MM/yyyy}";
                // Hiển thị Ngày về
                lblNgayVeInfo.Text = $"Ngày về: {Convert.ToDateTime(dt.Rows[0]["NGAY_VE"]):dd/MM/yyyy}";
                lblThongBaoCho.Text = $"Số chỗ còn lại: {_choConLai}";
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string id = txtSearchID.Text.Trim();
            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Vui lòng nhập CCCD/Passport!");
                return;
            }

            string sql = "SELECT * FROM KHACHHANG WHERE ID = @ID";
            SqlParameter[] p = { new SqlParameter("@ID", id) };
            DataTable dt = DbConnector.GetDataTable(sql, p);

            if (dt.Rows.Count > 0)
            {
                txtHoTen.Text = dt.Rows[0]["TEN_KH"].ToString();
                txtSDT.Text = dt.Rows[0]["SDT"].ToString();
                _isNewCustomer = false;
                txtHoTen.ReadOnly = true;
                txtSDT.ReadOnly = true;
                MessageBox.Show("Đã tìm thấy thông tin khách hàng cũ.");
            }
            else
            {
                _isNewCustomer = true;
                txtHoTen.ReadOnly = false;
                txtSDT.ReadOnly = false;
                txtHoTen.Clear();
                txtSDT.Clear();
                txtHoTen.Focus();
                MessageBox.Show("Khách hàng mới. Vui lòng nhập thông tin.");
            }
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            int slDat = (int)numSoLuong.Value;
            if (slDat > _choConLai)
            {
                MessageBox.Show($"Vượt quá chỗ trống ({_choConLai})!");
                return;
            }

            if (string.IsNullOrEmpty(txtSearchID.Text) || string.IsNullOrEmpty(txtHoTen.Text))
            {
                MessageBox.Show("Vui lòng kiểm tra/nhập thông tin khách hàng!");
                return;
            }

            CustomerDTO customer = new CustomerDTO
            {
                ID = txtSearchID.Text,
                Ten = txtHoTen.Text,
                SDT = txtSDT.Text,
                IsNew = _isNewCustomer
            };

            _parent.ShowPage(new ucPayment(_parent, _lichId, slDat, customer));
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            _parent.ShowPage(new ucTourList(_parent));
        }

        private void ucBooking_Load(object sender, EventArgs e)
        {

        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {

        }
    }
}