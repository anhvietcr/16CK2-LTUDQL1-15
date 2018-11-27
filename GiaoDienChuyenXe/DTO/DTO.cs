using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DTO
{
    public class Class1
    {

        //connect SQL and execute Query

        // connect string
        private string strConnect = "";
        SqlConnection conn = null;

        // connect to database
        public void Connect()
        {
            try
            {
                if (conn == null)
                {
                    strConnect = ConfigurationManager.ConnectionStrings["QuanLyVeXe"].ConnectionString;
                    conn = new SqlConnection(strConnect);
                }

                if (conn.State != ConnectionState.Closed)
                {
                    conn.Close();
                }

                conn.Open();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // try dis connect form database
        public void DisConnected()
        {
            if (conn != null && conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }

        // execute non query
        public int ExecuteNonQuery(CommandType cmdType, string sqlStr)
        {
            try
            {
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = cmdType;
                cmd.CommandText = sqlStr;

                int row = cmd.ExecuteNonQuery();
                return row;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // execute non query with parameter
        public int ExecuteNonQuery(CommandType cmdType, string sqlStr, params SqlParameter[] parameters)
        {
            try
            {
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = cmdType;
                cmd.CommandText = sqlStr;

                if (parameters != null && parameters.Length > 0)
                {
                    cmd.Parameters.AddRange(parameters);
                }

                int row = cmd.ExecuteNonQuery();
                return row;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // execute data reader
        public SqlDataReader GetReader(CommandType cmdType, string sqlStr)
        {
            try
            {
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = cmdType;
                cmd.CommandText = sqlStr;

                return cmd.ExecuteReader();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //excute data reader with parameter
        public SqlDataReader GetReader(CommandType cmdType, string sqlStr, params SqlParameter[] parameters)
        {
            try
            {
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = cmdType;
                cmd.CommandText = sqlStr;

                if (parameters != null && parameters.Length > 0)
                {
                    cmd.Parameters.AddRange(parameters);
                }

                return cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //data table
        public DataTable SelectAll(CommandType cmdType, string strSql)
        {
            try
            {
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = cmdType;
                cmd.CommandText = strSql;

                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                ad.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
