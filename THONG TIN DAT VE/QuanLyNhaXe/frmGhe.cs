using System;
using System.Data;
using System.Windows.Forms;
using DTO;
using BUS;

namespace QuanLyNhaXe
{
    public partial class frmGhe : Form
    {
        protected frmDatVe frmParent;
        protected int _idGhe = -1;

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

                DisplayMapGhe();
            } 
        }

        private void cbx_ten_xe_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = (sender as ComboBox).SelectedIndex;

            cbx_id_chuyen.SelectedIndex = index;
            cbx_id_loaixe.SelectedIndex = index;
            cbx_id_xe.SelectedIndex = index;
            cbx_ten_loaixe.SelectedIndex = index;

            DisplayMapGhe();
        }

        private void cbx_ten_loaixe_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = (sender as ComboBox).SelectedIndex;

            cbx_id_chuyen.SelectedIndex = index;
            cbx_id_loaixe.SelectedIndex = index;
            cbx_id_xe.SelectedIndex = index;
            cbx_ten_xe.SelectedIndex = index;

            DisplayMapGhe();
        }

        private void btn_chon_ghe_Click(object sender, EventArgs e)
        {
            BUS_Ghe bus_ghe = new BUS_Ghe();
            Ghe ghe = new Ghe();
            DatVe ve = new DatVe();

            if (this._idGhe == -1)
            {
                MessageBox.Show("Chưa chọn Ghế");
                return;
            }

            DataTable dt = new DataTable();
            dt = bus_ghe.getGheById(this._idGhe);
            if (dt == null)
            {
                MessageBox.Show("Không có thông tin Ghế được chọn");
                return;
            }
            DataRow r = dt.Rows[0];

            ve.GiaTien = Convert.ToInt32(cbx_giatien.Text);
            ve.IDChuyen = Convert.ToInt32(cbx_id_chuyen.Text);
            ghe.IDGhe = this._idGhe;
            ghe.Dong = Convert.ToInt32(r["Dong"]);
            ghe.Cot = Convert.ToInt32(r["Cot"]);
            ghe.Tang = Convert.ToInt32(r["Tang"]);
            ghe.SoGhe = Convert.ToInt32(r["So_ghe"]);
            ghe.IDXe = Convert.ToInt32(cbx_id_xe.Text);

            frmParent.getInfoChonGhe(ghe, ve);
            this.Close();
        }

        private void btnGhe_cliked(object sender, EventArgs e)
        {
            this._idGhe = Convert.ToInt32((sender as Button).Tag);

            MessageBox.Show((sender as Button).Text);
            MessageBox.Show(this._idGhe.ToString());
        }

        // Disable những ghế đã được đặt dựa theo ID chuyến và ngày đi
        private void DisableGheSelected()
        {

        }
        
        // Show/Hide map ghế dựa trên ID Xe và loại xe
        private void DisplayMapGhe()
        {
            int idXe = Convert.ToInt32(cbx_id_xe.Text);
            // show correct map
            switch (idXe)
            {
                case 1:
                    xe1_map28_tang1.Visible = true;
                    break;
                case 2:
                    xe2_map28_tang1.Visible = true;
                    break;
                case 3:
                    break;
                case 4:
                    break;
                default:
                    break;
            }


            // hide all other maps

        }
    }
}
