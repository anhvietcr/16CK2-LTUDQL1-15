using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BUS
{
    public class BUS_Xe
    {
        DAL_Xe dal_xe = new DAL_Xe();

        public DataTable ListXe()
        {
            return dal_xe.ListXe();
        }

    }
}
