using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ucTourList : UserControl
    {
        private Form6 _parent; // Đã đổi sang Form6
        private int _selectedTourId;

        public ucTourList()
        {
            InitializeComponent();
        }

        public ucTourList(Form6 parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        private void ucTourList_Load(object sender, EventArgs e)
        {
            // Tự động nạp danh sách Tour khi trang được hiển thị
            LoadTours();
        }

        private void LoadTours()
        {
            try
            {
                string sql = "SELECT ID, TEN_TOUR, GIA, SO_NGAY FROM TOUR";
                // Đã đổi sang DbConnector
                dgvTour.DataSource = DbConnector.GetDataTable(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách tour: " + ex.Message);
            }
        }

        private void dgvTour_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra nếu người dùng click vào dòng dữ liệu (không phải tiêu đề)
            if (e.RowIndex >= 0)
            {
                try
                {
                    // Lấy ID từ cột có tên là "ID". 
                    // Lưu ý: Nếu DataGridView tự sinh cột, tên cột thường khớp với tên trong SQL
                    _selectedTourId = Convert.ToInt32(dgvTour.Rows[e.RowIndex].Cells["ID"].Value);

                    // Gọi hàm load lịch
                    LoadLichKhoiHanh(_selectedTourId);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi chọn tour: " + ex.Message);
                }
            }
        }

        private void LoadLichKhoiHanh(int tourId)
        {
            // SQL giữ nguyên logic gốc của bạn
            string sql = @"SELECT ID, 
                          CONCAT(FORMAT(NGAY_DI, 'dd/MM/yyyy'), ' -> ', FORMAT(NGAY_VE, 'dd/MM/yyyy'), 
                          CASE WHEN (SO_CHO - DA_DAT) <= 0 THEN N' (Hết chỗ)' 
                               ELSE CONCAT(N' (Còn: ', SO_CHO - DA_DAT, N' chỗ)') END) as HienThi, 
                          (SO_CHO - DA_DAT) as ConLai 
                          FROM LICHKHOIHANH 
                          WHERE ID_TOUR = @TourID AND TRANGTHAI = 'OPEN'
                          ORDER BY (CASE WHEN (SO_CHO - DA_DAT) > 0 THEN 0 ELSE 1 END), NGAY_DI ASC";

            SqlParameter[] p = { new SqlParameter("@TourID", tourId) };
            DataTable dtLich = DbConnector.GetDataTable(sql, p);

            cboLich.DataSource = dtLich;
            cboLich.DisplayMember = "HienThi";
            cboLich.ValueMember = "ID";
        }

        private void btnTiepTuc_Click(object sender, EventArgs e)
        {
            if (cboLich.SelectedValue != null && cboLich.SelectedItem is DataRowView row)
            {
                int conLai = Convert.ToInt32(row["ConLai"]);
                int lichId = Convert.ToInt32(cboLich.SelectedValue);

                if (conLai <= 0)
                {
                    MessageBox.Show("Lịch khởi hành này đã hết chỗ. Vui lòng chọn ngày khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Chuyển sang trang Booking (Sử dụng Form6)
                _parent.ShowPage(new ucBooking(_parent, lichId, conLai, null, 1));
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một tour và lịch khởi hành!");
            }
        }

        // Các sự kiện trống nếu không dùng có thể để nguyên hoặc xóa
        private void dgvTour_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void cboLich_SelectedIndexChanged(object sender, EventArgs e) { }
    }
}