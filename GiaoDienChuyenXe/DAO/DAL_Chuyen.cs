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
        public void DeleteChuyen(int ID_Chuyen)
        {    
            DAL dal = new DAL();
            dal.Connect();

            dal.ExecuteNonQuery(CommandType.StoredProcedure,"deleteChuyen",
                                            new SqlParameter { ParameterName = "ID_Chuyen", Value = ID_Chuyen });
            dal.DisConnected();
        }
        public void UpdateChuyen(DTO_Chuyen c)
        {
            DAL dal = new DAL();
            dal.Connect();
            dal.ExecuteNonQuery(CommandType.StoredProcedure, "updateChuyen", 
                        new SqlParameter { ParameterName = "ID_Chuyen", Value = c.ID_Chuyen },
                         new SqlParameter { ParameterName = "Tuyen", Value = c.Tuyen_ID_Tuyen },
                          new SqlParameter { ParameterName = "GKH", Value = c.Gio_khoi_hanh },
                           new SqlParameter { ParameterName = "Ghichu", Value = c.Ghi_chu },
                            new SqlParameter { ParameterName = "Xe", Value = c.Xe_XeID },
                             new SqlParameter { ParameterName = "TaiXe", Value = c.Tai_xe_ID_TaiXe });
            dal.DisConnected();
        }
        public void InsertChuyen(DTO_Chuyen c)
        {
            DAL dal = new DAL();
            dal.Connect();
            dal.ExecuteNonQuery(CommandType.StoredProcedure, "insertChuyen",
                        new SqlParameter { ParameterName = "ID_Chuyen", Value = c.ID_Chuyen },
                         new SqlParameter { ParameterName = "Tuyen", Value = c.Tuyen_ID_Tuyen },
                          new SqlParameter { ParameterName = "GKH", Value = c.Gio_khoi_hanh },
                           new SqlParameter { ParameterName = "Ghichu", Value = c.Ghi_chu },
                            new SqlParameter { ParameterName = "Xe", Value = c.Xe_XeID },
                             new SqlParameter { ParameterName = "TaiXe", Value = c.Tai_xe_ID_TaiXe });
            dal.DisConnected();
        }
        public void execl(DataTable dt)
        {
            DAL_ExportToExcel excel = new DAL_ExportToExcel();
            excel.Export(dt, "Danh sach", "DANH SÁCH CÁC CHUYẾN XE");
        }
    }
}
