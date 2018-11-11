using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserController;


namespace UserController
{
    public partial class ctr_navbar : UserControl
    {
        public ctr_navbar()
        {
            InitializeComponent();

            //button close
            btn_close.MouseHover += new EventHandler(btnClose_hover);
            btn_close.MouseLeave += new EventHandler(btnClose_leave);
        }
        
        void btnClose_hover(object sender, EventArgs e)
        {
            btn_close.ImageIndex = 1;
        }

        void btnClose_leave(object sender, EventArgs e)
        {
            btn_close.ImageIndex = 0;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            ControlPaint.DrawBorder(e.Graphics, this.ClientRectangle, Color.White,
            ButtonBorderStyle.Solid);
        }
    }
}
