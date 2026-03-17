using Microsoft.Data.SqlClient;
using QL_TOUR_DL.DatTour;
using System;
using System.Data;
using System.Windows.Forms;

namespace DatTour
{
    public partial class ucPayment : UserControl
    {
        private Form1 _parent;
        private int _lichId;
        private int _slKhach;
        private CustomerDTO _customer;
        private decimal _giaTour;
        private int _countdown = 3;

        public ucPayment() { InitializeComponent(); }

        public ucPayment(Form1 parent, int lichId, int slKhach, CustomerDTO customer)
        {
            InitializeComponent();
            _parent = parent;
            _lichId = lichId;
            _slKhach = slKhach;
            _customer = customer;
            LoadThongTinXacNhan();
        }

        private void LoadThongTinXacNhan()
        {
            // Cập nhật SQL để lấy thêm NGAY_VE
            string sql = @"SELECT t.TEN_TOUR, t.GIA, l.NGAY_DI, l.NGAY_VE 
                          FROM TOUR t JOIN LICHKHOIHANH l ON t.ID = l.ID_TOUR 
                          WHERE l.ID = @LichID";
            SqlParameter[] p = { new SqlParameter("@LichID", _lichId) };
            DataTable dt = DatabaseHelper.GetDataTable(sql, p);

            if (dt.Rows.Count > 0)
            {
                _giaTour = Convert.ToDecimal(dt.Rows[0]["GIA"]);
                decimal tongTien = _giaTour * _slKhach;

                lblThongTinKhach.Text = $"Khách hàng: {_customer.Ten} ({_customer.ID})";
                lblTour.Text = $"Tour: {dt.Rows[0]["TEN_TOUR"]}";
                lblNgayDi.Text = $"Ngày đi: {Convert.ToDateTime(dt.Rows[0]["NGAY_DI"]):dd/MM/yyyy}";

                // Hiển thị Ngày về
                lblNgayVe.Text = $"Ngày về: {Convert.ToDateTime(dt.Rows[0]["NGAY_VE"]):dd/MM/yyyy}";

                lblTongTien.Text = $"TỔNG TIỀN: {tongTien:N0} VNĐ";
            }
        }

        private void btnXacNhanThanhToan_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                SqlTransaction trans = conn.BeginTransaction();
                try
                {
                    if (_customer.IsNew)
                    {
                        string sqlKH = "INSERT INTO KHACHHANG (ID, TEN_KH, SDT) VALUES (@ID, @Ten, @SDT)";
                        SqlCommand cmdKH = new SqlCommand(sqlKH, conn, trans);
                        cmdKH.Parameters.AddWithValue("@ID", _customer.ID);
                        cmdKH.Parameters.AddWithValue("@Ten", _customer.Ten);
                        cmdKH.Parameters.AddWithValue("@SDT", _customer.SDT);
                        cmdKH.ExecuteNonQuery();
                    }

                    string sqlBooking = @"INSERT INTO BOOKING (ID_KH, ID_LICH, SL_KHACH, TONG_TIEN) 
                                         VALUES (@ID_KH, @ID_LICH, @SL, @TongTien)";
                    SqlCommand cmdBooking = new SqlCommand(sqlBooking, conn, trans);
                    cmdBooking.Parameters.AddWithValue("@ID_KH", _customer.ID);
                    cmdBooking.Parameters.AddWithValue("@ID_LICH", _lichId);
                    cmdBooking.Parameters.AddWithValue("@SL", _slKhach);
                    cmdBooking.Parameters.AddWithValue("@TongTien", _giaTour * _slKhach);
                    cmdBooking.ExecuteNonQuery();

                    string sqlUpdateLich = "UPDATE LICHKHOIHANH SET DA_DAT = DA_DAT + @SL WHERE ID = @ID";
                    SqlCommand cmdUpdate = new SqlCommand(sqlUpdateLich, conn, trans);
                    cmdUpdate.Parameters.AddWithValue("@SL", _slKhach);
                    cmdUpdate.Parameters.AddWithValue("@ID", _lichId);
                    cmdUpdate.ExecuteNonQuery();

                    trans.Commit();
                    lblThongBaoThanhCong.Visible = true;
                    btnXacNhanThanhToan.Enabled = false;
                    btnHuy.Enabled = false;
                    timerRedirect.Start();
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            _parent.ShowPage(new ucBooking(_parent, _lichId, 0, _customer, _slKhach));
        }

        private void timerRedirect_Tick(object sender, EventArgs e)
        {
            _countdown--;
            lblThongBaoThanhCong.Text = $"Đặt Tour Thành Công! Tự động quay về sau {_countdown}s...";
            if (_countdown <= 0)
            {
                timerRedirect.Stop();
                _parent.ShowPage(new ucTourList(_parent));
            }
        }
    }
}