using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class DTO_TramTrungGian
    {
        private int _tuyenIDTuyen;
        private int _tramIDTram;
        private int _thuTu;

        public int TuyenIDTuyen { get => _tuyenIDTuyen; set => _tuyenIDTuyen = value; }
        public int TramIDTram { get => _tramIDTram; set => _tramIDTram = value; }
        public int ThuTu { get => _thuTu; set => _thuTu = value; }
    }
}
