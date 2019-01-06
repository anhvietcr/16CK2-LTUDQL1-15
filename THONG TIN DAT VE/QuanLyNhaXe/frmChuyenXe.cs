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

namespace QuanLyNhaXe
{
    public partial class frmChuyenXe : Form
    {
        public frmDashboard frmDB;
        BUS_Chuyen c;
        DTO_Chuyen dto_c = new DTO_Chuyen();
        public frmChuyenXe(frmDashboard frm)
        {
            InitializeComponent();
            //
            frmDB = frm;
            //
            ctr_menu.btn_menu_3.Enabled = false;
            // button menu clicked
            ctr_menu.btn_menu_2.Click += new EventHandler(btnMenu2_click);
            ctr_menu.btn_menu_1.Click += new EventHandler(btnMenu1_click);
            ctr_menu.btn_menu_4.Click += new EventHandler(btnMenu4_click);
            ctr_menu.btn_menu_5.Click += new EventHandler(btnMenu5_click);
            ctr_menu.btn_menu_info.Click += new EventHandler(btnMenuInfo_click);

            // button navbar clicked
            ctr_navbar.btn_close.Click += new EventHandler(btnClose_click);
            ctr_navbar.btn_toggle_menu.Click += new EventHandler(btnToggleMenu_click);

            // move form
            ctr_navbar.MouseMove += new MouseEventHandler(ctr_navbar1_MouseMove);
            ctr_navbar.MouseDown += new MouseEventHandler(ctr_navbar1_MouseDown);
        }

        //button menu clicked -> show Forms
        void btnMenu2_click(object sender, EventArgs e)
        {
            frmDB.openFormById(2);
            this.Close();
        }

        void btnMenu1_click(object sender, EventArgs e)
        {
            frmDB.openFormById(1);
            this.Close();
        }

        void btnMenu4_click(object sender, EventArgs e)
        {
            MessageBox.Show("Tuyến xe clicked");
        }

        void btnMenu5_click(object sender, EventArgs e)
        {
            timer_close.Start();
        }

        void btnMenuInfo_click(object sender, EventArgs e)
        {
            frmDB.Show();
            frmDB.openFormById(5);
            this.Close();
        }

        //button navbar clicked
        void btnClose_click(object sender, EventArgs e)
        {
            timer_close.Start();
        }

        void btnToggleMenu_click(object sender, EventArgs e)
        {
            if (ctr_menu.Width <= 85)
            {
                ctr_menu.Width = 200;
                panel2.Width = 200;
                ctr_navbar.btn_toggle_menu.ImageIndex = 0;
            }
            else
            {
                ctr_menu.Width = 85;
                panel2.Width = 85;
                ctr_navbar.btn_toggle_menu.ImageIndex = 2;
            }
        }

        //move form with border less
        public Point mouseLocation;
        void ctr_navbar1_MouseMove(object sender, MouseEventArgs e)
        {

        }

        void ctr_navbar1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(e.X, e.Y);
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

        private void timer_close_Tick(object sender, EventArgs e)
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

        // effect load form
        void fnChuyenXe_Load(object sender, EventArgs e)
        {
            timer_open.Start();            
            loadcbbChuyen();
            loadcbbLoai();
            loadcbbTuyen();
            LoaddgvChuyen();
        }
        private void btnSearchChuyenXe_MouseHover(object sender, EventArgs e)
        {
            btnSearchChuyenXe.ImageIndex = 6;
            btnSearchChuyenXe.Font = new Font(btnSearchChuyenXe.Font.Name, btnSearchChuyenXe.Font.Size, FontStyle.Bold);
            btnSearchChuyenXe.ForeColor = System.Drawing.ColorTranslator.FromHtml("#0D47A1") ;
        }

        private void btnSearchChuyenXe_MouseLeave(object sender, EventArgs e)
        {
            btnSearchChuyenXe.ImageIndex = 5;
            btnSearchChuyenXe.Font = new Font(btnSearchChuyenXe.Font.Name, btnSearchChuyenXe.Font.Size, FontStyle.Regular);
            btnSearchChuyenXe.ForeColor = System.Drawing.ColorTranslator.FromHtml("#1976D2");
        }

        private void btnThemChuyenXe_MouseHover(object sender, EventArgs e)
        {
            btnThemChuyenXe.ImageIndex = 4;
            btnThemChuyenXe.Font = new Font(btnThemChuyenXe.Font.Name, btnSearchChuyenXe.Font.Size, FontStyle.Bold);
            btnThemChuyenXe.ForeColor = System.Drawing.ColorTranslator.FromHtml("#0D47A1");
        }

        private void btnThemChuyenXe_MouseLeave(object sender, EventArgs e)
        {
            btnThemChuyenXe.ImageIndex = 3;
            btnThemChuyenXe.Font = new Font(btnThemChuyenXe.Font.Name, btnXoaChuyenXe.Font.Size, FontStyle.Regular);
            btnThemChuyenXe.ForeColor = System.Drawing.ColorTranslator.FromHtml("#1976D2");
        }

