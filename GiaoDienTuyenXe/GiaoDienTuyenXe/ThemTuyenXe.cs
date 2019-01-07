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
    public partial class ThemTuyenXe : Form
    {
        protected frmTuyenXe _frmParent;
        public ThemTuyenXe()
        {
            InitializeComponent();

        }

        public ThemTuyenXe(frmTuyenXe frmParent)
        {
            InitializeComponent();
            this._frmParent = frmParent;

        }

        private void btnTaoTram_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenTram.Text)) return;
            if (string.IsNullOrEmpty(txtDiaDiem.Text)) return;

           

            BUS_Tram bus = new BUS_Tram();
            DTO_Tram dto_tr = new DTO_Tram();

            dto_tr.Ten_Tram = txtTenTram.Text;
            dto_tr.Dia_Diem = txtDiaDiem.Text;

            if (bus.Insert(dto_tr))
            {
                MessageBox.Show("Thêm thành công!");

                LoadComboboxTenTram();
            }
            else
            {
                MessageBox.Show("Thêm không thành công!");
            }

        }



        private void btnTaoTuyen_Click(object sender, EventArgs e)

        {
            if (string.IsNullOrEmpty(txtKhoangCach.Text)) return;
            if (string.IsNullOrEmpty(txtTGChay.Text)) return;
            if (string.IsNullOrEmpty(cbIdTramDen.Text)) return;
            if (string.IsNullOrEmpty(cbIdTramDi.Text)) return;

            double khoangCach;
            if (!double.TryParse(txtKhoangCach.Text, out khoangCach))
            {
                MessageBox.Show("Khoảng cách phải là giá trị thực", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            BUS_TuyenXe bus = new BUS_TuyenXe();
            DTO_TuyenXe dto_tx = new DTO_TuyenXe();

            dto_tx.KhoangCach = Convert.ToDouble(txtKhoangCach.Text);
            dto_tx.ThoiGianChay = Convert.ToInt32(txtTGChay.Text);
            dto_tx.Tram_ID_Tram1 = Convert.ToInt32(cbIdTramDi.Text);
            dto_tx.Tram_ID_Tram = Convert.ToInt32(cbIdTramDen.Text);


            if (bus.Insert(dto_tx))
            {
                MessageBox.Show("Thêm thành công!");

            }
            else
            {
                MessageBox.Show("Thêm không thành công!");
            }
        }

        private void ThemTuyenXe_Load(object sender, EventArgs e)
        {
            //getIdTuyenIdTram();
            getTenTram();
            getTuyenIDTuyenbyTuyen();
            LoadComboboxTenTram();
            
        }
        void LoadComboboxTenTram()
        {
            //trước khi load thì reset lại cb
            cbTramDi.Items.Clear();
            cbTramDen.Items.Clear();
            cbIdTramDi.Items.Clear();
            cbIdTramDen.Items.Clear();
            DataTable dt = new DataTable();

            BUS_Tram bus = new BUS_Tram();
            dt = bus.listTenTram();

            foreach (DataRow r in dt.Rows)
            {
                cbTramDi.Items.Add(r["TenTram"]);
                cbTramDen.Items.Add(r["TenTram"]);
                cbIdTramDi.Items.Add(r["ID_Tram"]);
                cbIdTramDen.Items.Add(r["ID_Tram"]);
            }
            //hiển thị index=0 tức là vị trí đầu tiền trong cbox
            if (cbIdTramDi.Items.Count > 0)
            {
                cbTramDi.SelectedIndex = 1;
                cbTramDen.SelectedIndex = 0;
                cbIdTramDi.SelectedIndex = 1;
                cbIdTramDen.SelectedIndex = 0;
            }
        }

        private void cbTramDen_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = (sender as ComboBox).SelectedIndex;
            if (cbIdTramDen.Items.Count > 0)
            {
                if (index == cbIdTramDi.SelectedIndex)
                {
                    MessageBox.Show("Điểm đến và điểm đi không được trùng nhau");
                    return;
                }
                cbIdTramDen.SelectedIndex = index;
            }
        }

        private void cbTramDi_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = (sender as ComboBox).SelectedIndex;
            if (cbIdTramDi.Items.Count > 0)
            {
                if (index == cbIdTramDen.SelectedIndex)
                {
                    MessageBox.Show("Điểm đến và điểm đi không được trùng nhau");
                    return;
                }
                cbIdTramDi.SelectedIndex = index;
            }
        }

        private void ThemTuyenXe_FormClosed(object sender, FormClosedEventArgs e)
        {
            updateTramDen();
            this._frmParent.loadGridTuyenXe();
        }
        public void updateTramDen()
        {
            BUS_TuyenXe bus = new BUS_TuyenXe();
            DTO_TuyenXe tx = new DTO_TuyenXe();

            DataTable dt = new DataTable();
            dt = bus.updateTramDen(tx);

            foreach (DataRow r in dt.Rows)
            {
                cbIdTramDen.Items.Add(r["Tram_ID_Tram"]);
            }
            
        }

        private void btn_TaoTramTrungGian_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbTenTram.Text)) return;
            if (string.IsNullOrEmpty(cbTuyenIdTuyen.Text)) return;

            BUS_TramTrungGian bus = new BUS_TramTrungGian();
            DTO_TramTrungGian dto_ttg = new DTO_TramTrungGian();


            dto_ttg.TuyenIDTuyen = Convert.ToInt32(cbTuyenIdTuyen.Text);
            dto_ttg.TramIDTram = Convert.ToInt32(cbTramIdTram.Text);
            if (!bus.checkExistsTenTramInTuyen(dto_ttg))
            {
                if (bus.InsertTramTG(dto_ttg))
                {
                    MessageBox.Show("Thêm thành công!");
                }
                else
                {
                    MessageBox.Show("Thêm không thành công");
                }
            }
            else
            {
                MessageBox.Show("Tên trạm không được trùng với trạm đã có ban đầu");
            }
            int a = bus.updateTuyen(dto_ttg);

            //MessageBox.Show(a.ToString());

        }
        void getIdTuyenIdTram()
        {
            DataTable dt = new DataTable();
            BUS_TramTrungGian bus = new BUS_TramTrungGian();
            dt = bus.getIdTuyenIdTram();

            foreach (DataRow r in dt.Rows)
            {
                cbTuyenIdTuyen.Items.Add(r["Tuyen_ID_Tuyen"]);
                cbTenTram.Items.Add(r["Tram_ID_Tram"]);
            }
        }

        void getTuyenIDTuyenbyTuyen()
        {
            DataTable dt = new DataTable();
            BUS_TramTrungGian bus = new BUS_TramTrungGian();
            dt = bus.getTuyenIDTuyenbyTuyen();


            foreach (DataRow r in dt.Rows)
            {
                cbTuyenIdTuyen.Items.Add(r["ID_Tuyen"]);
            }
        }
        void getTenTram()
        {
            BUS_Tram bus = new BUS_Tram();

            DTO_TramTrungGian dto_ttg = new DTO_TramTrungGian();

            DataTable dt = new DataTable();


            dt = bus.listTenTram();
            foreach (DataRow r in dt.Rows)
            {
                cbTenTram.Items.Add(r["TenTram"]);
                cbTramIdTram.Items.Add(r["ID_Tram"]);
            }
        }

        private void cbTenTram_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = (sender as ComboBox).SelectedIndex;
            if (cbTenTram.Items.Count > 0)
            {
                cbTramIdTram.SelectedIndex = index;
                cbTenTram.SelectedIndex = index;
            }
        }
        
    }

}
