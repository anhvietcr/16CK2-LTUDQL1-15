using BUS;
using DTO;
using System;
using System.Data;
using System.Drawing;
using System.Security.Principal;
using System.Threading;
using System.Windows.Forms;

namespace QuanLyNhaXe
{
    public partial class frmTuyenXe : Form
    {
        public frmDashboard frmDB;
        public GenericPrincipal principal = Thread.CurrentPrincipal as GenericPrincipal;

        public frmTuyenXe(frmDashboard frm)
        {
            InitializeComponent();
            frmDB = frm;
            // button menu clicked
            ctr_menu1.btn_menu_4.Enabled = false;

            ctr_menu1.btn_menu_1.Click += new EventHandler(btnMenu1_click);
            ctr_menu1.btn_menu_2.Click += new EventHandler(btnMenu2_click);
            ctr_menu1.btn_menu_3.Click += new EventHandler(btnMenu3_click);
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
            frmDB.openFormById(1);
            this.Close();
        }

        void btnMenu2_click(object sender, EventArgs e)
        {
            frmDB.openFormById(2);
            this.Close();
        }

        void btnMenu3_click(object sender, EventArgs e)
        {
            frmDB.openFormById(3);
            this.Close();
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
            if (ctr_menu1.Width <= 85)
            {
                ctr_menu1.Width = 200;
                pnlLeft.Width = 200;
                ctr_navbar1.btn_toggle_menu.ImageIndex = 0;

            }
            else
            {
                ctr_menu1.Width = 85;
                pnlLeft.Width = 85;
                ctr_navbar1.btn_toggle_menu.ImageIndex = 2;
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
                this.Opacity += 0.45;
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
                this.Opacity -= 0.45;
            }
            else
            {
                timer_close.Stop();
                frmDB.Show();
                this.Close();
            }
        }

        // effect load form
        void frmTuyenXe_Load(object sender, EventArgs e)
        {
            timer_open.Start();
            loadGridTuyenXe();
            //getTenTrambyTuyen();
            listTenTram();


        }
       public void listTenTram()
        {
            cbTramDi.Items.Clear();
            cbTramDen.Items.Clear();
            cbIDTramDi.Items.Clear();
            cbIDTramDen.Items.Clear();


            BUS_Tram bus = new BUS_Tram();
            DataTable dt = new DataTable();
            dt = bus.listTram();
            foreach (DataRow r in dt.Rows)
            {
                cbTramDi.Items.Add(r["TenTram"]);
                cbTramDen.Items.Add(r["TenTram"]);
                cbIDTramDi.Items.Add(r["ID_Tram"]);
                cbIDTramDen.Items.Add(r["ID_Tram"]);
            }
            //hiển thị index=0 tức là vị trí đầu tiền trong cbox
            if (cbIDTramDi.Items.Count > 0)
            {
                cbTramDi.SelectedIndex = 1;
                cbTramDen.SelectedIndex = 0;
                cbIDTramDi.SelectedIndex = 1;
                cbIDTramDen.SelectedIndex = 0;
            }

        }

        public void loadGridTuyenXe()
        {

            BUS_TuyenXe bus_tuyenxe = new BUS_TuyenXe();

            DataTable dt = new DataTable();
            //dt sẽ hứng dữ liệu đổ vào từ bus_tuyenxe.ListTuyenXe()
            dt = bus_tuyenxe.ListTuyenXe();
            //gán dữ liệu vào datagridview
            for (int i = 0; i < dgrv_TuyenXe.ColumnCount; i++)
            {
                dgrv_TuyenXe.Columns[i].DataPropertyName = dgrv_TuyenXe.Columns[i].Name;
            }
            dgrv_TuyenXe.DataSource = dt;

        }

      public  void getTenTrambyTuyen()
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

            DataRow r = dt.Rows[0];

            cbTramDen.Text = r["TramKetThuc"].ToString();
            cbTramDi.Text = r["TramBatDau"].ToString();
           
        }
      

        private void dgrv_TuyenXe_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int iRow = dgrv_TuyenXe.CurrentCell.RowIndex;
            //dòng click vào=dòng cuối thì return
            if (dgrv_TuyenXe.Rows.Count - 1 == iRow) return;

            cbIdTuyen.Text = dgrv_TuyenXe.Rows[iRow].Cells[0].Value.ToString();
            txtKhoangCach.Text = dgrv_TuyenXe.Rows[iRow].Cells[1].Value.ToString();
            txtThoiGianChay.Text = dgrv_TuyenXe.Rows[iRow].Cells[2].Value.ToString();
            cbIDTramDi.Text= dgrv_TuyenXe.Rows[iRow].Cells[3].Value.ToString();
            cbIDTramDen.Text = dgrv_TuyenXe.Rows[iRow].Cells[4].Value.ToString();

