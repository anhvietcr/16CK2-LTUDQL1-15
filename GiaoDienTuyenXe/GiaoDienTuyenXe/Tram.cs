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

namespace GiaoDienTuyenXe
{
    public partial class Tram : Form
    {
        protected frmTuyenXe _frmParent;
        public Tram(frmTuyenXe frmParent)
        {
            InitializeComponent();
            this._frmParent = frmParent;

        }
        public Tram()
        {
            InitializeComponent();
        }
        void listTenTram()
        {
            BUS_Tram bus = new BUS_Tram();

            DataTable dt = new DataTable();

            dt = bus.listTram();

            foreach (DataRow r in dt.Rows)
            {
                cbIdTram.Items.Add(r["ID_Tram"]);
                cbTenTram.Items.Add(r["TenTram"]);
                cbDiaDiem.Items.Add(r["Dia_diem"]);
            }
            //hiển thị index=0 tức là vị trí đầu tiền trong cbox
            if (cbTenTram.Items.Count > 0)
            {
                cbIdTram.SelectedIndex = 0;
                cbTenTram.SelectedIndex = 0;
                cbDiaDiem.SelectedIndex = 0;
            }
        }

        private void Tram_Load(object sender, EventArgs e)
        {
            loadGridTram();
            listTenTram();
        }

      

        private void cbDiaDiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = (sender as ComboBox).SelectedIndex;
            if (cbDiaDiem.Items.Count > 0)
            {
                cbIdTram.SelectedIndex = index;
                cbTenTram.SelectedIndex = index;
                cbDiaDiem.SelectedIndex = index;
            }
        }

        private void cbTenTram_SelectedIndexChanged(object sender, EventArgs e)
        {

            int index = (sender as ComboBox).SelectedIndex;
            if (cbTenTram.Items.Count > 0)
            {
                cbIdTram.SelectedIndex = index;
                cbTenTram.SelectedIndex = index;
                cbDiaDiem.SelectedIndex = index;
            }

        }
        public void loadGridTram()
        {
            BUS_Tram bus_tram = new BUS_Tram();

            DataTable dt = new DataTable();
            dt = bus_tram.listTram();
            //gán dữ liệu vào datagridview
            for (int i = 0; i < dgrv_Tram.ColumnCount; i++)
            {
                dgrv_Tram.Columns[i].DataPropertyName = dgrv_Tram.Columns[i].Name;
            }
            dgrv_Tram.DataSource = dt;

        }

        private void dgrv_Tram_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int iRow = dgrv_Tram.CurrentCell.RowIndex;

           cbIdTram.Text = dgrv_Tram.Rows[iRow].Cells[0].Value.ToString();
           cbTenTram.Text = dgrv_Tram.Rows[iRow].Cells[1].Value.ToString();
           cbDiaDiem.Text = dgrv_Tram.Rows[iRow].Cells[2].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbTenTram.Text)) return;
            if (string.IsNullOrEmpty(cbDiaDiem.Text)) return;

            BUS_Tram bus = new BUS_Tram();
            DTO_Tram dto_tr = new DTO_Tram();

            dto_tr.Ten_Tram =cbTenTram.Text;
            dto_tr.Dia_Diem =cbDiaDiem.Text;

            if (!bus.checkExistsTenTramInTram(dto_tr))
            {
                if (bus.Insert(dto_tr))
                {
                    MessageBox.Show("Thêm trạm thành công!");
                    loadGridTram();
                }
                else
                {
                    MessageBox.Show("Thêm trạm không thành công!");
                }
            }
            else
            {
                MessageBox.Show("Tên trạm đã tồn tại!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            BUS_Tram bus = new BUS_Tram();
            DTO_Tram dto_tr = new DTO_Tram();

            dto_tr.Id_Tram = Convert.ToInt32(cbIdTram.Text);

            if (bus.xoaTram(dto_tr))
            {
                MessageBox.Show("Xóa trạm thành công!");
                loadGridTram();
            }
            else
            {
                MessageBox.Show("Xóa trạm không thành công!");
            }
            cbTenTram.ResetText();
            cbDiaDiem.ResetText();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbTenTram.Text)) return;
            if (string.IsNullOrEmpty(cbDiaDiem.Text)) return;

            BUS_Tram bus = new BUS_Tram();
            DTO_Tram dto_tr = new DTO_Tram();


            dto_tr.Id_Tram = Convert.ToInt32(cbIdTram.Text);
            dto_tr.Ten_Tram = Convert.ToString(cbTenTram.Text);
            dto_tr.Dia_Diem= Convert.ToString(cbDiaDiem.Text);


            if (bus.suaTram(dto_tr))
            {
                MessageBox.Show("Sửa trạm thành công!");
                loadGridTram();
            }
            else
            {
                MessageBox.Show("Sửa trạm không thành công!");
            }
            

        }

        private void Tram_FormClosed(object sender, FormClosedEventArgs e)
        {
            //updateTramDen();
            this._frmParent.listTenTram();
            this._frmParent.loadGridTuyenXe();

        }
    }




}      

