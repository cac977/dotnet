using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace QL_TOUR_DL.DatTour
{
    public class DatabaseHelper
    {
        // Thay đổi Server Name phù hợp với máy của bạn (ví dụ: .\SQLEXPRESS)
        // Thêm "TrustServerCertificate=True" vào cuối chuỗi kết nối
        private static string connectionString = @"Data Source=.;Initial Catalog=QL_TOUR_DULICH;Integrated Security=True;TrustServerCertificate=True";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        // Hàm lấy dữ liệu đổ vào DataTable
        public static DataTable GetDataTable(string query, SqlParameter[] parameters = null)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = GetConnection())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    if (parameters != null) cmd.Parameters.AddRange(parameters);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối DB: " + ex.Message);
                }
            }
            return dt;
        }
    }
}