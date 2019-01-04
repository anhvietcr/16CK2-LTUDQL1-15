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

        public frm_Report(int loai)
        {
            InitializeComponent();

            switch (loai)
            {
                case 1:
                    RPChuyen rpt1 = new RPChuyen();
                    crvQLCX.ReportSource = rpt1;
                    break;
                case 2:
                    RPTuyen rpt2 = new RPTuyen();
                    crvQLCX.ReportSource = rpt2;
                    break;
                case 3:
                    RPVeNgay rpt3 = new RPVeNgay();
                    crvQLCX.ReportSource = rpt3;
                    break;

                case 4:
                    RPVeXe rpt4 = new RPVeXe();
                    crvQLCX.ReportSource = rpt4;
                    break;

                default:
                    RPVeXe rpt = new RPVeXe();
                    crvQLCX.ReportSource = rpt;
                    break;
            }

        }
    }
}
