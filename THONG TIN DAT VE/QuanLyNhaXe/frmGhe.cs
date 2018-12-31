using System;
using System.Data;
using System.Windows.Forms;
using DTO;

namespace QuanLyNhaXe
{
    public partial class frmGhe : Form
    {
        protected frmDatVe frmParent;

        public frmGhe(DataTable dt_ChuyenXe, frmDatVe frm)
        {
            InitializeComponent();
            this.frmParent = frm;

            LoadComboboxTimKiemChuyenXe(dt_ChuyenXe);
        }
        
        void LoadComboboxTimKiemChuyenXe(DataTable dt)
        {
            // tim danh sach cac chuyen xe theo id tuyen va ngay di
            foreach (DataRow r in dt.Rows)
            {
                cbx_ten_xe.Items.Add(r["TenXe"]);
                cbx_ten_loaixe.Items.Add(r["TenLoai"]);
                cbx_id_chuyen.Items.Add(r["ID_Chuyen"]);
                cbx_id_xe.Items.Add(r["XeID"]);
                cbx_id_loaixe.Items.Add(r["ID_LoaiXe"]);
            }
            
            if (cbx_id_chuyen.Items.Count > 0)
            {
                cbx_ten_loaixe.SelectedIndex = 0;
                cbx_ten_xe.SelectedIndex = 0;
                cbx_id_chuyen.SelectedIndex = 0;
                cbx_id_loaixe.SelectedIndex = 0;
                cbx_id_xe.SelectedIndex = 0;
            }
        }

        private void cbx_ten_xe_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = (sender as ComboBox).SelectedIndex;

            cbx_id_chuyen.SelectedIndex = index;
            cbx_id_loaixe.SelectedIndex = index;
            cbx_id_xe.SelectedIndex = index;
            cbx_ten_loaixe.SelectedIndex = index;
        }

        private void cbx_ten_loaixe_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = (sender as ComboBox).SelectedIndex;

            cbx_id_chuyen.SelectedIndex = index;
            cbx_id_loaixe.SelectedIndex = index;
            cbx_id_xe.SelectedIndex = index;
            cbx_ten_xe.SelectedIndex = index;
        }

        private void btn_chon_ghe_Click(object sender, EventArgs e)
        {
            Ghe ghe = new Ghe();
            DatVe ve = new DatVe();

            ve.GiaTien = Convert.ToInt32(cbx_giatien.Text);
            ve.IDChuyen = Convert.ToInt32(cbx_id_chuyen.Text);
            ghe.Dong = 0;
            ghe.Cot = 1;
            ghe.Tang = 1;
            ghe.IDGhe = 1;
            ghe.IDXe = Convert.ToInt32(cbx_id_xe.Text);

            frmParent.getInfoChonGhe(ghe, ve);
        }

        private void btnGhe_cliked(object sender, EventArgs e)
        {
            MessageBox.Show((sender as Button).Text);
            MessageBox.Show(((sender as Button).Tag.ToString()));
        }
    }
}
