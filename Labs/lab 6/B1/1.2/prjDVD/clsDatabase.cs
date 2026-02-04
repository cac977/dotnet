using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

class clsDatabase
{
        public static SqlConnection con;

        public static bool openConnection()
        {
            try
            {
                // CHINH LAI CONNECTION STRING
                //conn = new SqlConnection("Server=Nhut\\Nhut; Database=DVDLibrary;uid=mylogin;pwd=mylogin");
                con = new SqlConnection("Data Source=.;Initial Catalog=DVDLibrary;Integrated Security=True");
                con.Open();
            }
            catch (Exception)
            {
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
                //debug
                System.Windows.Forms.MessageBox.Show("Chi tiết lỗi: " + ex.Message);
                return false;
            }
            return true;
        }
    }