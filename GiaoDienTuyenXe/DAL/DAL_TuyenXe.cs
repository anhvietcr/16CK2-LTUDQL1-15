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
            //cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandType = CommandType.Text;
            //cmd.CommandText = "ListTuyen";
            cmd.CommandText = "select * from Tuyen";
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
            //cmd.CommandType = CommandType.StoredProcedure;
            //cmd.CommandText = "getTenTrambyTuyen";
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select distinct(t.ID_Tuyen), tram_bat_dau.TenTram as TramBatDau, tram_ket_thuc.TenTram as TramKetThuc, tram_bat_dau.ID_Tram as IDTramBatDau, tram_ket_thuc.ID_Tram as IDTramKetThuc from Tuyen t,(select * from Tram tr) as tram_bat_dau,(select * from Tram tr) as tram_ket_thuc where t.Tram_ID_Tram1 = tram_bat_dau.ID_Tram and t.Tram_ID_Tram = tram_ket_thuc.ID_Tram";
                      
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
        
        public bool Them(DTO_TuyenXe tx)
        {

            //tạo kết nối mới
            SqlConnection conn = DBConnect.Connect();
            //tạo command
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select @idTuyen = COUNT(*) from Tuyen set @idTuyen += 1";
            cmd.CommandText += " insert into Tuyen values(@idTuyen, @khoangCach, @thoiGianChay, @tram_id_Tram1, @tram_id_Tram2)";
            SqlParameter prm1 = new SqlParameter("@idTuyen", tx.ID_Tuyen);
            SqlParameter prm2 = new SqlParameter("@khoangCach", tx.KhoangCach);
            SqlParameter prm3 = new SqlParameter("@thoigianChay", tx.ThoiGianChay);
            SqlParameter prm4 = new SqlParameter("@tram_id_Tram1", tx.Tram_ID_Tram1);
            SqlParameter prm5 = new SqlParameter("@tram_id_Tram2", tx.Tram_ID_Tram);

            cmd.Parameters.Add(prm1);
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
        
    }
}
