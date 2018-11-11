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
    public partial class frmVeBan : Form
    {
        public frmDashboard frmDB;
        public frmVeBan(frmDashboard frm)
        {
            InitializeComponent();
            frmDB = frm;

            //set position title and btn close
            ctr_navbar_title.txt_title.Location = new Point(panel_navbar_title.Width / 2 - 80, panel_navbar_title.Height / 2 - 12);
            ctr_navbar_title.btn_close.Location = new Point(panel_navbar_title.Width - 30, panel_navbar_title.Height / 2 - 12);

            // move form
            ctr_navbar_title.MouseMove += new MouseEventHandler(ctr_navbar1_MouseMove);
            ctr_navbar_title.MouseDown += new MouseEventHandler(ctr_navbar1_MouseDown);

            // button navbar clicked
            ctr_navbar_title.btn_close.Click += new EventHandler(btnClose_click);

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

        //button navbar clicked
        void btnClose_click(object sender, EventArgs e)
        {
            timer_close.Start();
        }

        // effect load form
        void frmBanVe_Load(object sender, EventArgs e)
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

        private void time_close_Tick(object sender, EventArgs e)
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

        //open form
        private void btn_menu_1_Click(object sender, EventArgs e)
        {
            frmDB.openFormById(1);
            this.Close();
        }
    }
}
