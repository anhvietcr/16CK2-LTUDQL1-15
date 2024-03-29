﻿using System;
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
    public partial class frmDeleteDetail : Form
    {
        public delegate void pointer();
        public event pointer closeEvent;

        private frmSuppliers frmParent;
        public frmDeleteDetail(frmSuppliers frmSender)
        {
            frmParent = frmSender;
            InitializeComponent();
        }

        public void getDataSender(List<string> data)
        {
            txtID.Text = data[0];
            txtCompanyName.Text = data[1];
            txtContactName.Text = data[2];
            txtContactTitle.Text = data[3];
            txtAddress.Text = data[4];
            txtCity.Text = data[5];
            txtRegion.Text = data[6];
            txtPostalCode.Text = data[7];
            txtCountry.Text = data[8];
            txtPhone.Text = data[9];
            txtFax.Text = data[10];
            txtHomePage.Text = data[11];
        }

        // delete data from parent form
        private void btnEditSubmit_Click(object sender, EventArgs e)
        {
            BLLDelete control = new BLLDelete();
            List<string> data = new List<string>();

            data.Add(txtID.Text);
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

            if (control.Delete(data) == 1)
            {
                MessageBox.Show("Xóa thành công!");
            } else
            {
                MessageBox.Show("Xóa thất bại");
            }
        }

        private void frmEditDetail_FormClosing(object sender, FormClosingEventArgs e)
        {
            closeEvent += new pointer(frmParent.LoadDataGridView);
            closeEvent();
        }
    }
}
