using System;
using System.Data.SqlClient;

class clsData
{
    public static SqlConnection con;

    public static void OpenConnection()
    {
        string strCon = @"Server=.;Database=ThanhToan;uid=mylogin;pwd=mylogin;";        

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
