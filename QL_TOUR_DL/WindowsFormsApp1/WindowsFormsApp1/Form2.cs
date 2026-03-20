using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        static String commandText = @"select T.TEN_TOUR, T.SO_NGAY, T.GIA, D.TEN_DD as DIEM_DI, DIADIEM.TEN_DD as DIEM_DEN, L.NGAY_DI,L.NGAY_VE, T.MOTA, BK.SO_LUONG_KHACH from TOUR as T 
            inner join DIADIEM as D on T.ID_DIEMDI = D.ID
            inner join DIADIEM on T.ID_DIEMDEN = DIADIEM.ID
            inner join LICHKHOIHANH as L on L.ID_TOUR = T.ID
            inner join 
            (
                select
                    L.ID, 
                    sum(B.SL_KHACH) as SO_LUONG_KHACH 
                from BOOKING B
                inner join LICHKHOIHANH L 
                on B.ID_LICH = L.ID
                group by L.ID
            ) as BK 
            on L.ID = BK.ID
            where
                T.TEN_TOUR like '%' + @tenTour + '%' and 
                D.TEN_DD like  '%' + @diemDi + '%' and 
                DIADIEM.TEN_DD like '%' + @diemDen + '%' and
                (@ngayDi IS NULL OR CAST(L.NGAY_DI AS DATE) = @ngayDi) and
                (@minGia IS NULL OR T.GIA >= @minGia) and
                (@maxGia IS NULL OR T.GIA <= @maxGia)
            ;
        ";

        private void load_DiemDi()
        {
            string connectionString = "Data Source=.;Initial Catalog=QL_TOUR_DULICH;Integrated Security=true";
            string query = "SELECT distinct TEN_DD FROM DIADIEM";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();

                adapter.Fill(dt);
                DataRow row = dt.NewRow();
                row["TEN_DD"] = "";
                dt.Rows.InsertAt(row, 0);

                cboDiaDiemDi.DataSource = dt;
                cboDiaDiemDi.DisplayMember = "TEN_DD";
                cboDiaDiemDi.ValueMember = "TEN_DD";
            }
        }

        private void load_DiemDien()
        {
            string connectionString = "Data Source=.;Initial Catalog=QL_TOUR_DULICH;Integrated Security=true";
            string query = "SELECT distinct TEN_DD FROM DIADIEM";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();

                adapter.Fill(dt);
                DataRow row = dt.NewRow();
                row["TEN_DD"] = "";
                dt.Rows.InsertAt(row, 0);

                cboDiaDiemDen.DataSource = dt;
                cboDiaDiemDen.DisplayMember = "TEN_DD";
                cboDiaDiemDen.ValueMember = "TEN_DD";
            }
        }
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            String connectionString = "Data Source=.;Initial Catalog=QL_TOUR_DULICH;Integrated Security=true";
            SqlConnection connection = new SqlConnection(connectionString);

            SqlDataAdapter adapter = new SqlDataAdapter(commandText, connection);

            adapter.SelectCommand.Parameters.AddWithValue("@tenTour", txtTen.Text);
            adapter.SelectCommand.Parameters.AddWithValue("@diemDi", cboDiaDiemDi.SelectedValue);
            adapter.SelectCommand.Parameters.AddWithValue("@diemDen", cboDiaDiemDen.SelectedValue);
            if (dateKhoiHanh.Checked)
                adapter.SelectCommand.Parameters.AddWithValue("@ngayDi", dateKhoiHanh.Value.Date);
            else
                adapter.SelectCommand.Parameters.AddWithValue("@ngayDi", DBNull.Value);
            double? minGia;
            double? maxGia;

            string gia = cboGia.Text;

            if (gia == "0-2000000")
            {
                minGia = 0.00;
                maxGia = 2000000.00;
                adapter.SelectCommand.Parameters.AddWithValue("@minGia", minGia);
                adapter.SelectCommand.Parameters.AddWithValue("@maxGia", maxGia);
            }
            else if (gia == "2000000-5000000")
            {
                minGia = 2000000.00;
                maxGia = 5000000.00;
                adapter.SelectCommand.Parameters.AddWithValue("@minGia", minGia);
                adapter.SelectCommand.Parameters.AddWithValue("@maxGia", maxGia);
            }
            else if (gia == "5000000-10000000")
            {
                minGia = 5000000.00;
                maxGia = 10000000.00;
                adapter.SelectCommand.Parameters.AddWithValue("@minGia", minGia);
                adapter.SelectCommand.Parameters.AddWithValue("@maxGia", maxGia);
            }
            else if (gia == ">10000000")
            {
                minGia = 10000000.00;
                adapter.SelectCommand.Parameters.AddWithValue("@minGia", minGia);
                adapter.SelectCommand.Parameters.AddWithValue("@maxGia", DBNull.Value);
            }
            else
            {
                adapter.SelectCommand.Parameters.AddWithValue("@minGia", DBNull.Value);
                adapter.SelectCommand.Parameters.AddWithValue("@maxGia", DBNull.Value);
            }
            
            DataTable dt = new DataTable();

            try
            {
                connection.Open();
                adapter.Fill(dt);

                dtgrTour.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "There are something wrong", MessageBoxButtons.OK);
            }
        }

        private void dtgrTour_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtTen_TextChanged(object sender, EventArgs e)
        {
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            load_DiemDi();
            load_DiemDien();
            dateKhoiHanh.ShowCheckBox = true;
            dateKhoiHanh.Checked = false;

            cboGia.Items.Add("Tat ca");
            cboGia.Items.Add("0-2000000");
            cboGia.Items.Add("2000000-5000000");
            cboGia.Items.Add("5000000-10000000");
            cboGia.Items.Add(">10000000");

            cboGia.SelectedIndex = 0;
        }

        private void dateKhoiHanh_ValueChanged(object sender, EventArgs e)
        {
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
