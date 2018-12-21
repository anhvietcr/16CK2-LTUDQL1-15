using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DatVe
    {
        private int _idVe;
        private int _idGhe;
        private int _idChuyen;
        private int _idKhachHang;
        private string _ngayXuatVe;
        private double _giaTien;
        private int _tinhTrang;
        private string _ghiChu;

        public string GhiChu
        {
            get { return _ghiChu; }
            set { _ghiChu = value; }
        }

        public int TinhTrang
        {
            get { return _tinhTrang; }
            set { _tinhTrang = value; }
        }

        public double GiaTien
        {
            get { return _giaTien; }
            set { _giaTien = value; }
        }

        public string NgayXuatVe
        {
            get { return _ngayXuatVe; }
            set { _ngayXuatVe = value; }
        }

        public int IDKhachHang
        {
            get { return _idKhachHang; }
            set { _idKhachHang = value; }
        }

        public int IDChuyen
        {
            get { return _idChuyen; }
            set { _idChuyen = value; }
        }

        public int IDGhe
        {
            get { return _idGhe; }
            set { _idGhe = value; }
        }

        public int IDVe
        {
            get { return _idVe; }
            set { _idVe = value; }
        }

    }
}
