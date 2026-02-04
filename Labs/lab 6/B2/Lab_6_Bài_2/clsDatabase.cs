using System;
using System.Data;
//using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace Lab_6_Bài_2
{
    class clsDatabase
    {
        // Biến static để có thể gọi trực tiếp: clsDatabase.con
        public static SqlConnection con;

        public static bool openConnection()
        {
            try
            {
                string strConn = "Data Source=.;Initial Catalog=QLCB;Integrated Security=True;TrustServerCertificate=True";
                    con = new SqlConnection(strConn);
                    con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message);
                return false;
            }
            return true;
        }

        public static bool closeConnection()
        {
            try
            {
                    con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi đóng kết nối: " + ex.Message);
                return false;
            }
            return true;
        }
    }
}