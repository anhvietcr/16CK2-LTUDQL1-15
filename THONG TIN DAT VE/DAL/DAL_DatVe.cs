﻿using System;
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
                cmd.Parameters.Add(new SqlParameter { ParameterName = "ngayXuatVe", Value = ve.NgayXuatVe });
                cmd.Parameters.Add(new SqlParameter { ParameterName = "ghiChu", Value = ve.GhiChu });

                int newID = cmd.ExecuteNonQuery();
                DBConnect.Close(conn);

                if (newID > 0) return true;
                return false;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable listVe()
        {
            DataTable dt = new DataTable();

            try
            {
                SqlConnection conn = DBConnect.Connect();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "listVe";

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                DBConnect.Close(conn);
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool updateTinhtrangVe(int idVe, int tinhtrang)
        {
            try
            {
                SqlConnection conn = DBConnect.Connect();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "updateTinhtrangVe";
                cmd.Parameters.Add(new SqlParameter { ParameterName = "tinhTrang", Value = tinhtrang });
                cmd.Parameters.Add(new SqlParameter { ParameterName = "id", Value = idVe });

                int row = Convert.ToInt32(cmd.ExecuteNonQuery());
                DBConnect.Close(conn);

                if (row >= 1)
                    return true;
                return false;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool deleteVe(int idVe)
        {
            try
            {
                SqlConnection conn = DBConnect.Connect();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "deleteVe";
                cmd.Parameters.Add(new SqlParameter{ ParameterName = "id", Value = idVe});

                int row = Convert.ToInt32(cmd.ExecuteNonQuery());
                DBConnect.Close(conn);

                if (row >= 1)
                    return true;
                return false;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
