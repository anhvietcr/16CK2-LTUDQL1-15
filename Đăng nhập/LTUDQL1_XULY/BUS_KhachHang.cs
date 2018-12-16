using LTUDQL1_DULIEU;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTUDQL1_XULY
{
    public class BUS_KhachHang
    {
        public DataTable LayDSKhachHang()
        {
            DAO_KhachHang daoKhachHang = new DAO_KhachHang();
            DataTable dtKhachHang = daoKhachHang.LayDSKhachHang();


            return dtKhachHang;

        }

        public void CapNhatDSKhachHang(DataTable dtKhachHang)
        {
            DAO_KhachHang daoKhachHang = new DAO_KhachHang();

            //xử lý nghiệp vụ...


            daoKhachHang.CapNhatBangKhachHang(dtKhachHang);
        }
    }
}
