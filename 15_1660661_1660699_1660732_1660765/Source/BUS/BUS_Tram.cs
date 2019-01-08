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
        public DataTable listTram()
        {
            return dal_tram.listTram();
        }
        public bool xoaTram(DTO_Tram tram)
        {
            return dal_tram.xoaTram(tram);
        }
        public bool suaTram(DTO_Tram tram)
        {
            return dal_tram.suaTram(tram);
        }
        public bool checkExistsTenTramInTram(DTO_Tram tram)
        {
            return dal_tram.checkExistsTenTramInTram(tram);
        }
    }
}
