using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_TuyenXe
    {
        private int _id_Tuyen;

        public int ID_Tuyen
        {
            get { return _id_Tuyen; }
            set { _id_Tuyen = value; }
        }

        private double _khoangCach;

        public double KhoangCach
        {
            get { return _khoangCach; }
            set { _khoangCach = value; }
        }

        private int _thoiGianChay;

        public int ThoiGianChay
        {
            get { return _thoiGianChay; }
            set { _thoiGianChay = value; }
        }

        private int _tram_ID_Tram1;

        public int Tram_ID_Tram1
        {
            get { return _tram_ID_Tram1; }
            set { _tram_ID_Tram1 = value; }
        }

        private int _tram_ID_Tram;

        public int Tram_ID_Tram
        {
            get { return _tram_ID_Tram; }
            set { _tram_ID_Tram = value; }
        }

    }
   
}
