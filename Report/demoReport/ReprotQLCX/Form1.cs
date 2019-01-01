using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReprotQLCX
{
    public partial class fm_Reprot : Form
    {
        public fm_Reprot()
        {
            InitializeComponent();
        }
        private int l;
        public fm_Reprot(int loai)
        {
            InitializeComponent();
            l = loai;
           
        }

        private void fm_Reprot_Load(object sender, EventArgs e)
        {
            l = 1;
            RPVeNgay rpt = new RPVeNgay();
            crvQLCX.ReportSource = rpt;
            //if (l == 1)
            //{
            //    RPChuyen rpt = new RPChuyen();
            //    crvQLCX.ReportSource = rpt;
            //}
            //if (l == 2)
            //{
            //    RPTuyen rpt = new RPTuyen();
            //    crvQLCX.ReportSource = rpt;
            //}
            //if (l == 3)
            //{
            //    RPVeXe rpt = new RPVeXe();
            //    crvQLCX.ReportSource = rpt;
            //}
        }
    }
}
