using System;
using System.Data;
using System.Data.SqlClient;

public static class DbHelper
{
    // Sesuaikan ServerName dengan koneksi SQL Server Anda
    private static string connString = @"Server=.\SQLEXPRESS;Database=HovSedhepDatabase;Integrated Security=True;";

    public static DataTable GetDataTable(string query, SqlParameter[] parameters = null)
    {
        using (SqlConnection conn = new SqlConnection(connString))
        {
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                if (parameters != null) cmd.Parameters.AddRange(parameters);
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }
    }

    public static int ExecuteNonQuery(string query, SqlParameter[] parameters = null)
    {
        using (SqlConnection conn = new SqlConnection(connString))
        {
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                if (parameters != null) cmd.Parameters.AddRange(parameters);
                conn.Open();
                return cmd.ExecuteNonQuery();
            }
        }
    }
}