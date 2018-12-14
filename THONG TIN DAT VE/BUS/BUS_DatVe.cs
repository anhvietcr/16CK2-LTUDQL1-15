using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BUS
{
    public class BUS_DatVe
    {
        DAL_DatVe dal = new DAL_DatVe();

        public DataTable getTenTrambyTuyen()
        {
            return dal.getTenTrambyTuyen();
        }
    }
}
