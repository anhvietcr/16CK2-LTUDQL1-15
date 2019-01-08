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
        public DataTable ListChuyenSearch(string tu,string den )
        {
            SqlConnection conn = DBConnect.Connect();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "listChuyenSearch";
            cmd.Parameters.Add(new SqlParameter { ParameterName = "Tu", Value = tu });
            cmd.Parameters.Add(new SqlParameter { ParameterName = "Den", Value = den });

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            DBConnect.Close(conn);

            return dt;
        }
        public bool DeleteChuyen(int ID_Chuyen)
        {
            try
            {
                SqlConnection conn = DBConnect.Connect();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "deleteChuyen";
                cmd.Parameters.Add(new SqlParameter { ParameterName = "ID_Chuyen", Value = ID_Chuyen });
                int row = cmd.ExecuteNonQuery();
                DBConnect.Close(conn);
                if (row > 0) return true;
                return false;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        public bool UpdateChuyen(DTO_Chuyen c)
        {
            try { 

                SqlConnection conn = DBConnect.Connect();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "updateChuyen";
                cmd.Parameters.Add(new SqlParameter { ParameterName = "ID_Chuyen", Value = c.ID_Chuyen });
                cmd.Parameters.Add(new SqlParameter { ParameterName = "Tuyen", Value = c.Tuyen_ID_Tuyen });
                cmd.Parameters.Add(new SqlParameter { ParameterName = "GKH", Value = c.Gio_khoi_hanh });
                cmd.Parameters.Add(new SqlParameter { ParameterName = "Ghichu", Value = c.Ghi_chu });
                cmd.Parameters.Add(new SqlParameter { ParameterName = "Xe", Value = c.Xe_XeID });
                cmd.Parameters.Add(new SqlParameter { ParameterName = "TaiXe", Value = c.Tai_xe_ID_TaiXe });
                int row = cmd.ExecuteNonQuery();
                DBConnect.Close(conn);

                if (row > 0) return true;
                return false;
                 }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
        }
        public bool InsertChuyen(DTO_Chuyen c)
        {
            try { 
                SqlConnection conn = DBConnect.Connect();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "insertChuyen";
                cmd.Parameters.Add(new SqlParameter { ParameterName = "Tuyen", Value = c.Tuyen_ID_Tuyen });
                cmd.Parameters.Add(new SqlParameter { ParameterName = "GKH", Value = c.Gio_khoi_hanh });
                cmd.Parameters.Add(new SqlParameter { ParameterName = "Ghichu", Value = c.Ghi_chu });
                cmd.Parameters.Add(new SqlParameter { ParameterName = "Xe", Value = c.Xe_XeID });
                cmd.Parameters.Add(new SqlParameter { ParameterName = "TaiXe", Value = c.Tai_xe_ID_TaiXe });
                int row = cmd.ExecuteNonQuery();
                DBConnect.Close(conn);

                if (row> 0) return true;
            return false;
            }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
        }
        public void execl(DataTable dt)
        {
            DAL_ExportToExcel excel = new DAL_ExportToExcel();
            excel.Export(dt, "Danh sach", "DANH SÁCH CÁC CHUYẾN XE");
        }
    }
}