        private void btnXoaChuyenXe_MouseHover(object sender, EventArgs e)
        {
            btnXoaChuyenXe.ImageIndex = 8;
            btnXoaChuyenXe.Font = new Font(btnXoaChuyenXe.Font.Name, btnXoaChuyenXe.Font.Size, FontStyle.Bold);
           btnXoaChuyenXe.ForeColor = System.Drawing.ColorTranslator.FromHtml("#0D47A1");
        }

        private void btnXoaChuyenXe_MouseLeave(object sender, EventArgs e)
        {
            btnXoaChuyenXe.ImageIndex = 7;
            btnXoaChuyenXe.Font = new Font(btnXoaChuyenXe.Font.Name, btnXoaChuyenXe.Font.Size, FontStyle.Regular);
            btnXoaChuyenXe.ForeColor = System.Drawing.ColorTranslator.FromHtml("#1976D2");
        }

        private void btnUpdateChuyenXe_MouseHover(object sender, EventArgs e)
        {
            btnUpdateChuyenXe.ImageIndex = 2;
            btnUpdateChuyenXe.Font = new Font(btnUpdateChuyenXe.Font.Name,btnUpdateChuyenXe.Font.Size, FontStyle.Bold);
            btnUpdateChuyenXe.ForeColor = System.Drawing.ColorTranslator.FromHtml("#0D47A1");
        }

        private void btnUpdateChuyenXe_MouseLeave(object sender, EventArgs e)
        {
            btnUpdateChuyenXe.ImageIndex = 1;
            btnUpdateChuyenXe.Font = new Font(btnUpdateChuyenXe.Font.Name, btnUpdateChuyenXe.Font.Size, FontStyle.Regular);
            btnUpdateChuyenXe.ForeColor = System.Drawing.ColorTranslator.FromHtml("#1976D2");
        }

        private void btnExecl_MouseHover(object sender, EventArgs e)
        {
            btnExecl.ImageIndex = 9;
            btnExecl.Font = new Font(btnExecl.Font.Name, btnExecl.Font.Size, FontStyle.Bold);
            btnExecl.ForeColor = System.Drawing.ColorTranslator.FromHtml("#0D47A1");
        }

        private void btnExecl_MouseLeave(object sender, EventArgs e)
        {
            btnExecl.ImageIndex = 0;
            btnExecl.Font = new Font(btnExecl.Font.Name, btnExecl.Font.Size, FontStyle.Regular);
            btnExecl.ForeColor = System.Drawing.ColorTranslator.FromHtml("#1976D2");
        }

        private void btnViewXe_MouseHover(object sender, EventArgs e)
        {
            btnViewXe.ImageIndex = 11;
            btnViewXe.Font = new Font(btnViewXe.Font.Name, btnViewXe.Font.Size, FontStyle.Bold);
            btnViewXe.ForeColor = System.Drawing.ColorTranslator.FromHtml("#0D47A1");
        }

        private void btnViewXe_MouseLeave(object sender, EventArgs e)
        {
            btnViewXe.ImageIndex = 10;
            btnViewXe.Font = new Font(btnViewXe.Font.Name, btnViewXe.Font.Size, FontStyle.Regular);
            btnViewXe.ForeColor = System.Drawing.ColorTranslator.FromHtml("#1976D2");
        }

        private void btnViewXe_Click(object sender, EventArgs e)
        {
            frmXe frmX = new frmXe();
            frmX.ShowDialog();
        }

