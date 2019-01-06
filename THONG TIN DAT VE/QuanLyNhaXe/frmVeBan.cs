using System;
using System.Drawing;
using System.Windows.Forms;
using BUS;
using System.Data;
using System.Security.Principal;
using System.Threading;

namespace QuanLyNhaXe
{
    public partial class frmVeBan : Form
    {
        public frmDashboard frmDB;
        public GenericPrincipal principal = Thread.CurrentPrincipal as GenericPrincipal;

        public frmVeBan(frmDashboard frm)
        {
            InitializeComponent();
            frmDB = frm;

            ctr_navbar_title.txt_title.Text = "Danh Sách Vé Bán";

            //set position title and btn close
            ctr_navbar_title.txt_title.Location = new Point(panel_navbar_title.Width / 2 - 80, panel_navbar_title.Height / 2 - 12);
            ctr_navbar_title.btn_close.Location = new Point(panel_navbar_title.Width - 30, panel_navbar_title.Height / 2 - 12);

            // move form
            ctr_navbar_title.MouseMove += new MouseEventHandler(ctr_navbar1_MouseMove);
            ctr_navbar_title.MouseDown += new MouseEventHandler(ctr_navbar1_MouseDown);

            // button navbar clicked
            ctr_navbar_title.btn_close.Click += new EventHandler(btnClose_click);

            //load GridView vé bán
            loadGridViewVeBan();

        }

        //move form with border less
        public Point mouseLocation;
        void ctr_navbar1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(-mouseLocation.X, -mouseLocation.Y);
                Location = mousePos;
                Console.WriteLine(Location.X + ", " + Location.Y);
            }
        }

        void ctr_navbar1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(e.X, e.Y);
        }

        //button navbar clicked
        void btnClose_click(object sender, EventArgs e)
        {
            timer_close.Start();
        }

        // effect load form
        void frmBanVe_Load(object sender, EventArgs e)
        {
            timer_open.Start();
        }

        private void timer_open_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1)
            {
                this.Opacity += 0.45;
            }
            else
            {
                timer_open.Stop();
            }
        }

        private void time_close_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0.0)
            {
                this.Opacity -= 0.45;
            }
            else
            {
                timer_close.Stop();

                //close this form and show dashboard form
                frmDB.Show();
                this.Close();
            }
        }
        
        private void loadGridViewVeBan()
        {
            BUS_DatVe bus_datve = new BUS_DatVe();
            DataTable dt = bus_datve.listVe();

            for (int i = 0; i < dgvVe.ColumnCount; ++i)
            {
                dgvVe.Columns[i].DataPropertyName = dgvVe.Columns[i].Name;
            }

            dgvVe.DataSource = dt;
        }

        private void dgvVe_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                dgvVe.CurrentCell = dgvVe.Rows[e.RowIndex].Cells[e.ColumnIndex];
                e.ContextMenuStrip = menu_danhSachVe;
            }
        }

        private void menu_danhSachVe_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

            int iRow = dgvVe.CurrentCell.RowIndex;
            int idVe = Convert.ToInt32(dgvVe.Rows[iRow].Cells[0].Value);
            BUS_DatVe bus_ve = new BUS_DatVe();

            switch (e.ClickedItem.Text)
            {
                case "Xóa":
                    if (principal.IsInRole("client  "))
                    {
                        MessageBox.Show("Bạn không có quyền thực hiện chức năng này");
                        break;
                    }

                    if (bus_ve.deleteVe(idVe))
                    {
                        MessageBox.Show("Xóa vé thành công");
                    } else
                    {
                        MessageBox.Show("Thất bại, có lỗi xảy ra");
                    }
                    break;
                case "Cập nhật tình trạng Vé":
                    int tinhTrang = Convert.ToInt32(dgvVe.Rows[iRow].Cells[3].Value);
                    tinhTrang = tinhTrang == 1 ? 0 : 1;

                    if (bus_ve.updateTinhtrangVe(idVe, tinhTrang))
                    {
                        MessageBox.Show("Cập nhật tình trạng thành công");
                    }
                    else
                    {
                        MessageBox.Show("Thất bại, có lỗi xảy ra");
                    }
                    break;
                default:
                    break;
            }

            //re-load gridview
            loadGridViewVeBan();
        }
    }
}
