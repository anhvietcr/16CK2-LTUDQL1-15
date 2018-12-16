﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
namespace LTUDQL1_DULIEU
{
    public class DataProvider
    {
        private static string connectionString = "";

        public static string ConnectionString {
            get
            {
                if (connectionString.CompareTo("")==0)
                {
                    connectionString = ConfigurationManager.ConnectionStrings["NorthWnd"].ConnectionString;
                }
                return connectionString;
            }
        }

        public static SqlConnection ConnectDatabase()
        {
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            sqlConnection.Open();
            return sqlConnection;
        }

        public static void CloseConnection(SqlConnection sqlConnection)
        {
            sqlConnection.Close();
        }




    }
}
