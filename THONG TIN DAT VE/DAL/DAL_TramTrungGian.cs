using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
   public class DAL_TramTrungGian
    {
        public DataTable getIdTuyenIdTram()
        {

            SqlConnection conn = DBConnect.Connect();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "getIDTramIDTuyen";

            SqlDataAdapter da = new SqlDataAdapter(cmd);//thuc thi tra ve table
            DataTable dt = new DataTable();
            da.Fill(dt);
            DBConnect.Close(conn);
            return dt;
        }
        public DataTable getTuyenIdTuyenByTuyen()
        {

            SqlConnection conn = DBConnect.Connect();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "getTuyenIDTuyenbyTuyen";

            SqlDataAdapter da = new SqlDataAdapter(cmd);//thuc thi tra ve table
            DataTable dt = new DataTable();
            da.Fill(dt);
            DBConnect.Close(conn);
            return dt;
        }

      
     
        
        public bool InsertTramTG(DTO_TramTrungGian tramTG)
        {
            SqlConnection conn = DBConnect.Connect();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "InsertTramTrungGian";
            SqlParameter prm1 = new SqlParameter("@id_Tuyen", tramTG.TuyenIDTuyen);
            SqlParameter prm2 = new SqlParameter("@id_Tram", tramTG.TramIDTram);

            cmd.Parameters.Add(prm1);
            cmd.Parameters.Add(prm2);
            int row = cmd.ExecuteNonQuery();
            DBConnect.Close(conn);
            if (row > 0)
            {
                return true;
            }
            return false;

        }

    }
}
