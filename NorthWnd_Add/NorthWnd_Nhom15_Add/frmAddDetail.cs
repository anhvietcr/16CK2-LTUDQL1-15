using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NorthWnd_Nhom15
{
    public partial class frmAddDetail : Form
    {
        public delegate void pointer();
        public event pointer closeEvent;

        private frmEdit frmParent;
        public frmAddDetail(frmEdit frmSender)
        {
            frmParent = frmSender;
            InitializeComponent();
        }

        // submit data add to parent form
        private void btnAddSubmit_Click(object sender, EventArgs e)
        {
            BLLAdd control = new BLLAdd();
            List<string> data = new List<string>();
            data.Add(txtCompanyName.Text);
            data.Add(txtContactName.Text);
            data.Add(txtContactTitle.Text);
            data.Add(txtAddress.Text);
            data.Add(txtCity.Text);
            data.Add(txtRegion.Text);
            data.Add(txtRegion.Text);
            data.Add(txtCountry.Text);
            data.Add(txtPhone.Text);
            data.Add(txtFax.Text);
            data.Add(txtHomePage.Text);
            if(data[0] == "")
            {
                MessageBox.Show("CompanyName not Null");
            }
            else if (control.Add(data) == 1 )
            {
                MessageBox.Show("Thêm thành công !");
                this.Close();
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
        }

        private void frmAddDetail_FormClosing(object sender, FormClosingEventArgs e)
        {
            closeEvent += new pointer(frmParent.LoadDataGridView);
            closeEvent();
        }

      
    }
}
