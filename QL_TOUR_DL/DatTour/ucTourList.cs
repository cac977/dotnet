using Microsoft.Data.SqlClient;
using QL_TOUR_DL.DatTour;
using System;
using System.Data;
using System.Windows.Forms;

namespace DatTour
{
    public partial class ucTourList : UserControl
    {
        private Form1 _parent;
        private int _selectedTourId;

        public ucTourList()
        {
            InitializeComponent();
        }

        public ucTourList(Form1 parent)
        {
            InitializeComponent();
            _parent = parent;
            LoadTours();
        }

        private void LoadTours()
        {
            string sql = "SELECT ID, TEN_TOUR, GIA, SO_NGAY FROM TOUR";
            dgvTour.DataSource = DatabaseHelper.GetDataTable(sql);
        }

        private void dgvTour_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                _selectedTourId = Convert.ToInt32(dgvTour.Rows[e.RowIndex].Cells["ID"].Value);
                LoadLichKhoiHanh(_selectedTourId);
            }
        }

        private void LoadLichKhoiHanh(int tourId)
        {
            // Trong câu lệnh SQL (string) thì vẫn giữ tiền tố N để SQL Server hiểu Unicode
            string sql = @"SELECT ID, 
                          CONCAT(FORMAT(NGAY_DI, 'dd/MM/yyyy'), ' -> ', FORMAT(NGAY_VE, 'dd/MM/yyyy'), 
                          CASE WHEN (SO_CHO - DA_DAT) <= 0 THEN N' (Hết chỗ)' 
                               ELSE CONCAT(N' (Còn: ', SO_CHO - DA_DAT, N' chỗ)') END) as HienThi, 
                          (SO_CHO - DA_DAT) as ConLai 
                          FROM LICHKHOIHANH 
                          WHERE ID_TOUR = @TourID AND TRANGTHAI = 'OPEN'
                          ORDER BY (CASE WHEN (SO_CHO - DA_DAT) > 0 THEN 0 ELSE 1 END), NGAY_DI ASC";

            SqlParameter[] p = { new SqlParameter("@TourID", tourId) };
            DataTable dtLich = DatabaseHelper.GetDataTable(sql, p);

            cboLich.DataSource = dtLich;
            cboLich.DisplayMember = "HienThi";
            cboLich.ValueMember = "ID";
        }

        private void btnTiepTuc_Click(object sender, EventArgs e)
        {
            if (cboLich.SelectedValue != null)
            {
                DataRowView row = (DataRowView)cboLich.SelectedItem;
                int conLai = Convert.ToInt32(row["ConLai"]);
                int lichId = Convert.ToInt32(cboLich.SelectedValue);

                // ĐÃ SỬA: Xóa bỏ tiền tố N trước các chuỗi trong C#
                if (conLai <= 0)
                {
                    MessageBox.Show("Lịch khởi hành này đã hết chỗ. Vui lòng chọn ngày khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Chuyển sang trang Booking
                _parent.ShowPage(new ucBooking(_parent, lichId, conLai, null, 1));
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một lịch khởi hành!");
            }
        }
    }
}