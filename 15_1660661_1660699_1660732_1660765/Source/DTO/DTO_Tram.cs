using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Tram
    {
        private int _id_Tram;
        private string _ten_Tram;
        private string _dia_Diem;
        public int Id_Tram { get => _id_Tram; set => _id_Tram = value; }
        public string Ten_Tram { get => _ten_Tram; set => _ten_Tram = value; }
        public string Dia_Diem { get => _dia_Diem; set => _dia_Diem = value; }
    }
}
