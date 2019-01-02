using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Report
{
    public partial class ReportCX : Form
    {
        public ReportCX()
        {
            InitializeComponent();
        }
        private int l;
        public ReportCX(int loai)
        {
            InitializeComponent();
            l = loai;
            l = 1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if(l==1)
            {
                RPChuyen rpt = new RPChuyen();
                crvQLCX.ReportSource = rpt;
            }
            if (l == 2)
            {
               RPTuyen rpt = new RPTuyen();
                crvQLCX.ReportSource = rpt;
            }
            if (l == 3)
            {
                RPVeXe rpt = new RPVeXe();
                crvQLCX.ReportSource = rpt;
            }
        }
    }
}
