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
    public class DAL_KhachHang
    {
        public DataTable ListKhachHang()
        {
            try
            {
                SqlConnection conn = DBConnect.Connect();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "listKhachHang";

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                DBConnect.Close(conn);
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable ListKhachHangTheoTen(DTO_KhachHang khachhang)
        {
            try
            {
                SqlConnection conn = DBConnect.Connect();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "timKhachHangTheoTen";
                cmd.Parameters.Add(new SqlParameter { ParameterName = "ten", Value = khachhang.HOTEN });

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                DBConnect.Close(conn);
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void insertKhachHang(DTO_KhachHang kh)
        {
            try
            {
                SqlConnection con = DBConnect.Connect();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "themkhachhang";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter { ParameterName = "tenkh", Value = kh.HOTEN });
                cmd.Parameters.Add(new SqlParameter { ParameterName = "sdt", Value = kh.DIENTHOAI });
                cmd.Parameters.Add(new SqlParameter { ParameterName = "email", Value = kh.EMAIL });
                cmd.Parameters.Add(new SqlParameter { ParameterName = "loai", Value = kh.LOAI });
                cmd.ExecuteNonQuery();
                DBConnect.Close(con);
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void deleteKhachHang(int id)
        {
            try
            {
                SqlConnection con = DBConnect.Connect();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "xoakhachhang";
                cmd.Parameters.Add(new SqlParameter { ParameterName = "makh", Value = id });
                cmd.ExecuteNonQuery();
                DBConnect.Close(con);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void updateKhachHang(DTO_KhachHang kh)
        {
            try
            {
                SqlConnection con = DBConnect.Connect();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "suakhachhang";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter { ParameterName = "makh", Value = kh.ID_KHACHHANG });
                cmd.Parameters.Add(new SqlParameter { ParameterName = "tenkh", Value = kh.HOTEN });
                cmd.Parameters.Add(new SqlParameter { ParameterName = "sdt", Value = kh.DIENTHOAI });
                cmd.Parameters.Add(new SqlParameter { ParameterName = "email", Value = kh.EMAIL });
                cmd.Parameters.Add(new SqlParameter { ParameterName = "loai", Value = kh.LOAI });
                cmd.ExecuteNonQuery();
                DBConnect.Close(con);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
