using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class DbConnector
    {
  
        private static string connectionString = @"Data Source=.;Initial Catalog=QL_TOUR_DULICH;Integrated Security=True;TrustServerCertificate=True";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }


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