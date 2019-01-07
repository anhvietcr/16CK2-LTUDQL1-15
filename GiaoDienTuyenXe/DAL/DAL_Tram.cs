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
    public class DAL_Tram
    {
        public DataTable listTram()
        {

            //tạo kết nối mới
            SqlConnection conn = DBConnect.Connect();
            //tạo command(select *....)
            SqlCommand cmd = conn.CreateCommand();
            //khai bao se dung store cho cmd
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "listTram";
            //thuc thi cmd
            //khi dung datatable hoac dataset thi moi dung SQLdataAdapter
            //cmd.ExecuteNonQuery();//thuc thi tra ve so dong bi anh huong
            SqlDataAdapter da = new SqlDataAdapter(cmd);//thuc thi tra ve table
            DataTable dt = new DataTable();
            //toàn bộ dữ liệu trong da se đổ (Fill) vao dt(dang table)
            da.Fill(dt);
            //
            DBConnect.Close(conn);
            return dt;

        }
        public bool Insert(DTO_Tram tram)
        {

            //tạo kết nối mới
            SqlConnection conn = DBConnect.Connect();
            //tạo command
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "newTram";
            SqlParameter prm1 = new SqlParameter("@tenTram", tram.Ten_Tram);
            SqlParameter prm2 = new SqlParameter("@diaDiem", tram.Dia_Diem);

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
        public bool xoaTram(DTO_Tram tram)
        {
            SqlConnection conn = DBConnect.Connect();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "xoaTram";

            SqlParameter Param1 = new SqlParameter("@id_Tram", tram.Id_Tram);
            cmd.Parameters.Add(Param1);
            int row = cmd.ExecuteNonQuery();
            DBConnect.Close(conn);
            if (row > 0)
            {
                return true;
            }
            return false;
        }
        public bool suaTram(DTO_Tram tram)
        {

            //tạo kết nối mới
            SqlConnection conn = DBConnect.Connect();
            //tạo command
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "suaTram";

            SqlParameter prm1 = new SqlParameter("@id_Tram", tram.Id_Tram);
            SqlParameter prm2 = new SqlParameter("@ten_Tram", tram.Ten_Tram);
            SqlParameter prm3 = new SqlParameter("@dia_Diem", tram.Dia_Diem);

            cmd.Parameters.Add(prm1);
            cmd.Parameters.Add(prm2);
            cmd.Parameters.Add(prm3);

            int row = cmd.ExecuteNonQuery();
            DBConnect.Close(conn);
            if (row > 0)
            {
                return true;
            }
            return false;

        }
        public bool checkExistsTenTramInTram(DTO_Tram tr)
        {
            SqlConnection conn = DBConnect.Connect();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "checkExistsTenTramInTram";

            SqlParameter prm1 = new SqlParameter("@tenTram",tr.Ten_Tram);
            SqlParameter prm2 = new SqlParameter("@diaDiem", tr.Dia_Diem);


            cmd.Parameters.Add(prm1);
            cmd.Parameters.Add(prm2);


            SqlDataAdapter da = new SqlDataAdapter(cmd);//thuc thi tra ve table
            DataTable dt = new DataTable();
            da.Fill(dt);
            DBConnect.Close(conn);
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }
    }
}
