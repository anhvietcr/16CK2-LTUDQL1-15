using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_KhachHang
    {
        private int _id_khachang;

        public int ID_KHACHHANG
        {
            get { return _id_khachang; }
            set { _id_khachang = value; }
        }
        private string _hoten;

        public string HOTEN
        {
            get { return _hoten; }
            set { _hoten = value; }
        }
        private string _dienthoai;

        public string DIENTHOAI
        {
            get { return _dienthoai; }
            set { _dienthoai = value; }
        }
        private string _email;

        public string EMAIL
        {
            get { return _email; }
            set { _email = value; }
        }
        private int _loai;

        public int LOAI
        {
            get { return _loai; }
            set { _loai = value; }
        }
    }
}
