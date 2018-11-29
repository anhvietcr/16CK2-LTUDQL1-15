using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DTO
{
    public class DTO_Chuyen
    {
        private int _ID_Chuyen;

        public int ID_Chuyen
        {
            get { return _ID_Chuyen; }
            set { _ID_Chuyen = value; }
        }

        private int _Tuyen_ID_Tuyen;

        public int Tuyen_ID_Tuyen
        {
            get { return _Tuyen_ID_Tuyen; }
            set { _Tuyen_ID_Tuyen = value; }
        }
        private DateTime _Gio_khoi_hanh;

        public DateTime Gio_khoi_hanh
        {
            get { return _Gio_khoi_hanh; }
            set { _Gio_khoi_hanh = value; }
        }

        private  string _Ghi_chu;

        public  string Ghi_chu 
        {
            get { return _Ghi_chu; }
            set { _Ghi_chu = value; }
        }

        private int _Xe_XeID;

        public int Xe_XeID
        {
            get { return _Xe_XeID; }
            set { _Xe_XeID = value; }
        }

        private int _Tai_xe_ID_TaiXe;

        public int Tai_xe_ID_TaiXe
        {
            get { return _Tai_xe_ID_TaiXe ; }
            set { _Tai_xe_ID_TaiXe = value; }
        }







    }
}
