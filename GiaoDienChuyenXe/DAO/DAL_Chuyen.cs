using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DAL_Chuyen
    {
        DataTable dt = new DataTable();

        public DataTable listChuyen()
        {
            //tạo Sqlconnection để connect
            SqlConnection conn = DBConnect.Connect();
            //tạo cmd để chứ câu truy vấn vào csdl
            SqlCommand cmd = conn.CreateCommand();
            //cài đặt cmd để truy vấn các stored Procedure
            cmd.CommandType = CommandType.StoredProcedure;
            //Đưa tên Procedure vào cmd text
            cmd.CommandText = "listChuyen";

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            DBConnect.Close(conn);

            return dt;
        }
        public DataTable ListcbbChuyen()
        {
            SqlConnection conn = DBConnect.Connect();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "listcbbChuyen";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            DBConnect.Close(conn);
            return dt;
        }
        public DataTable ListcbbTuyen()
        {
            SqlConnection conn = DBConnect.Connect();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "listcbbTuyen";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            DBConnect.Close(conn);
            return dt;
        }
        public DataTable ListcbbLoai()
        {
            SqlConnection conn = DBConnect.Connect();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "listcbbLoai";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            DBConnect.Close(conn);
            return dt;
        }
        public DataTable ListChuyenDK(int tuyen,int chuyen,string loai)
        {
            SqlConnection conn = DBConnect.Connect();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "listChuyenDK";
            cmd.Parameters.Add(new SqlParameter { ParameterName = "Tuyen", Value = tuyen });
            cmd.Parameters.Add(new SqlParameter { ParameterName = "Chuyen", Value = chuyen });
            cmd.Parameters.Add(new SqlParameter { ParameterName = "Loai", Value = loai });

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            DBConnect.Close(conn);

            return dt;
        }
    }
}
