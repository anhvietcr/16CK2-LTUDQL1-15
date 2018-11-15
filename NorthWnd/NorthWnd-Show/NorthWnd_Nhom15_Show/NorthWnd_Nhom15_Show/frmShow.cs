using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace NorthWnd_Nhom15_Show
{
    public partial class frmShow : Form
    {
        public frmShow()
        {
            InitializeComponent();
            // load data into DataGridView
            LoadDataGridView();
        }

        // load data into DataGridView
        public void LoadDataGridView()
        {
            BLLShow control = new BLLShow();
            DataTable dt = new DataTable();

            dt = control.getDataTable();
            dgvShow.DataSource = dt;
        }

    }
}
