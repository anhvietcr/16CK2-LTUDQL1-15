using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Ghe
    {
        private int _idGhe;
        private int _dong;
        private int _cot;
        private int _tang;
        private int _idXe;

        public int IDXe
        {
            get { return _idXe; }
            set { _idXe = value; }
        }

        public int Tang
        {
            get { return _tang; }
            set { _tang = value; }
        }

        public int Cot
        {
            get { return _cot; }
            set { _cot = value; }
        }

        public int Dong
        {
            get { return _dong; }
            set { _dong = value; }
        }

        public int IDGhe
        {
            get { return _idGhe; }
            set { _idGhe = value; }
        }
    }
}
