using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ucPayment : UserControl
    {
        private Form6 _parent;
        private int _lichId;
        private int _slKhach;
        private CustomerDTO _customer;
        private decimal _giaTour;
        private int _countdown = 3;

        public ucPayment() { InitializeComponent(); }

        public ucPayment(Form6 parent, int lichId, int slKhach, CustomerDTO customer)
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
            string sql = @"SELECT t.TEN_TOUR, t.GIA, l.NGAY_DI, l.NGAY_VE 
                          FROM TOUR t JOIN LICHKHOIHANH l ON t.ID = l.ID_TOUR 
                          WHERE l.ID = @LichID";
            SqlParameter[] p = { new SqlParameter("@LichID", _lichId) };
            DataTable dt = DbConnector.GetDataTable(sql, p);

            if (dt != null && dt.Rows.Count > 0)
            {
                _giaTour = Convert.ToDecimal(dt.Rows[0]["GIA"]);
                decimal tongTien = _giaTour * _slKhach;

                lblThongTinKhach.Text = $"Khách hàng: {_customer.Ten} ({_customer.ID})";
                lblTour.Text = $"Tour: {dt.Rows[0]["TEN_TOUR"]}";
                lblNgayDi.Text = $"Ngày đi: {Convert.ToDateTime(dt.Rows[0]["NGAY_DI"]):dd/MM/yyyy}";
                lblNgayVe.Text = $"Ngày về: {Convert.ToDateTime(dt.Rows[0]["NGAY_VE"]):dd/MM/yyyy}";
                lblGiaTour.Text = $"Giá tour: {_giaTour:N0} VNĐ";
                lblSoLuong.Text = $"Số lượng đặt: {_slKhach}";
                lblTongTien.Text = $"TỔNG TIỀN: {tongTien:N0} VNĐ";
            }
        }

        private void btnXacNhanThanhToan_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = DbConnector.GetConnection())
            {
                conn.Open();
                SqlTransaction trans = conn.BeginTransaction();
                try
                {
                    // 1. Thêm khách hàng (nếu là khách mới)
                    if (_customer.IsNew)
                    {
                        string sqlKH = "INSERT INTO KHACHHANG (ID, TEN_KH, SDT) VALUES (@ID, @Ten, @SDT)";
                        SqlCommand cmdKH = new SqlCommand(sqlKH, conn, trans);
                        cmdKH.Parameters.AddWithValue("@ID", _customer.ID);
                        cmdKH.Parameters.AddWithValue("@Ten", _customer.Ten);
                        cmdKH.Parameters.AddWithValue("@SDT", _customer.SDT);
                        cmdKH.ExecuteNonQuery();
                    }

                    // 2. Thêm Booking (Đã thêm NGAY_DAT và TRANGTHAI theo thiết kế DB)
                    string sqlBooking = @"INSERT INTO BOOKING (ID_KH, ID_LICH, NGAY_DAT, SL_KHACH, TONG_TIEN, TRANGTHAI) 
                                         VALUES (@ID_KH, @ID_LICH, GETDATE(), @SL, @TongTien, @TrangThai)";
                    SqlCommand cmdBooking = new SqlCommand(sqlBooking, conn, trans);
                    cmdBooking.Parameters.AddWithValue("@ID_KH", _customer.ID);
                    cmdBooking.Parameters.AddWithValue("@ID_LICH", _lichId);
                    cmdBooking.Parameters.AddWithValue("@SL", _slKhach);
                    cmdBooking.Parameters.AddWithValue("@TongTien", _giaTour * _slKhach);
                    cmdBooking.Parameters.AddWithValue("@TrangThai", "Đã thanh toán"); // Bạn có thể đổi trạng thái tùy ý
                    cmdBooking.ExecuteNonQuery();

                    // 3. Cập nhật số lượng đã đặt của Lịch Khởi Hành
                    string sqlUpdateLich = "UPDATE LICHKHOIHANH SET DA_DAT = DA_DAT + @SL WHERE ID = @ID";
                    SqlCommand cmdUpdate = new SqlCommand(sqlUpdateLich, conn, trans);
                    cmdUpdate.Parameters.AddWithValue("@SL", _slKhach);
                    cmdUpdate.Parameters.AddWithValue("@ID", _lichId);
                    cmdUpdate.ExecuteNonQuery();

                    trans.Commit(); // Hoàn tất giao dịch

                    // Xử lý giao diện khi thành công
                    lblThongBaoThanhCong.Visible = true;
                    btnXacNhanThanhToan.Enabled = false;
                    btnHuy.Enabled = false;
                    timerRedirect.Start();
                }
                catch (Exception ex)
                {
                    trans.Rollback(); // Hoàn tác nếu có lỗi
                    MessageBox.Show("Lỗi khi thanh toán: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            // Quay về màn hình Booking
            _parent.ShowPage(new ucBooking(_parent, _lichId, 0, _customer, _slKhach));
        }

        private void timerRedirect_Tick(object sender, EventArgs e)
        {
            _countdown--;
            lblThongBaoThanhCong.Text = $"Đặt Tour Thành Công! Tự động quay về sau {_countdown}s...";
            if (_countdown <= 0)
            {
                timerRedirect.Stop();
                _parent.ShowPage(new ucTourList(_parent)); // Quay về danh sách Tour
            }
        }
    }
}