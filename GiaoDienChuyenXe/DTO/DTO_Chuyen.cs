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
        private int _Tuyen_ID_Tuyen;
        private DateTime _Gio_hhoi_hanh;
        private string _Ghi_Chu;
        private int Xe_XeID;
        private int Tai_xe_ID_TaiXe;
        public int Tuyen_ID_Tuyen { get => _Tuyen_ID_Tuyen; set => _Tuyen_ID_Tuyen = value; }
        public DateTime Gio_hhoi_hanh { get => _Gio_hhoi_hanh; set => _Gio_hhoi_hanh = value; }
        public string Ghi_Chu { get => _Ghi_Chu; set => _Ghi_Chu = value; }
        public int Xe_XeID1 { get => Xe_XeID; set => Xe_XeID = value; }
        public int Tai_xe_ID_TaiXe1 { get => Tai_xe_ID_TaiXe; set => Tai_xe_ID_TaiXe = value; }
    }
}
