using BUS;
using DTO;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

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

        public void loadGridTuyenXe()
        {
            dgrv_TuyenXe.Rows.Clear();

            BUS_TuyenXe bus_tuyenxe = new BUS_TuyenXe();

            DataTable dt = new DataTable();
            //dt sẽ hứng dữ liệu đổ vào từ bus_tuyenxe.ListTuyenXe()
            dt = bus_tuyenxe.ListTuyenXe();
            //gán dữ liệu vào datagridview

            int i = 0;
            foreach (DataRow r in dt.Rows)
            {
                DataRow row = dt.Rows[i++];
                string id_tuyen = row["ID_Tuyen"].ToString();
                string khoangCach = row["KhoangCach"].ToString();
                string thoiGianChay = row["ThoiGianChay"].ToString();
                string tramDi = row["Tram_ID_Tram1"].ToString();
                string tramDen = row["Tram_ID_Tram"].ToString();


                dgrv_TuyenXe.Rows.Add(id_tuyen, khoangCach, thoiGianChay, tramDi, tramDen);
            }

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
        void getTuyenbyId(string idTuyen)
        {
            BUS_TuyenXe bus = new BUS_TuyenXe();
            DataTable dt = new DataTable();

            DTO_TuyenXe tx = new DTO_TuyenXe();
            tx.ID_Tuyen = Convert.ToInt32(idTuyen);

            dt = bus.GetTuyenById(tx);

            //MessageBox.Show(dt.Rows[0]["TramBatDau"].ToString());
            //MessageBox.Show(dt.Rows[0]["TramKetThuc"].ToString());


            int i = 0;
            foreach (var id in cbIDTramDen.Items)
            {
                if (dt.Rows[0]["IDTramKetThuc"].ToString() == id.ToString())
                {
                    cbIDTramDen.SelectedIndex = i;
                    cbIDTramDi.SelectedIndex = i;
                    cbTramDen.SelectedIndex = i;
                    cbTramDi.SelectedIndex = i;
                    cbIdTuyen.SelectedIndex = i;
                }
                i++;
            }

        }

        private void dgrv_TuyenXe_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int iRow = dgrv_TuyenXe.CurrentCell.RowIndex;
            //dòng click vào=dòng cuối thì return
            if (dgrv_TuyenXe.Rows.Count - 1 == iRow) return;

            cbIdTuyen.Text = dgrv_TuyenXe.Rows[iRow].Cells[0].Value.ToString();
            txtKhoangCach.Text = dgrv_TuyenXe.Rows[iRow].Cells[1].Value.ToString();
            txtThoiGianChay.Text = dgrv_TuyenXe.Rows[iRow].Cells[2].Value.ToString();

            if (string.IsNullOrEmpty(cbIdTuyen.Text)) return; 
            //lấy được thông tin tuyến thông qua id để truyền vào cb
            getTuyenbyId(cbIdTuyen.Text);
    }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //khi mở form mới thì truyền vào form hiện tại
            ThemTuyenXe frm = new ThemTuyenXe(this);

            frm.ShowDialog();

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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            BUS_TuyenXe bus = new BUS_TuyenXe();
            DTO_TuyenXe tx = new DTO_TuyenXe();

            if (string.IsNullOrEmpty(cbIdTuyen.Text)) return;
             
            tx.ID_Tuyen = Convert.ToInt32(cbIdTuyen.Text);
            if (bus.Delete(tx))
            {
                MessageBox.Show("Xoa thanh cong");
                loadGridTuyenXe();
            }
            else
            {
                MessageBox.Show("Khong xoa duoc");
            }
        }
    
        private void btnSua_Click(object sender, EventArgs e)
        {

        }
    }
}
