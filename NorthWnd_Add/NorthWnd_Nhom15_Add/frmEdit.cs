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

namespace NorthWnd_Nhom15
{
    public partial class frmEdit : Form
    {
        public delegate void pointer(List<string> data);
        public event pointer sendDataSelected;

        public frmEdit()
        {
            InitializeComponent();

            // add context menu to data grid view
            gridView.MouseClick += new MouseEventHandler(gridView_MouseClick);

            // load data into grid view
            LoadDataGridView();
        }

        // load data into grid view
        public void LoadDataGridView()
        {
            BLLAdd control = new BLLAdd();
            DataTable dt = new DataTable();

            dt = control.getDataTable();
            gridView.DataSource = dt;
        }

        private void gridView_MouseClick(object sender, MouseEventArgs e)
        {
            // get row position mouse click in gridview
            int position = gridView.HitTest(e.X, e.Y).RowIndex;

            if (position >= 0)
            {
                // add context menu call function
                ContextMenu menu = new ContextMenu();
               
                menu.MenuItems.Add(new MenuItem("Add Row", Add_item_clicked));
                // show to datagridview
                menu.Show(gridView, new Point(e.X, e.Y));
            }
        }

       
        private void Add_item_clicked(object sender, EventArgs e)
        {
            frmAddDetail frm = new frmAddDetail(this);
            frm.ShowDialog();
        }
    }
}
