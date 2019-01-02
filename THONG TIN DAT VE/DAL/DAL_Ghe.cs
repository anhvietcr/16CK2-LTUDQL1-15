using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DAL_Ghe
    {
        public DataTable listChonGhe(int idTuyen, string ngayDi)
        {
            DataTable dt = new DataTable();

            try
            {
                SqlConnection conn = DBConnect.Connect();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "listChonGhe";

                cmd.Parameters.Add(new SqlParameter { ParameterName = "idTuyen", Value = idTuyen });
                cmd.Parameters.Add(new SqlParameter { ParameterName = "ngayKH", Value = ngayDi });


                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                DBConnect.Close(conn);
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public DataTable getGheById(int id)
        {
            DataTable dt = new DataTable();

            try
            {
                SqlConnection conn = DBConnect.Connect();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "getGheById";
                cmd.Parameters.Add(new SqlParameter { ParameterName = "id", Value = id });

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                DBConnect.Close(conn);
                return dt;
            } catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