            //if (string.IsNullOrEmpty(cbIdTuyen.Text)) return;
            //lấy được thông tin tuyến thông qua id để truyền vào cb
            getTuyenbyId(cbIdTuyen.Text);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtKhoangCach.Text)) return;
            if (string.IsNullOrEmpty(txtThoiGianChay.Text)) return;
            if (string.IsNullOrEmpty(cbIDTramDen.Text)) return;
            if (string.IsNullOrEmpty(cbIDTramDi.Text)) return;

            double khoangCach;
            if (!double.TryParse(txtKhoangCach.Text, out khoangCach))
            {
                MessageBox.Show("Khoảng cách phải là giá trị thực", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int gio;
            if (!int.TryParse(txtThoiGianChay.Text, out gio))
            {
                MessageBox.Show("Thời gian phải là số", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            BUS_TuyenXe bus = new BUS_TuyenXe();
            DTO_TuyenXe dto_tx = new DTO_TuyenXe();

            dto_tx.KhoangCach = Convert.ToDouble(txtKhoangCach.Text);
            dto_tx.ThoiGianChay = Convert.ToInt32(txtThoiGianChay.Text);
            dto_tx.Tram_ID_Tram1 = Convert.ToInt32(cbIDTramDi.Text);
            dto_tx.Tram_ID_Tram = Convert.ToInt32(cbIDTramDen.Text);

            if (!bus.kiemTraTenTramInTuyen(dto_tx))
            {
                if (bus.Insert(dto_tx))
                {
                    MessageBox.Show("Thêm thành công!");
                    loadGridTuyenXe();
                }
                else
                {
                    MessageBox.Show("Thêm không thành công!");
                }
            }
            else
            {
                MessageBox.Show("Tuyến xe đã tồn tại");
            }
        }
     

        private void cbTramDi_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = (sender as ComboBox).SelectedIndex;
            if (cbTramDi.Items.Count > 0)
            {
                if (index == cbTramDen.SelectedIndex)
                {
                    MessageBox.Show("Điểm đến và điểm đi không được trùng nhau");
                    cbTramDi.SelectedIndex = cbIDTramDi.SelectedIndex;
                    return;
                }
                    //cbTramDi.SelectedIndex = index;
                    cbIDTramDi.SelectedIndex=index;
                
            }
        }
        private void cbTramDen_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = (sender as ComboBox).SelectedIndex;
            if (cbTramDen.Items.Count > 0)
            {
                if (index == cbTramDi.SelectedIndex)
                {
                    MessageBox.Show("Điểm đến và điểm đi không được trùng nhau");
                    cbTramDen.SelectedIndex = cbIDTramDen.SelectedIndex;
                    return;
                }
                
                cbIDTramDen.SelectedIndex = index;
            }
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
            if (principal.IsInRole("client  "))
            {
                MessageBox.Show("Bạn không có quyền thực hiện chức năng này");
                return;
            }

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
            cbIdTuyen.ResetText();
            txtKhoangCach.ResetText();
            txtThoiGianChay.ResetText();
            cbTramDi.ResetText();
            cbTramDen.ResetText();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            BUS_TuyenXe bus = new BUS_TuyenXe();
            DTO_TuyenXe tx = new DTO_TuyenXe();


            if (string.IsNullOrEmpty(txtKhoangCach.Text) || string.IsNullOrEmpty(txtThoiGianChay.Text)|| string.IsNullOrEmpty(cbTramDen.Text)||string.IsNullOrEmpty(cbTramDi.Text))
            {
                MessageBox.Show("Các combobox không được để trống", "Hãy nhập lại!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //tx.ID_Tuyen = int.Parse(cbIdTuyen.Text);
            tx.ID_Tuyen = Convert.ToInt32(cbIdTuyen.Text);
            tx.KhoangCach = Convert.ToDouble(txtKhoangCach.Text);
            tx.ThoiGianChay = Convert.ToInt32(txtThoiGianChay.Text);
            tx.Tram_ID_Tram1 = Convert.ToInt32(cbIDTramDi.Text);
            tx.Tram_ID_Tram = Convert.ToInt32(cbIDTramDen.Text);
            if (bus.Update(tx))
            {
                MessageBox.Show("Sua thanh cong");
                loadGridTuyenXe();
            }
            else
            {
                MessageBox.Show("Khong sua duoc");
            }
            
        }

        private void btnTram_Click(object sender, EventArgs e)
        {
            if (principal.IsInRole("client  "))
            {
                MessageBox.Show("Bạn không có quyền thực hiện chức năng này");
                return;
            }

            //khi mở form mới thì truyền vào form hiện tại
            frmTram frm = new frmTram(this);

            frm.ShowDialog();
        }

    }
}