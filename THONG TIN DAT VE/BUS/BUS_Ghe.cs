using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BUS
{
    public class BUS_Ghe
    {
        DAL_Ghe dal_ghe = new DAL_Ghe();
        public DataTable listChonGhe(int idTuyen, string ngayDi)
        {
            return dal_ghe.listChonGhe(idTuyen, ngayDi);
        }

        public DataTable getGheById(int id)
        {
            return dal_ghe.getGheById(id);
        }
    }
}
