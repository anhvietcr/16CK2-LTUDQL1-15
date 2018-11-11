using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserController
{
    public partial class ctr_menu : UserControl
    {
        public ctr_menu()
        {
            InitializeComponent();

            //button 1
            btn_menu_1.MouseHover += new EventHandler(btnMenu1_MouseHover);
            btn_menu_1.MouseLeave += new EventHandler(btnMenu1_MouseLeave);

            //button 2
            btn_menu_2.MouseHover += new EventHandler(btnMenu2_MouseHover);
            btn_menu_2.MouseLeave += new EventHandler(btnMenu2_MouseLeave);

            //button 3
            btn_menu_3.MouseHover += new EventHandler(btnMenu3_MouseHover);
            btn_menu_3.MouseLeave += new EventHandler(btnMenu3_MouseLeave);

            //button 4
            btn_menu_4.MouseHover += new EventHandler(btnMenu4_MouseHover);
            btn_menu_4.MouseLeave += new EventHandler(btnMenu4_MouseLeave);

            //button 5
            btn_menu_5.MouseHover += new EventHandler(btnMenu5_MouseHover);
            btn_menu_5.MouseLeave += new EventHandler(btnMenu5_MouseLeave);
        }

        //button1
        void btnMenu1_MouseHover(object sender, EventArgs e)
        {
            btn_menu_1.ImageIndex = 1;
        }
        void btnMenu1_MouseLeave(object sender, EventArgs e)
        {
            btn_menu_1.ImageIndex = 0;
        }

        // button2
        void btnMenu2_MouseHover(object sender, EventArgs e)
        {
            btn_menu_2.ImageIndex = 7;
        }
        void btnMenu2_MouseLeave(object sender, EventArgs e)
        {
            btn_menu_2.ImageIndex = 6;
        }

        //button3
        void btnMenu3_MouseHover(object sender, EventArgs e)
        {
            btn_menu_3.ImageIndex = 3;
        }
        void btnMenu3_MouseLeave(object sender, EventArgs e)
        {
            btn_menu_3.ImageIndex = 2;
        }

        //button4
        void btnMenu4_MouseHover(object sender, EventArgs e)
        {
            btn_menu_4.ImageIndex = 5;
        }
        void btnMenu4_MouseLeave(object sender, EventArgs e)
        {
            btn_menu_4.ImageIndex = 4;
        }

        //button4
        void btnMenu5_MouseHover(object sender, EventArgs e)
        {
            btn_menu_5.ImageIndex = 9;
        }
        void btnMenu5_MouseLeave(object sender, EventArgs e)
        {
            btn_menu_5.ImageIndex = 8;
        }

        //border control 
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            ControlPaint.DrawBorder(e.Graphics, this.ClientRectangle, Color.White,
            ButtonBorderStyle.Solid);
        }
    }
}
