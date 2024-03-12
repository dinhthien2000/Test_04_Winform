using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_04.Connect
{
    public class Connect
    {
        static string host = "LAPTOP-T1KKK7OU\\SQLEXPRESS";
        static int port = 1433;
        static string database = "Dami";
        static string username = "sa";
        static string password = "123456";

        public static SqlConnection getConnection()
        {
            // Connection String.
            string connString = "Data Source=" + host + "," + port + ";Initial Catalog=" + database + ";User ID=" + username + ";Password=" + password + ";TrustServerCertificate=True";

            SqlConnection con = new SqlConnection(connString);
            Debug.WriteLine("Connected successful");
            return con;
        }
    }
}