        //Xử lý dgvChuyen
        void LoaddgvChuyen()
        {
            c = new BUS_Chuyen();
            DataTable dt = new DataTable();

            dt = c.ListChuyen();
            dgvChuyenXe.DataSource = dt;
        }
        void loadcbbChuyen()
        {
            c = new BUS_Chuyen();
            DataTable dt = new DataTable();

            dt = c.ListcbbChuyen();
            cbbChuyenXe.Items.Add("All");
            foreach(DataRow r in dt.Rows)
            {
                cbbChuyenXe.Items.Add(r["ID_Chuyen"]);
            }
            cbbChuyenXe.SelectedIndex = 0;
        }
        void loadcbbLoai()
        {
            c = new BUS_Chuyen();
            DataTable dt = new DataTable();

            dt = c.ListcbbLoai();
            foreach (DataRow r in dt.Rows)
            {
                cbbLoaiXe.Items.Add(r["TenLoai"]);
            }
            cbbLoaiXe.SelectedIndex = 0;
        }
        void loadcbbTuyen()
        {
            c = new BUS_Chuyen();
            DataTable dt = new DataTable();

            dt = c.ListcbbTuyen();
            cbbTuyenXe.Items.Add("All");
            foreach (DataRow r in dt.Rows)
            {
               cbbTuyenXe.Items.Add(r["ID_Tuyen"]);
            }
            cbbTuyenXe.SelectedIndex = 0;
        }
        void XulyTimKiemTCL()
        {
            c = new BUS_Chuyen();
            DataTable dt = new DataTable();

            dto_c = new DTO_Chuyen();
            int Tuyen = -1;
            dto_c.ID_Chuyen = -1;
            if (cbbTuyenXe.SelectedIndex != 0)
            {
                if (Int32.TryParse(cbbTuyenXe.Text.ToString(), out int x))
                {
                    Tuyen = x;
                }
            }
            if (cbbChuyenXe.SelectedIndex != 0)
            {
                if (Int32.TryParse(cbbChuyenXe.Text.ToString(), out int x))
                {
                    dto_c.ID_Chuyen = x;
                }
            }
            string Loai = cbbLoaiXe.Text.ToString();
            if(cbbChuyenXe.Text.ToString()=="All" && cbbLoaiXe.Text.ToString()=="All" && cbbTuyenXe.Text.ToString()=="All")
            {
                LoaddgvChuyen();
            }

            dt = c.ListChuyenDK(Tuyen, dto_c.ID_Chuyen, Loai);
            dgvChuyenXe.DataSource = dt;
        }
        private void cbbChuyenXe_SelectedIndexChanged(object sender, EventArgs e)
        {
            XulyTimKiemTCL();

            if(cbbChuyenXe.SelectedIndex!=0)
            {
                cbbLoaiXe.Enabled = false;
                cbbTuyenXe.Enabled = false;
                cbbTuyenXe.SelectedIndex = 0;
                cbbLoaiXe.SelectedIndex = 0;
            }
            else
            {
                cbbLoaiXe.Enabled = true;
                cbbTuyenXe.Enabled = true;
            }

        }
        private void cbbTuyenXe_SelectedIndexChanged(object sender, EventArgs e)
        {
            XulyTimKiemTCL();
        }
        private void cbbLoaiXe_SelectedIndexChanged(object sender, EventArgs e)
        {
            XulyTimKiemTCL();
        }
        private void btnSearchChuyenXe_Click(object sender, EventArgs e)
        {
            c = new BUS_Chuyen();
            DataTable dt = new DataTable();

            string tu,den;
            tu = "%"+tbTu.Text.ToString()+"%";
            den = "%" + tbDen.Text.ToString() + "%";
            dt = c.ListChuyenSearch(tu, den);
            dgvChuyenXe.DataSource = dt;
        }
        private void dgvChuyenXe_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int iRow = dgvChuyenXe.CurrentCell.RowIndex;
            if (Int32.TryParse(dgvChuyenXe.Rows[iRow].Cells[0].Value.ToString(), out int x))
            {
                dto_c.ID_Chuyen = x;
            }

            if (Int32.TryParse(dgvChuyenXe.Rows[iRow].Cells["Tuyen_ID_Tuyen"].Value.ToString(), out int y))
            {
                dto_c.Tuyen_ID_Tuyen = y;
            }

            if (DateTime.TryParse(dgvChuyenXe.Rows[iRow].Cells["Gio_khoi_hanh"].Value.ToString(), out DateTime z))
            {
                dto_c.Gio_khoi_hanh = z;
            }

            dto_c.Ghi_chu = dgvChuyenXe.Rows[iRow].Cells["Ghi_chu"].Value.ToString();
            if (Int32.TryParse(dgvChuyenXe.Rows[iRow].Cells["Xe_XeID"].Value.ToString(), out int c))
            {
                dto_c.Xe_XeID = c;
            }

            if (Int32.TryParse(dgvChuyenXe.Rows[iRow].Cells["Tai_xe_ID_TaiXe"].Value.ToString(), out int d))
            {
                dto_c.Tai_xe_ID_TaiXe = d;
            }
        }
        private void btnXoaChuyenXe_Click(object sender, EventArgs e)
        {
            c = new BUS_Chuyen();
            DialogResult dlr = MessageBox.Show("Are you sure you want to DLETE ?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dlr == DialogResult.Yes)
            {
                c.DeleteChuyen(dto_c.ID_Chuyen);

            }
            LoaddgvChuyen();

        }
        private void btnUpdateChuyenXe_Click(object sender, EventArgs e)
        {
            frmIUChuyen frm = new frmIUChuyen(dto_c,1);
            frm.ShowDialog();
            LoaddgvChuyen();
        }

        private void btnThemChuyenXe_Click(object sender, EventArgs e)
        {
            frmIUChuyen frm = new frmIUChuyen(dto_c, 2);
            frm.ShowDialog();
            LoaddgvChuyen();
        }

        private void btnExecl_Click(object sender, EventArgs e)
        {
            c.execl((DataTable)dgvChuyenXe.DataSource);
        }
    }
}

