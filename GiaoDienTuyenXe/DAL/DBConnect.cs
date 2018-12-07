using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DAL
{
    public class DBConnect
    {
        protected static string _connectionString;

        public static string ConnectionString
        {
            get
            {
                if (string.IsNullOrEmpty(_connectionString))
                {
                    _connectionString = ConfigurationManager.ConnectionStrings["QuanLyVeXe"].ConnectionString;
                }

                return _connectionString;
            }
        }

        public static SqlConnection Connect()
        {
            SqlConnection conn = new SqlConnection(ConnectionString);

            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }



            conn.Open();
            return conn;
        }

        public static void Close(SqlConnection conn)
        {
            conn.Close();
        }
    }
}
