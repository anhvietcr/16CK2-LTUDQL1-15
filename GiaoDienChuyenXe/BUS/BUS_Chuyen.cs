using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using System.Data;

namespace BUS
{
    public class BUS_Chuyen
    {
        DAL_Chuyen dal_chuyen = new DAL_Chuyen();

        public DataTable ListChuyen()
        {
            return dal_chuyen.listChuyen();
        }
        public DataTable ListcbbChuyen()
        {
            return dal_chuyen.ListcbbChuyen();
        }
        public DataTable ListcbbTuyen()
        {
            return dal_chuyen.ListcbbTuyen();
        }
        public DataTable ListcbbLoai()
        {
            return dal_chuyen.ListcbbLoai();
        }
        public DataTable ListChuyenDK(int tuyen,int chuyen,string loai)
        {
            return dal_chuyen.ListChuyenDK(tuyen, chuyen, loai);
        }
        public DataTable ListChuyenSearch(string tu,string den)
        {
            return dal_chuyen.ListChuyenSearch(tu, den);
        }
        public void DeleteChuyen(int ID_Chuyen)
        {
               dal_chuyen.DeleteChuyen(ID_Chuyen);               
        }
        public void UpdateChuyen(DTO_Chuyen c)
        {
            dal_chuyen.UpdateChuyen(c);
        }
        public void InsertChuyen(DTO_Chuyen c)
        {
            dal_chuyen.InsertChuyen(c);
        }
        public void execl(DataTable dt)
        {
            dal_chuyen.execl(dt);
        }

    }
}
