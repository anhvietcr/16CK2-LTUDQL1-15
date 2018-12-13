using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using BUS;
using DTO;

namespace QuanLyNhaXe
{
    public partial class frmDatVe : Form
    {
        public frmDashboard frmDB;
        public frmDatVe(frmDashboard frm)
        {
            InitializeComponent();
            frmDB = frm;
            ctr_menu.btn_menu_1.Enabled = false;
            ctr_navbar.txt_title.Text = "Đặt Vé";

            // button menu clicked
            ctr_menu.btn_menu_2.Click += new EventHandler(btnMenu2_click);
            ctr_menu.btn_menu_3.Click += new EventHandler(btnMenu3_click);
            ctr_menu.btn_menu_4.Click += new EventHandler(btnMenu4_click);
            ctr_menu.btn_menu_5.Click += new EventHandler(btnMenu5_click);
            ctr_menu.btn_menu_info.Click += new EventHandler(btnMenuInfo_click);

            // button navbar clicked
            ctr_navbar.btn_close.Click += new EventHandler(btnClose_click);
            ctr_navbar.btn_toggle_menu.Click += new EventHandler(btnToggleMenu_click);

            // move form
            ctr_navbar.MouseMove += new MouseEventHandler(ctr_navbar1_MouseMove);
            ctr_navbar.MouseDown += new MouseEventHandler(ctr_navbar1_MouseDown);
        }

        //button menu clicked -> show Forms
        void btnMenu2_click(object sender, EventArgs e)
        {
            frmDB.openFormById(2);
            this.Close();
        }

        void btnMenu3_click(object sender, EventArgs e)
        {
            MessageBox.Show("Chuyến xe clicked");
        }

        void btnMenu4_click(object sender, EventArgs e)
        {
            MessageBox.Show("Tuyến xe clicked");
        }

        void btnMenu5_click(object sender, EventArgs e)
        {
            timer_close.Start();
        }

        void btnMenuInfo_click(object sender, EventArgs e)
        {
            frmDB.Show();
            frmDB.openFormById(5);
            this.Close();
        }

        //button navbar clicked
        void btnClose_click(object sender, EventArgs e)
        {
            timer_close.Start();
        }

        void btnToggleMenu_click(object sender, EventArgs e)
        {
            if (ctr_menu.Width <= 85)
            {
                ctr_menu.Width = 200;
                panel2.Width = 200;
                ctr_navbar.btn_toggle_menu.ImageIndex = 0;
            }
            else
            {
                ctr_menu.Width = 85;
                panel2.Width = 85;
                ctr_navbar.btn_toggle_menu.ImageIndex = 2;
            }
        }

        //move form with border less
        public Point mouseLocation;
        void ctr_navbar1_MouseMove(object sender, MouseEventArgs e)
        {

        }

        void ctr_navbar1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(e.X, e.Y);
        }

        private void timer_open_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1)
            {
                this.Opacity += 0.45;
            }
            else
            {
                timer_open.Stop();
            }
        }

        private void timer_close_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0.0)
            {
                this.Opacity -= 0.45;
            }
            else
            {
                timer_close.Stop();

                //close this form and show dashboard form
                frmDB.Show();
                this.Close();
            }
        }

        // effect load form
        void frmDatVe_Load(object sender, EventArgs e)
        {
            timer_open.Start();

            loadComboboxTuyenXe();

            // loadComboboxGhe();   
        }

        /// <summary>
        /// Load two combobox Ten Tram by Tuyen Xe
        /// </summary>
        void loadComboboxTuyenXe()
        {
            DataTable dt = new DataTable();
            BUS_DatVe bus_datve = new BUS_DatVe();

            dt = bus_datve.getTenTrambyTuyen();

            foreach (DataRow r in dt.Rows)
            {
                cbx_location_start.Items.Add(r["TramBatDau"]);
                cbx_location_end.Items.Add(r["TramKetThuc"]);
                cbx_id_location_start.Items.Add(r["IDTramBatDau"]);
                cbx_id_location_end.Items.Add(r["IDTramKetThuc"]);
                cbx_id_tuyen.Items.Add(r["ID_Tuyen"]);
            }

            if (cbx_id_tuyen.Items.Count > 0)
            {
                cbx_location_end.SelectedIndex = 0;
                cbx_location_start.SelectedIndex = 0;
                cbx_id_location_end.SelectedIndex = 0;
                cbx_id_location_end.SelectedIndex = 0;
                cbx_id_tuyen.SelectedIndex = 0;
            }
        }

        /// <summary>
        /// Điểm đi và điểm đến thay đổi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbx_location_start_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnableBtnChonGhe();
        }

        private void cbx_location_end_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnableBtnChonGhe();
        }

        void EnableBtnChonGhe()
        {
            if (string.IsNullOrEmpty(cbx_location_start.Text) || string.IsNullOrEmpty(cbx_location_end.Text))
            {
                btn_select_ghe.Enabled = false;
                return;
            }
            btn_select_ghe.Enabled = true;
        }

        /// <summary>
        /// En-Disable các input khách hàng
        /// </summary>
        /// <param name="notFoundKH"></param>
        void EnableBtnKhachHang(bool notFoundKH)
        {
            if (notFoundKH)
            {
                txt_name.Enabled = true;
                txt_email.Enabled = true;
                cbx_type.Enabled = true;
            } else
            {
                txt_name.Enabled = false;
                txt_email.Enabled = false;
                cbx_type.Enabled = false;
            }
        }

        /// <summary>
        /// Tìm kiếm Khách hàng bằng số điện thoại
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_phone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (findKhachHangByPhone(txt_phone.Text))
                {
                    MessageBox.Show("tim thay");
                    EnableBtnKhachHang(false);
                } else
                {
                    MessageBox.Show("Khong tim thay");
                    EnableBtnKhachHang(true);
                }
            }
        }

        private bool findKhachHangByPhone(string phone)
        {
            return false;
        }

        /// <summary>
        /// Bắt đầu chọn ghế theo tuyến xe và ngày đã chọn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_select_ghe_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbx_location_start.Text) 
             || string.IsNullOrEmpty(cbx_location_end.Text))
            {
                MessageBox.Show("Không tìm thấy tuyến xe yêu cầu");
                return;
            }

//            int iTuyen = Convert.ToInt32(cbx_id_tuyen.Text);
            int iTuyen = 1;
            string ngayDi = dpk_ngay_di.Value.Date.ToString();

            frmGhe frm = new frmGhe(iTuyen, ngayDi);
            frm.ShowDialog();
        }

        /// <summary>
        /// Thực hiện đặt vé
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_submit_datve_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbx_location_start.Text)
             || string.IsNullOrEmpty(cbx_location_end.Text)
             || string.IsNullOrEmpty(so_luong_ve.Value.ToString())
             || string.IsNullOrEmpty(dpk_ngay_di.Value.ToString())
             || string.IsNullOrEmpty(txt_gia_tien.Text)
             || string.IsNullOrEmpty(txt_phone.Text)
             || string.IsNullOrEmpty(txt_name.Text)
             || string.IsNullOrEmpty(cbx_type.Text))
            {
                MessageBox.Show("Điền đầy đủ thông tin");
                return;
            }

            MessageBox.Show("Đặt vé thành công");
        }
    }
}