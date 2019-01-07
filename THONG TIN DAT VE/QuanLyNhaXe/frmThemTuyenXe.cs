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
    public partial class frmThemTuyenXe : Form
    {
        protected frmTuyenXe _frmParent;
        public frmThemTuyenXe()
        {
            InitializeComponent();

        }

        public frmThemTuyenXe(frmTuyenXe frmParent)
        {
            InitializeComponent();
            this._frmParent = frmParent;

        }


       

       

        private void ThemTuyenXe_FormClosed(object sender, FormClosedEventArgs e)
        {
            //updateTramDen();
            this._frmParent.loadGridTuyenXe();
        }
     

        //private void btn_TaoTramTrungGian_Click(object sender, EventArgs e)
        //{
        //    if (string.IsNullOrEmpty(cbTenTram.Text)) return;
        //    if (string.IsNullOrEmpty(cbTuyenIdTuyen.Text)) return;

        //    BUS_TramTrungGian bus = new BUS_TramTrungGian();
        //    DTO_TramTrungGian dto_ttg = new DTO_TramTrungGian();


        //    dto_ttg.TuyenIDTuyen = Convert.ToInt32(cbTuyenIdTuyen.Text);
        //    dto_ttg.TramIDTram = Convert.ToInt32(cbTramIdTram.Text);
        //    if (!bus.checkExistsTenTramInTuyen(dto_ttg))
        //    {
        //        if (bus.InsertTramTG(dto_ttg))
        //        {
        //            MessageBox.Show("Thêm thành công!");
        //        }
        //        else
        //        {
        //            MessageBox.Show("Thêm không thành công");
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("Tên trạm không được trùng với trạm đã có ban đầu");
        //    }
        //    int a = bus.updateTuyen(dto_ttg);

        //    MessageBox.Show(a.ToString());

        //}
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


            dt = bus.listTram();
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
