using System;
using System.Data.SqlClient;

class clsData
{
    public static SqlConnection con;

    public static void OpenConnection()
    {
        string strCon = @"Data Source=.;Initial Catalog=ThanhToan;Integrated Security=True;TrustServerCertificate=True";        

        con = new SqlConnection(strCon);
        if (con.State == System.Data.ConnectionState.Closed)
            con.Open();
    }

    public static void CloseConnection()
    {
        if (con.State == System.Data.ConnectionState.Open)
            con.Close();
    }
}
