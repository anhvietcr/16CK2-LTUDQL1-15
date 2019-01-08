using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DAL_Xe
    {
        DataTable dt = new DataTable();

        public DataTable ListXe()
        {
            SqlConnection conn = DBConnect.Connect();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "listXe";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            DBConnect.Close(conn);
            return dt;
        }

        public DataTable getXeById(int id)
        {
            SqlConnection conn = DBConnect.Connect();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "getXeById";
            cmd.Parameters.Add(new SqlParameter { ParameterName = "id", Value = id });

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            DBConnect.Close(conn);
            return dt;
        }
    }
}
