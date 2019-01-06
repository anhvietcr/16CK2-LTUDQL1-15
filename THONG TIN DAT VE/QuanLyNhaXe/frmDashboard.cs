using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaXe
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
            settingControlerNavbarTitle();

            GenericPrincipal principal = Thread.CurrentPrincipal as GenericPrincipal;
            MessageBox.Show("Chào mừng đến với " + principal.Identity.Name + ".");
            string role = "";
            if (principal.IsInRole("client  "))
            {
                MessageBox.Show("Bạn là nhân vên");
                //tbnxoa.Enabled = false;
                //btnxoa.Enabled = false;
                //btnxoa.e
            }
        }

        private void settingControlerNavbarTitle()
        {
            //set position title and btn close
            ctr_navbar_title.txt_title.Location = new Point(panel_navbar_title.Width / 2 - 80, panel_navbar_title.Height / 2 - 12);
            ctr_navbar_title.btn_close.Location = new Point(panel_navbar_title.Width - 30, panel_navbar_title.Height / 2 - 12);

            //event button close clicked;
            ctr_navbar_title.btn_close.Click += new EventHandler(btn_close_clicked);

            // move form
            ctr_navbar_title.MouseMove += new MouseEventHandler(ctr_navbar_title_MouseMove);
            ctr_navbar_title.MouseDown += new MouseEventHandler(ctr_navbar_title_MouseDown);
        }

        // event button close clicked
        private void btn_close_clicked(object sender, EventArgs e)
        {
            timer_close.Start();
        }

        //move form with border less
        public Point mouseLocation;
        void ctr_navbar_title_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(-mouseLocation.X, -mouseLocation.Y);
                Location = mousePos;
                Console.WriteLine(Location.X + ", " + Location.Y);
            }
        }

        void ctr_navbar_title_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(e.X, e.Y);
        }

        // effect load form
        void frmDashboard_Load(object sender, EventArgs e)
        {
            timer_open.Start();
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
                this.Close();
            }
        }

        //Open another form with ID
        public void openFormById(int id)
        {
            switch (id)
            {
                case 1:
                    {
                        frmDatVe frm = new frmDatVe(this);
                        frm.Show();
                        this.Hide();
                    }break;
                case 2:
                    {
                        frmKhachhang frm = new frmKhachhang(this);
                        frm.Show();
                        this.Hide();
                    }break;
                case 3:
                    {
                        frmChuyenXe frm = new frmChuyenXe(this);
                        frm.Show();
                        this.Hide();
                    }
                    break;
                case 4:
                    {
                        //frmVeBan frm = new frmVeBan(this);
                        //frm.Show();
                        //this.Hide();
                    }
                    break;
                case 5:
                    {
                        btn_slider_Click(this, new EventArgs { });
                    }
                    break;
                default:
                    {

                    }break;
            }
        }

        private void btn_menu_1_Click(object sender, EventArgs e)
        {
            openFormById(1);
        }

        private void btn_menu_2_Click(object sender, EventArgs e)
        {
            openFormById(2);
        }

        private void btn_menu_3_Click(object sender, EventArgs e)
        {
            openFormById(3);
        }

        private void btn_menu_4_Click(object sender, EventArgs e)
        {
            openFormById(4);
        }

        //effect button slider clicked 
        private void btn_slider_Click(object sender, EventArgs e)
        {
            if (panel_menu.Width < 406)
            {
                groupBox_infoteam.Visible = false;
                panel_menu.Width = 406;
                btn_slider.Location = new Point(390, 62);
                btn_slider.ImageIndex = 8;
            }
            else
            {
                groupBox_infoteam.Visible = true;
                panel_menu.Width = 206;
                btn_slider.Location = new Point(200, 62);
                btn_slider.ImageIndex = 9;
            }
        }

        //effect Hover and Move on buttons menu 
        private void btn_menu_1_MouseHover(object sender, EventArgs e)
        {
            btn_menu_1.ImageIndex = 1;
        }

        private void btn_menu_1_MouseLeave(object sender, EventArgs e)
        {
            btn_menu_1.ImageIndex = 0;
        }

        private void btn_menu_2_MouseHover(object sender, EventArgs e)
        {
            btn_menu_2.ImageIndex = 3;
        }

        private void btn_menu_2_MouseLeave(object sender, EventArgs e)
        {
            btn_menu_2.ImageIndex = 2;
        }

        private void btn_menu_3_MouseHover(object sender, EventArgs e)
        {
            btn_menu_3.ImageIndex = 5;
        }

        private void btn_menu_3_MouseLeave(object sender, EventArgs e)
        {
            btn_menu_3.ImageIndex = 4;
        }

        private void btn_menu_4_MouseHover(object sender, EventArgs e)
        {
            btn_menu_4.ImageIndex = 7;
        }

        private void btn_menu_4_MouseLeave(object sender, EventArgs e)
        {
            btn_menu_4.ImageIndex = 6;
        }

        private void cbx_report_SelectedIndexChanged(object sender, EventArgs e)
        {
            // get index of item changed
            int index = (sender as ComboBox).SelectedIndex;

            // open form report correct
            frm_Report frm = new frm_Report(index+1);
            frm.Show();
        }
    }
}
