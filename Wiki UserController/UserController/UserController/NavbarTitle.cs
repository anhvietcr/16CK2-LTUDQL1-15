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
    public partial class ctr_navbar_title : UserControl
    {
        public ctr_navbar_title()
        {
            InitializeComponent();

            //set Location title
            txt_title.Location = new Point(this.Width / 2, this.Height / 2);
        }

        //effect Hover and Move buttons close 
        private void btn_close_MouseHover(object sender, EventArgs e)
        {
            btn_close.ImageIndex = 1;
        }

        private void btn_close_MouseLeave(object sender, EventArgs e)
        {
            btn_close.ImageIndex = 0;
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
