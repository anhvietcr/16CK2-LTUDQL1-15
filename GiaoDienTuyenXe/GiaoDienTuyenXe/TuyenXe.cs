using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiaoDienTuyenXe
{
    public partial class frmTuyenXe : Form
    {
        public frmTuyenXe()
        {
            InitializeComponent();
            // button menu clicked
            ctr_menu1.btn_menu_1.Click += new EventHandler(btnMenu1_click);
            ctr_menu1.btn_menu_2.Click += new EventHandler(btnMenu2_click);
            ctr_menu1.btn_menu_3.Click += new EventHandler(btnMenu3_click);
            ctr_menu1.btn_menu_4.Click += new EventHandler(btnMenu4_click);
            ctr_menu1.btn_menu_5.Click += new EventHandler(btnMenu5_click);
            ctr_menu1.btn_menu_info.Click += new EventHandler(btnMenuInfo_click);

            // button navbar clicked
            ctr_navbar1.btn_close.Click += new EventHandler(btnClose_click);
            ctr_navbar1.btn_toggle_menu.Click += new EventHandler(btnToggleMenu_click);

            // move form
            ctr_navbar1.MouseMove += new MouseEventHandler(ctr_navbar1_MouseMove);
            ctr_navbar1.MouseDown += new MouseEventHandler(ctr_navbar1_MouseDown);
        }

        //button menu clicked -> show Forms
        void btnMenu1_click(object sender, EventArgs e)
        {
            MessageBox.Show("Đặt vé clicked");
        }

        void btnMenu2_click(object sender, EventArgs e)
        {
            MessageBox.Show("Khách hàng clicked");
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
            MessageBox.Show("Vé bán clicked");
        }

        void btnMenuInfo_click(object sender, EventArgs e)
        {
            MessageBox.Show("button info team clicked");
        }

        //button navbar clicked
        void btnClose_click(object sender, EventArgs e)
        {
            timer_close.Start();
        }

        void btnToggleMenu_click(object sender, EventArgs e)
        {
            if (ctr_menu1.Width <= 85)
            {
                ctr_menu1.Width = 200;
                pnlTop.Width = 200;
            }
            else
            {
                ctr_menu1.Width = 85;
                pnlTop.Width = 85;
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
        void frmTuyenXe_Load(object sender, EventArgs e)
        {
            timer_open.Start();
        }


        private void timer_open_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1)
            {
                this.Opacity += 0.15;
            }
            else
            {
                timer_open.Stop();
            }
        }

        private void time_close_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0.0)
            {
                this.Opacity -= 0.15;
            }
            else
            {
                timer_close.Stop();
                this.Close();
            }
        }


    }
}
