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
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
        }

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
                        frmVeBan frm = new frmVeBan(this);
                        frm.Show();
                        this.Hide();
                    }break;
                default:
                    {

                    }break;
            }
        }

        private void btn_menu_1_Click(object sender, EventArgs e)
        {
            openFormById(1);
        }

        private void btn_slider_Click(object sender, EventArgs e)
        {
            if (panel_menu.Width < 406)
            {
                panel_menu.Width = 406;
                btn_slider.Location = new Point(390, 62);
                btn_slider.Text = "<--";
            }
            else
            {
                panel_menu.Width = 206;
                btn_slider.Location = new Point(200, 62);
                btn_slider.Text = "-->";
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
