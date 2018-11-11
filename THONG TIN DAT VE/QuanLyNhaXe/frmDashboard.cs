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
                        frmVeBan frm = new frmVeBan(this);
                        frm.Show();
                        this.Hide();
                    }break;
                case 3:
                    {
                        //frmVeBan frm = new frmVeBan(this);
                        //frm.Show();
                        //this.Hide();
                    }
                    break;
                case 4:
                    {
                        //frmVeBan frm = new frmVeBan(this);
                        //frm.Show();
                        //this.Hide();
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
    }
}
