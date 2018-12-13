using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DAL_DatVe
    {
        public DataTable getTenTrambyTuyen()
        {
            DataTable dt = new DataTable();

            try
            {
                SqlConnection conn = DBConnect.Connect();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "getTenTrambyTuyen";

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
