using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class DAL_TuyenXe
    {
        public DataTable ListTuyenXe()
        {
            //tạo kết nối mới
            SqlConnection conn = DBConnect.Connect();
            //tạo command(select *....)
            SqlCommand cmd = conn.CreateCommand();
            //khai bao se dung store cho cmd
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "ListTuyen";
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
        public DataTable getTenTrambyTuyen()
        {
            //tạo kết nối mới

            SqlConnection conn = DBConnect.Connect();

            //tạo command(select *....)
            SqlCommand cmd = conn.CreateCommand();
            //khai bao se dung store cho cmd
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "getTenTrambyTuyen";
                      
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
        public DataTable GetTuyenById(DTO_TuyenXe tx)
        {
            //tạo kết nối mới

            SqlConnection conn = DBConnect.Connect();

            //tạo command(select *....)
            SqlCommand cmd = conn.CreateCommand();
            //khai bao se dung store cho cmd
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "GetTuyenById";
            SqlParameter prm1 = new SqlParameter("@idTuyen", tx.ID_Tuyen);

            cmd.Parameters.Add(prm1);



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
     
        public DataTable updateTramDen(DTO_TuyenXe tx)
        {
            SqlConnection conn = DBConnect.Connect();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "updateTramDen";
            SqlParameter prm1 = new SqlParameter("@id_Tuyen", tx.ID_Tuyen);
            SqlParameter prm2 = new SqlParameter("@id_TramDen", tx.Tram_ID_Tram);

            cmd.Parameters.Add(prm1);
            cmd.Parameters.Add(prm2);

            SqlDataAdapter da = new SqlDataAdapter(cmd);//thuc thi tra ve table
            DataTable dt = new DataTable();
            da.Fill(dt);
            DBConnect.Close(conn);
            return dt;
        }

        public bool Insert(DTO_TuyenXe tx)
        {

            //tạo kết nối mới
            SqlConnection conn = DBConnect.Connect();
            //tạo command
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "newTuyen";
           
            SqlParameter prm2 = new SqlParameter("@khoangCach", tx.KhoangCach);
            SqlParameter prm3 = new SqlParameter("@thoigianChay", tx.ThoiGianChay);
            SqlParameter prm4 = new SqlParameter("@tram_id_Tram1", tx.Tram_ID_Tram1);
            SqlParameter prm5 = new SqlParameter("@tram_id_Tram2", tx.Tram_ID_Tram);

            cmd.Parameters.Add(prm2);
            cmd.Parameters.Add(prm3);
            cmd.Parameters.Add(prm4);
            cmd.Parameters.Add(prm5);

            int row = cmd.ExecuteNonQuery();
            DBConnect.Close(conn);
            if(row>0)
            {
                return true;
            }
            return false;


        }

        public bool Delete(DTO_TuyenXe tx)
        {
            //tạo kết nối mới
            SqlConnection conn = DBConnect.Connect();
            //tạo command(select *....)
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "DeleteTuyenXe";
            SqlParameter Param1 = new SqlParameter("@idTuyen",tx.ID_Tuyen);
            cmd.Parameters.Add(Param1);

            int row = cmd.ExecuteNonQuery();
            DBConnect.Close(conn);

            if (row > 0)
            {
                return true;
            }
            return false;
        }
        public bool Update(DTO_TuyenXe tx)
        {
           
            try
            {
                SqlConnection conn = DBConnect.Connect();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "UpdateTuyenXe";


                SqlParameter Param1 = new SqlParameter("@idTuyen", tx.ID_Tuyen);
                SqlParameter Param2 = new SqlParameter("@khoangCach",tx.KhoangCach);
                SqlParameter Param3 = new SqlParameter("@thoiGianChay", tx.ThoiGianChay);
                SqlParameter Param4 = new SqlParameter("@tram_id_Tram1", tx.Tram_ID_Tram1);
                SqlParameter Param5 = new SqlParameter("@tram_id_Tram2", tx.Tram_ID_Tram);


                cmd.Parameters.Add(Param1);
                cmd.Parameters.Add(Param2);
                cmd.Parameters.Add(Param3);
                cmd.Parameters.Add(Param4);
                cmd.Parameters.Add(Param5);
                
                cmd.ExecuteNonQuery();
                DBConnect.Close(conn);
                return true;
            }
            catch
            {
                return false;
            }        
        }
    }
}
