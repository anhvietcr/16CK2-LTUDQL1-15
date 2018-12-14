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
    public class BUS_Tram
    {
        DAL_Tram dal_tram = new DAL_Tram();

        public bool Insert(DTO_Tram tram)
        {
            return dal_tram.Insert(tram);
        }
        public DataTable listTenTram()
        {
            return dal_tram.listTenTram();
        }




    }
}
