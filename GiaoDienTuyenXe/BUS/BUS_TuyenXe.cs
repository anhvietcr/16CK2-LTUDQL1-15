using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
using DTO;

namespace BUS
{
    public class BUS_TuyenXe
    {
        //kết nối tới DAL_TuyenXe
        DAL_TuyenXe dal_tuyenxe = new DAL_TuyenXe();
        public DataTable ListTuyenXe()
        {
            //tra ve 1 table
            return dal_tuyenxe.ListTuyenXe();

        }
        public DataTable getTenTrambyTuyen()
        {
            return dal_tuyenxe.getTenTrambyTuyen();
        }
        public DataTable GetTuyenById(DTO_TuyenXe tx)
        {
            return dal_tuyenxe.GetTuyenById(tx);
        }
        public DataTable updateTramDen(DTO_TuyenXe tx)
        {
            return dal_tuyenxe.updateTramDen(tx);
        }
      
        public bool Insert(DTO_TuyenXe tx)
        {
            return dal_tuyenxe.Insert(tx);
        }
        public bool Delete(DTO_TuyenXe tx)
        {
            return dal_tuyenxe.Delete(tx);
        }
        public bool Update(DTO_TuyenXe tx)
        {
            return dal_tuyenxe.Update(tx);
        }
    }
}
