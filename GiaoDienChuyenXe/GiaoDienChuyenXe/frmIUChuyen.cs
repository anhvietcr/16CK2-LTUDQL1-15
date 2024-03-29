﻿using System;
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
using System.Globalization;

namespace GiaoDienChuyenXe
{
    public partial class frmIUChuyen : Form
    {
        BUS_Chuyen c;
        DTO_Chuyen dto_c = new DTO_Chuyen();
        int xet;
        public frmIUChuyen(DTO_Chuyen dto,int i)
        {
            InitializeComponent();
            dto_c = dto;
            xet = i;

        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            c = new BUS_Chuyen();
            DialogResult dlr = MessageBox.Show("Are you sure you want to UPDATE ?", "UPDATE", MessageBoxButtons.YesNo, MessageBoxIcon.None);
            if (dlr == DialogResult.Yes)
            {
                c.UpdateChuyen(dto_c);

            }
            this.Close();
        }

        private void frmIUChuyen_Load(object sender, EventArgs e)
        {
            if (xet == 1)
            {
                tbID_Chuyen.Text = dto_c.ID_Chuyen.ToString();
                tbIDTuyen.Text = dto_c.Tuyen_ID_Tuyen.ToString();
                tbIDXe.Text = dto_c.Xe_XeID.ToString();
                tbIDTaiXe.Text = dto_c.Tai_xe_ID_TaiXe.ToString();
                dtpNKH.Value = DateTime.Parse(dto_c.Gio_khoi_hanh.ToString("MM/dd/yyyy"));
                tbGhichu.Text = dto_c.Ghi_chu;
                btUpdate.Visible = true;
                btInsert.Dispose();
            }
            else
                if(xet==2)
            {
                btInsert.Visible = true;
            }
        }

        private void tbID_Chuyen_TextChanged(object sender, EventArgs e)
        {
            if (Int32.TryParse(tbID_Chuyen.Text,out int x))
            {
                dto_c.ID_Chuyen = x;
                btUpdate.Dispose();
            }
           
        }

        private void tbIDTuyen_TextChanged(object sender, EventArgs e)
        {
            if (Int32.TryParse(tbIDTuyen.Text, out int x))
            {
                dto_c.Tuyen_ID_Tuyen = x;
            }
        }

        private void tbIDXe_TextChanged(object sender, EventArgs e)
        {
            if (Int32.TryParse(tbIDXe.Text, out int x))
            {
                dto_c.Xe_XeID = x;
            }
        }

        private void tbIDTaiXe_TextChanged(object sender, EventArgs e)
        {
            if (Int32.TryParse(tbIDTaiXe.Text, out int x))
            {
                dto_c.Tai_xe_ID_TaiXe = x;
            }
        }

        private void dtpNKH_ValueChanged(object sender, EventArgs e)
        {
            if (DateTime.TryParse(dtpNKH.Value.ToString("yyyy/MM/dd"), out DateTime x))
            {
                dto_c.Gio_khoi_hanh = x;
            }
        }

        private void tbGhichu_TextChanged(object sender, EventArgs e)
        {
           dto_c.Ghi_chu = tbGhichu.Text.ToString();           
        }

        private void btInsert_Click(object sender, EventArgs e)
        {
            c = new BUS_Chuyen();
            DialogResult dlr = MessageBox.Show("Are you sure you want to UPDATE ?", "UPDATE", MessageBoxButtons.YesNo, MessageBoxIcon.None);
            if (dlr == DialogResult.Yes)
            {
                c.InsertChuyen(dto_c);

            }
            this.Close();
        }
    }
}
