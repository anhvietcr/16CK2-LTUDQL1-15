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
    public partial class frmTuyenXe : Form
    {
        public frmTuyenXe()
        {
            InitializeComponent();
            // button menu clicked

            ctr_menu1.btn_menu_1.Click += new EventHandler(btnMenu1_click);
            ctr_menu1.btn_menu_2.Click += new EventHandler(btnMenu2_click);
            ctr_menu1.btn_menu_3.Click += new EventHandler(btnMenu3_click);
            ctr_menu1.btn_menu_4.Click += new EventHandler(btnMenu4_click);
            ctr_menu1.btn_menu_5.Click += new EventHandler(btnMenu5_click);
            ctr_menu1.btn_menu_info.Click += new EventHandler(btnMenuInfo_click);

            // button navbar clicked
            ctr_navbar1.btn_close.Click += new EventHandler(btnClose_click);
            ctr_navbar1.btn_toggle_menu.Click += new EventHandler(btnToggleMenu_click);

            // move form
            ctr_navbar1.MouseMove += new MouseEventHandler(ctr_navbar1_MouseMove);
            ctr_navbar1.MouseDown += new MouseEventHandler(ctr_navbar1_MouseDown);
        }

        //button menu clicked -> show Forms
        void btnMenu1_click(object sender, EventArgs e)
        {
            MessageBox.Show("Đặt vé clicked");
        }

        void btnMenu2_click(object sender, EventArgs e)
        {
            MessageBox.Show("Khách hàng clicked");
        }

        void btnMenu3_click(object sender, EventArgs e)
        {
            MessageBox.Show("Chuyến xe clicked");
        }

        void btnMenu4_click(object sender, EventArgs e)
        {
            MessageBox.Show("Tuyến xe clicked");
        }

        void btnMenu5_click(object sender, EventArgs e)
        {
            MessageBox.Show("Vé bán clicked");
        }

        void btnMenuInfo_click(object sender, EventArgs e)
        {
            MessageBox.Show("button info team clicked");
        }

        //button navbar clicked
        void btnClose_click(object sender, EventArgs e)
        {
            timer_close.Start();
        }

        void btnToggleMenu_click(object sender, EventArgs e)
        {
            if (ctr_menu1.Width <= 85)
            {
                ctr_menu1.Width = 200;
                pnlTop.Width = 200;
            }
            else
            {
                ctr_menu1.Width = 85;
                pnlTop.Width = 85;
            }
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

        private void timer_open_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1)
            {
                this.Opacity += 0.15;
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
                this.Opacity -= 0.15;
            }
            else
            {
                timer_close.Stop();
                this.Close();
            }
        }

        // effect load form
        void frmTuyenXe_Load(object sender, EventArgs e)
        {
            timer_open.Start();
            loadGridTuyenXe();
            getTenTrambyTuyen();
        }
        private void loadGridTuyenXe()
        {
            BUS_TuyenXe bus_tuyenxe = new BUS_TuyenXe();

            DataTable dt = new DataTable();
            //dt sẽ hứng dữ liệu đổ vào từ bus_tuyenxe.ListTuyenXe()
            dt = bus_tuyenxe.ListTuyenXe();
            //gán dữ liệu vào datagridview
            dgrv_TuyenXe.DataSource = dt;
            
        }

        void getTenTrambyTuyen()
        {
            DataTable dt = new DataTable();
            BUS_TuyenXe bus = new BUS_TuyenXe();
            dt = bus.getTenTrambyTuyen();
            
            foreach (DataRow r in dt.Rows)
            {
                cbIdTuyen.Items.Add(r["ID_Tuyen"]);
                cbTramDi.Items.Add(r["TramBatDau"]);
                cbTramDen.Items.Add(r["TramKetThuc"]);
                cbIDTramDi.Items.Add(r["IDTramBatDau"]);
                cbIDTramDen.Items.Add(r["IDTramKetThuc"]);
            }
            //hiển thị index=0 tức là vị trí đầu tiền trong cbox
            if (cbIdTuyen.Items.Count > 0)
            {
                cbTramDi.SelectedIndex = 0;
                cbTramDen.SelectedIndex = 0;
                cbIdTuyen.SelectedIndex = 0;
            }

        }
       

  


        

        private void dgrv_TuyenXe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            BUS_TuyenXe bus = new BUS_TuyenXe();
            DTO_TuyenXe dto_tx = new DTO_TuyenXe();

            dto_tx.ID_Tuyen = Convert.ToInt32(cbIdTuyen.Text);
            dto_tx.KhoangCach =Convert.ToDouble(txtKhoangCach.Text);
            dto_tx.ThoiGianChay = Convert.ToInt32(txtThoiGianChay.Text);
            dto_tx.Tram_ID_Tram1 = Convert.ToInt32(cbTramDi.Text);
            dto_tx.Tram_ID_Tram = Convert.ToInt32(cbTramDen.Text);

            if(bus.Them(dto_tx))
            {
                MessageBox.Show("Thêm thành công!");
                loadGridTuyenXe();
            }
            else
            {
                MessageBox.Show("Thêm không thành công!");
            }

        }

        private void cbTramDi_SelectedIndexChanged(object sender, EventArgs e)
        {
            IndexTramChange(sender);
        }

        private void cbTramDen_SelectedIndexChanged(object sender, EventArgs e)
        {
            IndexTramChange(sender);
        }

        //nếu như cbTramDi_SelectedIndexChanged(tenTramDi), cbTramDen_SelectedIndexChanged(tenTramDen) thay đổi thì nhữn gthawfng còn lại cũng sẽ cập nhật index tương ứng
        void IndexTramChange(object sender)
        {
            int index = (sender as ComboBox).SelectedIndex;
            if (cbIdTuyen.Items.Count > 0)
            {
                cbTramDi.SelectedIndex = index;
                cbTramDen.SelectedIndex = index;
                cbIdTuyen.SelectedIndex = index;
                cbIDTramDi.SelectedIndex = index;
                cbIDTramDen.SelectedIndex = index;

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cbIdTuyen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtThoiGianChay_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
