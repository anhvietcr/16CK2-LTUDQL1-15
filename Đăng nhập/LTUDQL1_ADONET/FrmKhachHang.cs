using System;
using LTUDQL1_XULY;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Principal;
using System.Threading;

namespace LTUDQL1_ADONET
{
    public partial class FrmKhachHang : Form
    {
        public FrmKhachHang()
        {
            InitializeComponent();
            GenericPrincipal principal = Thread.CurrentPrincipal as GenericPrincipal;
            MessageBox.Show("Chàdejydo mừng khách hàng " + principal.Identity.Name + ".");
            string role = "";
            //foreach (var row in r)
            //{
            //    role += row.rolename + "  ";
            //}
            //MessageBox.Show("xin chào " + role);
            if (principal.IsInRole("client  "))
            {
                //tbnxoa.Enabled = false;
                btnxoa.Enabled = false;
                //btnxoa.e
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //BUS_KhachHang bUS_KhachHang = new BUS_KhachHang();
            //DataTable dt = bUS_KhachHang.LayDSKhachHang();

            //dataGridView1.DataSource = dt;
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            BUS_KhachHang bUS_KhachHang = new BUS_KhachHang();
            bUS_KhachHang.CapNhatDSKhachHang((DataTable)dataGridView1.DataSource);

        }

        private void refreshData()
        {
            BUS_KhachHang bUS_KhachHang = new BUS_KhachHang();
            DataTable dt = bUS_KhachHang.LayDSKhachHang();

            dataGridView1.DataSource = dt;
        }

        private void tbnthem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("bạn đã click thêm");
        }

        private void tbnxoa_Click(object sender, EventArgs e)
        {
            MessageBox.Show("bạn đã click xóa");

        }

        private void tbnsua_Click(object sender, EventArgs e)
        {
            MessageBox.Show("bạn đã click sửa");
        }

    }
}
