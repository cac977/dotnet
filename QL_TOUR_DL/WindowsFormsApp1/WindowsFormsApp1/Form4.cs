using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form4 : Form
    {
        string connectionString = "Data Source=.;Initial Catalog=QL_TOUR_DULICH;Integrated Security=true";
        int currentTourID = -1;
        int currentLichID = -1;

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            LoadComboBoxData();
            LoadTourList();
            CalculateNgayVe(null, null); // Tính ngày về mặc định khi vừa mở Form
        }

        // --- HÀM TỰ ĐỘNG TÍNH NGÀY VỀ ---
        private void CalculateNgayVe(object sender, EventArgs e)
        {
            // Nếu số ngày > 0 thì Ngày về = Ngày đi + Số ngày
            // (Lưu ý: Tour 3 ngày 2 đêm đi ngày 1 thì về ngày 3, nên ta cộng (Số ngày - 1))
            int soNgay = (int)numSoNgay.Value;
            if (soNgay > 0)
            {
                dtpNgayVe.Value = dtpNgayDi.Value.AddDays(soNgay - 1);
            }
            else
            {
                dtpNgayVe.Value = dtpNgayDi.Value;
            }
        }

        private void LoadComboBoxData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = "SELECT * FROM DIADIEM";
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dtDi = new DataTable();
                DataTable dtDen = new DataTable();

                da.Fill(dtDi);
                da.Fill(dtDen);

                cboDiemDi.DataSource = dtDi;
                cboDiemDi.DisplayMember = "TEN_DD";
                cboDiemDi.ValueMember = "ID";

                cboDiemDen.DataSource = dtDen;
                cboDiemDen.DisplayMember = "TEN_DD";
                cboDiemDen.ValueMember = "ID";
            }
        }

        private void LoadTourList()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = @"
                    SELECT T.ID, T.TEN_TOUR as 'Tên Tour', D1.TEN_DD as 'Điểm đi', D2.TEN_DD as 'Điểm đến', 
                           T.SO_NGAY as 'Số ngày', T.GIA as 'Giá', L.NGAY_DI as 'Ngày đi', L.NGAY_VE as 'Ngày về', 
                           L.SO_CHO as 'Số chỗ', T.MOTA, T.ID_DIEMDI, T.ID_DIEMDEN, L.ID as ID_LICH
                    FROM TOUR T
                    JOIN DIADIEM D1 ON T.ID_DIEMDI = D1.ID
                    JOIN DIADIEM D2 ON T.ID_DIEMDEN = D2.ID
                    LEFT JOIN LICHKHOIHANH L ON T.ID = L.ID_TOUR";

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvTour.DataSource = dt;

                if (dgvTour.Columns["ID"] != null) dgvTour.Columns["ID"].Visible = false;
                if (dgvTour.Columns["ID_DIEMDI"] != null) dgvTour.Columns["ID_DIEMDI"].Visible = false;
                if (dgvTour.Columns["ID_DIEMDEN"] != null) dgvTour.Columns["ID_DIEMDEN"].Visible = false;
                if (dgvTour.Columns["ID_LICH"] != null) dgvTour.Columns["ID_LICH"].Visible = false;
                if (dgvTour.Columns["MOTA"] != null) dgvTour.Columns["MOTA"].Visible = false;
            }
        }

        private void dgvTour_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvTour.Rows[e.RowIndex];

                currentTourID = Convert.ToInt32(row.Cells["ID"].Value);
                currentLichID = row.Cells["ID_LICH"].Value != DBNull.Value ? Convert.ToInt32(row.Cells["ID_LICH"].Value) : -1;

                txtTenTour.Text = row.Cells["Tên Tour"].Value.ToString();
                cboDiemDi.SelectedValue = row.Cells["ID_DIEMDI"].Value;
                cboDiemDen.SelectedValue = row.Cells["ID_DIEMDEN"].Value;
                numSoNgay.Value = Convert.ToDecimal(row.Cells["Số ngày"].Value);
                txtGia.Text = row.Cells["Giá"].Value.ToString();
                txtMoTa.Text = row.Cells["MOTA"].Value.ToString();

                if (row.Cells["Ngày đi"].Value != DBNull.Value) dtpNgayDi.Value = Convert.ToDateTime(row.Cells["Ngày đi"].Value);
                if (row.Cells["Ngày về"].Value != DBNull.Value) dtpNgayVe.Value = Convert.ToDateTime(row.Cells["Ngày về"].Value);
                if (row.Cells["Số chỗ"].Value != DBNull.Value) numSoCho.Value = Convert.ToDecimal(row.Cells["Số chỗ"].Value);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlTransaction trans = conn.BeginTransaction();

                try
                {
                    string sqlTour = "INSERT INTO TOUR (TEN_TOUR, ID_DIEMDI, ID_DIEMDEN, SO_NGAY, GIA, MOTA) OUTPUT INSERTED.ID VALUES (@ten, @di, @den, @ngay, @gia, @mota)";
                    SqlCommand cmdTour = new SqlCommand(sqlTour, conn, trans);
                    cmdTour.Parameters.AddWithValue("@ten", txtTenTour.Text);
                    cmdTour.Parameters.AddWithValue("@di", cboDiemDi.SelectedValue);
                    cmdTour.Parameters.AddWithValue("@den", cboDiemDen.SelectedValue);
                    cmdTour.Parameters.AddWithValue("@ngay", numSoNgay.Value);
                    cmdTour.Parameters.AddWithValue("@gia", decimal.Parse(txtGia.Text));
                    cmdTour.Parameters.AddWithValue("@mota", txtMoTa.Text);

                    int newTourID = (int)cmdTour.ExecuteScalar();

                    string sqlLich = "INSERT INTO LICHKHOIHANH (ID_TOUR, NGAY_DI, NGAY_VE, SO_CHO) VALUES (@idTour, @ngayDi, @ngayVe, @soCho)";
                    SqlCommand cmdLich = new SqlCommand(sqlLich, conn, trans);
                    cmdLich.Parameters.AddWithValue("@idTour", newTourID);
                    cmdLich.Parameters.AddWithValue("@ngayDi", dtpNgayDi.Value);
                    cmdLich.Parameters.AddWithValue("@ngayVe", dtpNgayVe.Value); // Vẫn lấy từ dtpNgayVe vì nó đã được tính tự động
                    cmdLich.Parameters.AddWithValue("@soCho", numSoCho.Value);

                    cmdLich.ExecuteNonQuery();

                    trans.Commit();
                    MessageBox.Show("Thêm Tour và Lịch khởi hành thành công!");
                    LoadTourList();
                    btnReset_Click(null, null);
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (currentTourID == -1) { MessageBox.Show("Vui lòng chọn tour cần sửa!"); return; }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlTransaction trans = conn.BeginTransaction();

                try
                {
                    string sqlTour = "UPDATE TOUR SET TEN_TOUR=@ten, ID_DIEMDI=@di, ID_DIEMDEN=@den, SO_NGAY=@ngay, GIA=@gia, MOTA=@mota WHERE ID=@id";
                    SqlCommand cmdTour = new SqlCommand(sqlTour, conn, trans);
                    cmdTour.Parameters.AddWithValue("@id", currentTourID);
                    cmdTour.Parameters.AddWithValue("@ten", txtTenTour.Text);
                    cmdTour.Parameters.AddWithValue("@di", cboDiemDi.SelectedValue);
                    cmdTour.Parameters.AddWithValue("@den", cboDiemDen.SelectedValue);
                    cmdTour.Parameters.AddWithValue("@ngay", numSoNgay.Value);
                    cmdTour.Parameters.AddWithValue("@gia", decimal.Parse(txtGia.Text));
                    cmdTour.Parameters.AddWithValue("@mota", txtMoTa.Text);
                    cmdTour.ExecuteNonQuery();

                    if (currentLichID > 0)
                    {
                        string sqlLich = "UPDATE LICHKHOIHANH SET NGAY_DI=@ngayDi, NGAY_VE=@ngayVe, SO_CHO=@soCho WHERE ID=@idLich";
                        SqlCommand cmdLich = new SqlCommand(sqlLich, conn, trans);
                        cmdLich.Parameters.AddWithValue("@idLich", currentLichID);
                        cmdLich.Parameters.AddWithValue("@ngayDi", dtpNgayDi.Value);
                        cmdLich.Parameters.AddWithValue("@ngayVe", dtpNgayVe.Value);
                        cmdLich.Parameters.AddWithValue("@soCho", numSoCho.Value);
                        cmdLich.ExecuteNonQuery();
                    }

                    trans.Commit();
                    MessageBox.Show("Cập nhật thông tin thành công!");
                    LoadTourList();
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (currentTourID == -1) { MessageBox.Show("Vui lòng chọn tour cần xóa!"); return; }

            var result = MessageBox.Show("Bạn có chắc chắn muốn xóa Tour này?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlTransaction trans = conn.BeginTransaction();

                    try
                    {
                        string sqlLich = "DELETE FROM LICHKHOIHANH WHERE ID_TOUR=@idTour";
                        SqlCommand cmdLich = new SqlCommand(sqlLich, conn, trans);
                        cmdLich.Parameters.AddWithValue("@idTour", currentTourID);
                        cmdLich.ExecuteNonQuery();

                        string sqlTour = "DELETE FROM TOUR WHERE ID=@id";
                        SqlCommand cmdTour = new SqlCommand(sqlTour, conn, trans);
                        cmdTour.Parameters.AddWithValue("@id", currentTourID);
                        cmdTour.ExecuteNonQuery();

                        trans.Commit();
                        MessageBox.Show("Đã xóa Tour!");
                        LoadTourList();
                        btnReset_Click(null, null);
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        MessageBox.Show("Không thể xóa Tour này (Có thể đã có khách hàng đặt Booking liên kết với lịch này).");
                    }
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            currentTourID = -1;
            currentLichID = -1;
            txtTenTour.Clear();
            txtGia.Clear();
            txtMoTa.Clear();
            numSoNgay.Value = 0;
            numSoCho.Value = 0;
            dtpNgayDi.Value = DateTime.Now;
            CalculateNgayVe(null, null); // Tính lại ngày về sau khi reset
            if (cboDiemDi.Items.Count > 0) cboDiemDi.SelectedIndex = 0;
            if (cboDiemDen.Items.Count > 0) cboDiemDen.SelectedIndex = 0;
        }
    }
}