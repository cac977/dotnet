using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        // set default filter to today
        private void Form3_Load(object sender, EventArgs e)
        {
            radToday.Checked = true;
        }
        // create database connection
        string conn = "Data Source=.;Initial Catalog=QL_TOUR_DULICH;Integrated Security=true";

        private void lblTourFilter_Click(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        //main calculate method
        private void calculateFilter (string condition)
        {
            using (SqlConnection connection = new SqlConnection(conn))
            {

                string combinedSql = $@"
                    -- Truy vấn 1: Lấy tổng số lượng và doanh thu
                    SELECT COUNT(*) AS SoLuong, ISNULL(SUM(TONG_TIEN), 0) AS TongDoanhThu 
                    FROM BOOKING B 
                    WHERE {condition};

                    -- Truy vấn 2: Lấy chi tiết cho GridView
                    SELECT B.ID, K.TEN_KH, T.TEN_TOUR, B.NGAY_DAT, B.TONG_TIEN 
                    FROM BOOKING B
                    JOIN KHACHHANG K ON B.ID_KH = K.ID
                    JOIN LICHKHOIHANH L ON B.ID_LICH = L.ID
                    JOIN TOUR T ON L.ID_TOUR = T.ID
                    WHERE {condition};";

                //
                SqlCommand cmd = new SqlCommand(combinedSql, connection);

                //create connection
                try
                {
                    connection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // update total tour count
                            totalTourLabel.Text = reader["SoLuong"].ToString();

                            // update total revenue
                            decimal revenue = Convert.ToDecimal(reader["TongDoanhThu"]);
                            totalRevenueLabel.Text = revenue.ToString("N0");
                        }

                        // update grid view with tour details
                        if (reader.NextResult())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(reader);
                            dtgrReport.DataSource = dt;
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi cập nhật dữ liệu: " + ex.Message);
                    return;
                }
            }
        }

        // filter by today
        private void radToday_CheckedChanged(object sender, EventArgs e)
        {
            if (radToday.Checked)
            {
                string condition = "CAST(B.NGAY_DAT AS DATE) = CAST(GETDATE() AS DATE)";
                calculateFilter(condition);
            }
        }

        // filter by this week
        private void radWeek_CheckedChanged(object sender, EventArgs e)
        {
            if (radWeek.Checked)
            {
                string condition = "DATEPART(WEEK, B.NGAY_DAT) = DATEPART(WEEK, GETDATE()) AND DATEPART(YEAR, B.NGAY_DAT) = DATEPART(YEAR, GETDATE())";
                calculateFilter(condition);
            }
        }

        // filter by this month
        private void radMonth_CheckedChanged(object sender, EventArgs e)
        {
            if (radMonth.Checked)
            {
                string condition = "DATEPART(MONTH, B.NGAY_DAT) = DATEPART(MONTH, GETDATE()) AND DATEPART(YEAR, B.NGAY_DAT) = DATEPART(YEAR, GETDATE())";
                calculateFilter(condition);
            }
        }


        // filter by this year
        private void radYear_CheckedChanged(object sender, EventArgs e)
        {
            if (radYear.Checked)
            {
                string condition = "DATEPART(YEAR, B.NGAY_DAT) = DATEPART(YEAR, GETDATE())";
                calculateFilter(condition);
            }
        }


    }
}
