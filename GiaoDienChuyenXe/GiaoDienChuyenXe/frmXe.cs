using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace GiaoDienChuyenXe
{
    public partial class frmXe : Form
    {
        BUS_Xe busx;
        DTO_Xe dtox;
        public frmXe()
        {
            InitializeComponent();
        }

        private void frmXe_Load(object sender, EventArgs e)
        {
            busx = new BUS_Xe();
            DataTable dt = new DataTable();

            dt = busx.ListXe();
            dgvXe.DataSource = dt;
        }
    }

}
