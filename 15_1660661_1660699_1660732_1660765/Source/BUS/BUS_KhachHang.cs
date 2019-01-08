using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using System.Data;
using System.Data.SqlClient;
namespace BUS
{
    public class BUS_KhachHang
    {
        DAL_KhachHang dal_kh = new DAL_KhachHang();
        public DataTable ListKhachHang()
        {
            return dal_kh.ListKhachHang();
        }

        public DataTable ListKhachHangTheoTen(DTO_KhachHang khachhang)
        {
            return dal_kh.ListKhachHangTheoTen(khachhang);
        }
        public int ThemKhachHang(DTO_KhachHang kh)
        {
            return dal_kh.insertKhachHang(kh);
        }
        public void XoaKhachHang(int id)
        {
            dal_kh.deleteKhachHang(id);
        }
        public void SuaKhachHang(DTO_KhachHang kh)
        {
            dal_kh.updateKhachHang(kh);
        }
        public DataTable ListKhachHangTheoSDT(DTO_KhachHang khachhang)
        {
            return dal_kh.ListKhachHangTheoSDT(khachhang);
        }
        public DataTable timKhachHangTheoSDTVaTen(string ma)
        {
            return dal_kh.timKhachHangTheoSDTVaTen(ma);
        }
    }
}
