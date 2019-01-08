using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Xe
    {
        private int _XeID;

        public int XeID 
        {
            get { return _XeID; }
            set { _XeID = value; }
        }
        private string _TenXe;

        public string TenXe 
        {
            get { return _TenXe; }
            set { _TenXe = value; }
        }

        private string _So_dang_ky;

        public string So_dang_ky 
        {
            get { return _So_dang_ky; }
            set { _So_dang_ky = value; }
        }

        private  int _LoaiXe_ID_LoaiXe;

        public  int LoaiXe_ID_LoaiXe
        {
            get { return _LoaiXe_ID_LoaiXe; }
            set { _LoaiXe_ID_LoaiXe = value; }
        }

    }
}
