using ReprotQLCX;
using System;
using System.Windows.Forms;

namespace QuanLyNhaXe
{
    public partial class frm_Report : Form
    {
        public frm_Report()
        {
            InitializeComponent();
        }
        private int l;
        public frm_Report(int loai)
        {
            InitializeComponent();
            l = loai;
           
        }

        private void frm_Report_Load(object sender, EventArgs e)
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
