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
    public class BUS_DatVe
    {
        DAL_DatVe dal_ve = new DAL_DatVe();

        public DataTable getTenTrambyTuyen()
        {
            return dal_ve.getTenTrambyTuyen();
        }

        public bool newVe(DatVe ve)
        {
            return dal_ve.newVe(ve);
        }

        public DataTable listVe()
        {
            return dal_ve.listVe();
        }

        public bool updateTinhtrangVe(int idVe, int tinhtrang)
        {
            return dal_ve.updateTinhtrangVe(idVe, tinhtrang);
        }

        public bool deleteVe(int idVe)
        {
            return dal_ve.deleteVe(idVe);
        }
    }
}
