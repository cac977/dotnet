using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace prjDVD
{
    internal class clsDatabase
    {
        public static SqlConnection conn;

        public static bool openConnection()
        {
            try
            {
                // CHINH LAI CONNECTION STRING
                conn = new SqlConnection("Data Source=.;Initial Catalog=DVDLibrary;Integrated Security=True");
                conn.Open();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
    }
}
