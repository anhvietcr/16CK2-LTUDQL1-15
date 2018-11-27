using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiaoDienChuyenXe
{
    public partial class fnChuyenXe : Form
    {
        public fnChuyenXe()
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
        void fnChuyenXe_Load(object sender, EventArgs e)
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

        private void btnSearchChuyenXe_MouseHover(object sender, EventArgs e)
        {
            btnSearchChuyenXe.ImageIndex = 6;
            btnSearchChuyenXe.Font = new Font(btnSearchChuyenXe.Font.Name, btnSearchChuyenXe.Font.Size, FontStyle.Bold);
            btnSearchChuyenXe.ForeColor = System.Drawing.ColorTranslator.FromHtml("#0D47A1") ;
        }

        private void btnSearchChuyenXe_MouseLeave(object sender, EventArgs e)
        {
            btnSearchChuyenXe.ImageIndex = 5;
            btnSearchChuyenXe.Font = new Font(btnSearchChuyenXe.Font.Name, btnSearchChuyenXe.Font.Size, FontStyle.Regular);
            btnSearchChuyenXe.ForeColor = System.Drawing.ColorTranslator.FromHtml("#1976D2");
        }

        private void btnThemChuyenXe_MouseHover(object sender, EventArgs e)
        {
            btnThemChuyenXe.ImageIndex = 4;
            btnThemChuyenXe.Font = new Font(btnThemChuyenXe.Font.Name, btnSearchChuyenXe.Font.Size, FontStyle.Bold);
            btnThemChuyenXe.ForeColor = System.Drawing.ColorTranslator.FromHtml("#0D47A1");
        }

        private void btnThemChuyenXe_MouseLeave(object sender, EventArgs e)
        {
            btnThemChuyenXe.ImageIndex = 3;
            btnThemChuyenXe.Font = new Font(btnThemChuyenXe.Font.Name, btnXoaChuyenXe.Font.Size, FontStyle.Regular);
            btnThemChuyenXe.ForeColor = System.Drawing.ColorTranslator.FromHtml("#1976D2");
        }

        private void btnXoaChuyenXe_MouseHover(object sender, EventArgs e)
        {
            btnXoaChuyenXe.ImageIndex = 8;
            btnXoaChuyenXe.Font = new Font(btnXoaChuyenXe.Font.Name, btnXoaChuyenXe.Font.Size, FontStyle.Bold);
           btnXoaChuyenXe.ForeColor = System.Drawing.ColorTranslator.FromHtml("#0D47A1");
        }

        private void btnXoaChuyenXe_MouseLeave(object sender, EventArgs e)
        {
            btnXoaChuyenXe.ImageIndex = 7;
            btnXoaChuyenXe.Font = new Font(btnXoaChuyenXe.Font.Name, btnXoaChuyenXe.Font.Size, FontStyle.Regular);
            btnXoaChuyenXe.ForeColor = System.Drawing.ColorTranslator.FromHtml("#1976D2");
        }

        private void btnUpdateChuyenXe_MouseHover(object sender, EventArgs e)
        {
            btnUpdateChuyenXe.ImageIndex = 2;
            btnUpdateChuyenXe.Font = new Font(btnUpdateChuyenXe.Font.Name,btnUpdateChuyenXe.Font.Size, FontStyle.Bold);
            btnUpdateChuyenXe.ForeColor = System.Drawing.ColorTranslator.FromHtml("#0D47A1");
        }

        private void btnUpdateChuyenXe_MouseLeave(object sender, EventArgs e)
        {
            btnUpdateChuyenXe.ImageIndex = 1;
            btnUpdateChuyenXe.Font = new Font(btnUpdateChuyenXe.Font.Name, btnUpdateChuyenXe.Font.Size, FontStyle.Regular);
            btnUpdateChuyenXe.ForeColor = System.Drawing.ColorTranslator.FromHtml("#1976D2");
        }

        private void btnExecl_MouseHover(object sender, EventArgs e)
        {
            btnExecl.ImageIndex = 9;
            btnExecl.Font = new Font(btnExecl.Font.Name, btnExecl.Font.Size, FontStyle.Bold);
            btnExecl.ForeColor = System.Drawing.ColorTranslator.FromHtml("#0D47A1");
        }

        private void btnExecl_MouseLeave(object sender, EventArgs e)
        {
            btnExecl.ImageIndex = 0;
            btnExecl.Font = new Font(btnExecl.Font.Name, btnExecl.Font.Size, FontStyle.Regular);
            btnExecl.ForeColor = System.Drawing.ColorTranslator.FromHtml("#1976D2");
        }

        private void btnViewXe_MouseHover(object sender, EventArgs e)
        {
            btnViewXe.ImageIndex = 11;
            btnViewXe.Font = new Font(btnViewXe.Font.Name, btnViewXe.Font.Size, FontStyle.Bold);
            btnViewXe.ForeColor = System.Drawing.ColorTranslator.FromHtml("#0D47A1");
        }

        private void btnViewXe_MouseLeave(object sender, EventArgs e)
        {
            btnViewXe.ImageIndex = 10;
            btnViewXe.Font = new Font(btnViewXe.Font.Name, btnViewXe.Font.Size, FontStyle.Regular);
            btnViewXe.ForeColor = System.Drawing.ColorTranslator.FromHtml("#1976D2");
        }

        private void btnViewXe_Click(object sender, EventArgs e)
        {
            frmXe frmX = new frmXe();
            frmX.ShowDialog();
        }

    }
}

