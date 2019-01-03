using BUS;
using DTO;
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
    public partial class frmKhachhang : Form
    {
        public frmDashboard frmDB;
        public frmKhachhang(frmDashboard frm)
        {
            InitializeComponent();
            this.frmDB = frm;
            ctr_navbar1.txt_title.Text = "Quản lí khách hàng";
            // button menu clicked
            /*ctr_menu1.btn_menu_1.Click += new EventHandler(btnMenu1_click);
            ctr_menu1.btn_menu_2.Click += new EventHandler(btnMenu2_click);
            ctr_menu1.btn_menu_3.Click += new EventHandler(btnMenu3_click);
            ctr_menu1.btn_menu_4.Click += new EventHandler(btnMenu4_click);
            ctr_menu1.btn_menu_5.Click += new EventHandler(btnMenu5_click);
            ctr_menu1.btn_menu_info.Click += new EventHandler(btnMenuInfo_click);
            */
            // button navbar clicked
            ctr_navbar1.btn_close.Click += new EventHandler(btnClose_click);
            ctr_navbar1.btn_toggle_menu.Click += new EventHandler(btnToggleMenu_click);

            // move form
            ctr_navbar1.MouseMove += new MouseEventHandler(ctr_navbar1_MouseMove);
            ctr_navbar1.MouseDown += new MouseEventHandler(ctr_navbar1_MouseDown);
            //load gridview
            loadGridKhachHangByTenKH();
            dgrv_kh.Click += new EventHandler(loadData);
        }
        void loadData(object sender, EventArgs e)
        {
            List<string> t = new List<string>();
            int row = dgrv_kh.CurrentCell.RowIndex;
            for (int i = 0; i < dgrv_kh.ColumnCount; i++)
            {
                string tt = dgrv_kh.Rows[row].Cells[i].Value.ToString();
                t.Add(tt);
            }
            txtma.Text = t[0];
            txtten.Text = t[1];
            txtsdt.Text = t[2];
            txtemail.Text = t[3];
            if (t[4] == "1")
                txtloai.Text = "Vip";
            else
                txtloai.Text = "Thường";
        }
        void loadGridKhachHangByTenKH()
        {
            DataTable dt = new DataTable();
            BUS_KhachHang bus_kh;
            //DTO_KhachHang dto_kh;
            //dto_kh = new DTO_KhachHang();
            //dto_kh.HOTEN = "Khách hàng 1";

            bus_kh = new BUS_KhachHang();
            dt = bus_kh.ListKhachHang();
            dgrv_kh.DataSource = dt;
        }
        //button menu clicked -> show Forms
        //void btnMenu1_click(object sender, EventArgs e)
        //{
        //    MessageBox.Show("Đặt vé clicked");
        //}

        //void btnMenu2_click(object sender, EventArgs e)
        //{
        //    //MessageBox.Show("Khách hàng clicked");
        //}

        //void btnMenu3_click(object sender, EventArgs e)
        //{
        //    MessageBox.Show("Chuyến xe clicked");
        //}

        //void btnMenu4_click(object sender, EventArgs e)
        //{
        //    MessageBox.Show("Tuyến xe clicked");
        //}

        //void btnMenu5_click(object sender, EventArgs e)
        //{
        //    //MessageBox.Show("Vé bán clicked");
        //    this.Close();
        //    frmDB.openFormById(0);

        //}

        //void btnMenuInfo_click(object sender, EventArgs e)
        //{
        //    MessageBox.Show("button info team clicked");
        //}

        //button navbar clicked
        void btnClose_click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        void btnToggleMenu_click(object sender, EventArgs e)
        {
            if (ctr_menu1.Width <= 85)
            {
                ctr_menu1.Width = 200;
                panel2.Width = 200;
            }
            else
            {
                ctr_menu1.Width = 85;
                panel2.Width = 85;
            }
        }

        //move form with border less
        public Point mouseLocation;
        void ctr_navbar1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(-mouseLocation.X, -mouseLocation.Y);
                Location = mousePos;
                Console.WriteLine(Location.X + ", " + Location.Y);
            }
        }

        void ctr_navbar1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(e.X, e.Y);
        }

        // effect load form
        void frmDatVe_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer_open_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1)
            {
                this.Opacity += 0.45;
            }
            else
            {
                timer1.Stop();
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
                timer2.Stop();

                //close this form and show dashboard form
                frmDB.Show();
                this.Close();
            }
        }
       

        private void btnsua_Click(object sender, EventArgs e)
        {
            DTO_KhachHang kh = new DTO_KhachHang();
            kh.HOTEN = txtten.Text;
            kh.DIENTHOAI = txtsdt.Text;
            kh.EMAIL = txtemail.Text;
            if (txtloai.Text == "Vip")
                kh.LOAI = 1;
            else
                kh.LOAI = 0;
            kh.ID_KHACHHANG = int.Parse(txtma.Text);
            BUS_KhachHang k = new BUS_KhachHang();
            k.SuaKhachHang(kh);
            loadGridKhachHangByTenKH();
        }

        private void btnthem_Click_1(object sender, EventArgs e)
        {
            DTO_KhachHang kh = new DTO_KhachHang();
            kh.HOTEN = txtten.Text;
            kh.DIENTHOAI = txtsdt.Text;
            kh.EMAIL = txtemail.Text;
            if (txtloai.Text == "Vip")
                kh.LOAI = 1;
            else
                kh.LOAI = 0;
            BUS_KhachHang k = new BUS_KhachHang();
            int ID = k.ThemKhachHang(kh);
            loadGridKhachHangByTenKH();
        }

        private void btnxoa_Click_1(object sender, EventArgs e)
        {
            BUS_KhachHang kh = new BUS_KhachHang();
            kh.XoaKhachHang(int.Parse(txtma.Text));
            loadGridKhachHangByTenKH();
        }
    }
}
