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
    public partial class frmShow : Form
    {
        public delegate void pointer(List<string> data);
        public event pointer sendDataSelected;

        public frmShow()
        {
            InitializeComponent();

            // add context menu to data grid view
            gridView.MouseClick += new MouseEventHandler(gridView_MouseClick);

            // load data into DataGridView
            LoadDataGridView();
        }

        // load data into DataGridView
        public void LoadDataGridView()
        {
            BLLShow control = new BLLShow();
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
                menu.MenuItems.Add(new MenuItem("Edit Row", edit_item_clicked));
                menu.MenuItems.Add(new MenuItem("Delete Row", delete_item_clicked));

                // show to datagridview
                menu.Show(gridView, new Point(e.X, e.Y));
            }
        }

        /// <summary>
        /// EDIT
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void edit_item_clicked(object sender, EventArgs e)
        {
            // current position in [][]
            int rowindex = gridView.CurrentCell.RowIndex;
            int columnindex = gridView.CurrentCell.ColumnIndex;

            List<string> data = new List<string>();
            for (int i = 0; i < gridView.ColumnCount; i++)
            {
                string val = null;
                if (gridView.Rows[rowindex].Cells[i].Value != null)
                {
                    val = gridView.Rows[rowindex].Cells[i].Value.ToString();
                }
                data.Add(val);
            }

            // using delegate send data to another form
            frmEditDetail frm = new frmEditDetail(this);
            sendDataSelected += new pointer(frm.getDataSender);
            sendDataSelected(data);

            frm.ShowDialog();
        }

        /// <summary>
        /// ADD
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Add_item_clicked(object sender, EventArgs e)
        {
            frmAddDetail frm = new frmAddDetail(this);
            frm.ShowDialog();
        }

        /// <summary>
        /// DELETE
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void delete_item_clicked(object sender, EventArgs e)
        {
            // current position in [][]
            int rowindex = gridView.CurrentCell.RowIndex;
            int columnindex = gridView.CurrentCell.ColumnIndex;

            List<string> data = new List<string>();
            for (int i = 0; i < gridView.ColumnCount; i++)
            {
                string val = null;
                if (gridView.Rows[rowindex].Cells[i].Value != null)
                {
                    val = gridView.Rows[rowindex].Cells[i].Value.ToString();
                }
                data.Add(val);
            }

            // using delegate send data to another form
            frmDeleteDetail frm = new frmDeleteDetail(this);
            sendDataSelected += new pointer(frm.getDataSender);
            sendDataSelected(data);

            frm.ShowDialog();
        }
    }
}
