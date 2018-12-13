using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaXe
{
    public partial class frmGhe : Form
    {
        private int _iTuyen;
        private string _ngayDi;

        public frmGhe(int iTuyen, string NgayDi)
        {
            InitializeComponent();

            this._iTuyen = iTuyen;
            this._ngayDi = NgayDi;

            LoadComboboxTimKiemChuyenXe();
        }
        
        void LoadComboboxTimKiemChuyenXe()
        {
            // tim danh sach cac chuyen xe theo id tuyen va ngay di


        }
    }
}
