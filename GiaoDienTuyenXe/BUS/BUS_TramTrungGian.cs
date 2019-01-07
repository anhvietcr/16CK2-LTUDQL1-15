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
   public class BUS_TramTrungGian
    {
        DAL_TramTrungGian dal_ttg = new DAL_TramTrungGian();
       

        public DataTable getTuyenIDTuyenbyTuyen()
        {
            return dal_ttg.getTuyenIdTuyenByTuyen();
        }

        public DataTable getIdTuyenIdTram()
        {
            return dal_ttg.getIdTuyenIdTram();
        }
        public bool InsertTramTG(DTO_TramTrungGian ttg)
        {
            return dal_ttg.InsertTramTG(ttg);
        }
      
        //public int updateTuyen(DTO_TramTrungGian ttg)
        //{
        //    return dal_ttg.updateTuyen(ttg);
        //}
       
    }
}
