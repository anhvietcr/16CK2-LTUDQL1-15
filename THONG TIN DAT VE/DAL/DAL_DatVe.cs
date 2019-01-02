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

        public bool newVe(DatVe ve)
        {

            try
            {
                SqlConnection conn = DBConnect.Connect();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "newVe";
                cmd.Parameters.Add(new SqlParameter { ParameterName = "id_ghe", Value = ve.IDGhe });
                cmd.Parameters.Add(new SqlParameter { ParameterName = "id_chuyen", Value = ve.IDChuyen });
                cmd.Parameters.Add(new SqlParameter { ParameterName = "tinhTrang", Value = ve.TinhTrang });
                cmd.Parameters.Add(new SqlParameter { ParameterName = "giaTien", Value = ve.GiaTien });
                cmd.Parameters.Add(new SqlParameter { ParameterName = "id_KhachHang", Value = ve.IDKhachHang });
                cmd.Parameters.Add(new SqlParameter { ParameterName = "ngayXuatVe", Value = ve.NgayXuatVe});
                cmd.Parameters.Add(new SqlParameter { ParameterName = "ghiChu", Value = ve.GhiChu });

                int newID = (int)cmd.ExecuteScalar();
                if (newID > 0)
                {
                    DBConnect.Close(conn);
                    return true;
                }
                DBConnect.Close(conn);
                return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
