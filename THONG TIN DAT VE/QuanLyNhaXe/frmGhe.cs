using System;
using System.Data;
using System.Windows.Forms;
using DTO;
using BUS;
using System.Collections.Generic;
using System.Drawing;

namespace QuanLyNhaXe
{
    public partial class frmGhe : Form
    {
        protected frmDatVe frmParent;
        protected int _idGhe = -1;
        private Button _prevBtn = null;
        private Button _curBtn = null;

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

            DisableGheSelected();
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
            // get tag => ID ghe
            this._idGhe = Convert.ToInt32((sender as Button).Tag);
            this._curBtn = (sender as Button);

            // set color for button selected
            this._curBtn.BackColor = Color.FromArgb(255, 255, 255);
            if (this._prevBtn == null)
            {
                this._prevBtn = (sender as Button);
            } else
            {
                this._prevBtn.BackColor = Color.Gainsboro;
                this._prevBtn = (sender as Button);
            }
        }

        // Disable những ghế đã được đặt dựa theo ID chuyến và ngày đi
        private void DisableGheSelected()
        {
            List<int> IDsGhe = new List<int>();
            BUS_Ghe bus_ghe = new BUS_Ghe();

            int id_chuyen = Convert.ToInt32(cbx_id_chuyen.Text);
            int id_xe = Convert.ToInt32(cbx_id_xe.Text);
            IDsGhe = bus_ghe.getGheByChuyenAndXe(id_chuyen, id_xe);

            // show button Ghe is selected
            switch (id_xe)
            {
                case 1:
                    foreach (Control button in xe1_map28_tang1.Controls)
                    {
                        if (button is Button)
                        {
                            Button btn = button as Button;
                            foreach (int id in IDsGhe)
                            {
                                if (Convert.ToInt32(btn.Tag) == id)
                                {
                                    btn.Enabled = false;
                                    break;
                                }
                            }
                        }
                    }
                    break;
                case 2:
                    foreach (Control button in xe2_map28_tang1.Controls)
                    {
                        if (button is Button)
                        {
                            Button btn = button as Button;
                            foreach (int id in IDsGhe)
                            {
                                if (Convert.ToInt32(btn.Tag) == id)
                                {
                                    btn.Enabled = false;
                                    break;
                                }
                            }
                        }
                    }
                    break;
                case 3:
                    foreach (Control button in xe3_map45_tang1.Controls)
                    {
                        if (button is Button)
                        {
                            Button btn = button as Button;
                            foreach (int id in IDsGhe)
                            {
                                if (Convert.ToInt32(btn.Tag) == id)
                                {
                                    btn.Enabled = false;
                                    break;
                                }
                            }
                        }
                    }
                    break;
                case 4:
                    foreach (Control button in xe4_map46_tang1.Controls)
                    {
                        if (button is Button)
                        {
                            Button btn = button as Button;
                            foreach (int id in IDsGhe)
                            {
                                if (Convert.ToInt32(btn.Tag) == id)
                                {
                                    btn.Enabled = false;
                                    break;
                                }
                            }
                        }
                    }
                    foreach (Control button in xe4_map46_tang2.Controls)
                    {
                        if (button is Button)
                        {
                            Button btn = button as Button;
                            foreach (int id in IDsGhe)
                            {
                                if (Convert.ToInt32(btn.Tag) == id)
                                {
                                    btn.Enabled = false;
                                    break;
                                }
                            }
                        }
                    }
                    break;
                default:
                    break;
            }
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

                    // hide all other maps
                    xe2_map28_tang1.Visible = false;
                    xe3_map45_tang1.Visible = false;
                    xe4_map46_tang1.Visible = false;
                    xe4_map46_tang2.Visible = false;
                    break;
                case 2:
                    xe2_map28_tang1.Visible = true;

                    // hide all other maps
                    xe1_map28_tang1.Visible = false;
                    xe3_map45_tang1.Visible = false;
                    xe4_map46_tang1.Visible = false;
                    xe4_map46_tang2.Visible = false;
                    break;
                case 3:
                    xe3_map45_tang1.Visible = true;

                    // hide all other maps
                    xe1_map28_tang1.Visible = false;
                    xe2_map28_tang1.Visible = false;
                    xe4_map46_tang1.Visible = false;
                    xe4_map46_tang2.Visible = false;
                    break;
                case 4:
                    xe4_map46_tang1.Visible = true;
                    xe4_map46_tang2.Visible = true;

                    // hide all other maps
                    xe1_map28_tang1.Visible = false;
                    xe2_map28_tang1.Visible = false;
                    xe3_map45_tang1.Visible = false;
                    break;
                default:
                    xe1_map28_tang1.Visible = false;
                    xe2_map28_tang1.Visible = false;
                    xe3_map45_tang1.Visible = false;
                    xe4_map46_tang1.Visible = false;
                    xe4_map46_tang2.Visible = false;
                    break;
            }
        }
    }
}
