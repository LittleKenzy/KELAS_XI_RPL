using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

public class Koneksi
{
    private static string connString = @"Data Source=localhost;Initial Catalog=RestoranLKS;Integrated Security=True";

    public static SqlConnection GetConnection()
    {
        return new SqlConnection(connString);
    }
}