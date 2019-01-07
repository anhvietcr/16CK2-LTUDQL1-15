namespace QuanLyNhaXe
{
    partial class frmVeBan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer_open = new System.Windows.Forms.Timer(this.components);
            this.timer_close = new System.Windows.Forms.Timer(this.components);
            this.dgvVe = new System.Windows.Forms.DataGridView();
            this.panel_navbar_title = new System.Windows.Forms.Panel();
            this.ctr_navbar_title = new UserController.ctr_navbar_title();
            this.menu_danhSachVe = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.xóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cậpNhậtTìnhTrạngVéToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ID_Ve = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ghe_ID_Ghe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Chuyen_ID_Chuyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KhachHang_ID_KhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TInhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayXuatVe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVe)).BeginInit();
            this.panel_navbar_title.SuspendLayout();
            this.menu_danhSachVe.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer_open
            // 
            this.timer_open.Tick += new System.EventHandler(this.timer_open_Tick);
            // 
            // timer_close
            // 
            this.timer_close.Tick += new System.EventHandler(this.time_close_Tick);
            // 
            // dgvVe
            // 
            this.dgvVe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Ve,
            this.Ghe_ID_Ghe,
            this.Chuyen_ID_Chuyen,
            this.KhachHang_ID_KhachHang,
            this.TInhTrang,
            this.GiaTien,
            this.ngayXuatVe,
            this.ghiChu});
            this.dgvVe.ContextMenuStrip = this.menu_danhSachVe;
            this.dgvVe.Location = new System.Drawing.Point(0, 38);
            this.dgvVe.MultiSelect = false;
            this.dgvVe.Name = "dgvVe";
            this.dgvVe.Size = new System.Drawing.Size(800, 472);
            this.dgvVe.TabIndex = 0;
            this.dgvVe.CellContextMenuStripNeeded += new System.Windows.Forms.DataGridViewCellContextMenuStripNeededEventHandler(this.dgvVe_CellContextMenuStripNeeded);
            // 
            // panel_navbar_title
            // 
            this.panel_navbar_title.Controls.Add(this.ctr_navbar_title);
            this.panel_navbar_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_navbar_title.Location = new System.Drawing.Point(0, 0);
            this.panel_navbar_title.Name = "panel_navbar_title";
            this.panel_navbar_title.Size = new System.Drawing.Size(800, 40);
            this.panel_navbar_title.TabIndex = 1;
            // 
            // ctr_navbar_title
            // 
            this.ctr_navbar_title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.ctr_navbar_title.Location = new System.Drawing.Point(0, 0);
            this.ctr_navbar_title.Name = "ctr_navbar_title";
            this.ctr_navbar_title.Size = new System.Drawing.Size(800, 40);
            this.ctr_navbar_title.TabIndex = 0;
            // 
            // menu_danhSachVe
            // 
            this.menu_danhSachVe.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cậpNhậtTìnhTrạngVéToolStripMenuItem,
            this.xóaToolStripMenuItem});
            this.menu_danhSachVe.Name = "menu_danhSachVe";
            this.menu_danhSachVe.Size = new System.Drawing.Size(193, 70);
            this.menu_danhSachVe.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menu_danhSachVe_ItemClicked);
            // 
            // xóaToolStripMenuItem
            // 
            this.xóaToolStripMenuItem.Name = "xóaToolStripMenuItem";
            this.xóaToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.xóaToolStripMenuItem.Text = "Xóa";
            // 
            // cậpNhậtTìnhTrạngVéToolStripMenuItem
            // 
            this.cậpNhậtTìnhTrạngVéToolStripMenuItem.Name = "cậpNhậtTìnhTrạngVéToolStripMenuItem";
            this.cậpNhậtTìnhTrạngVéToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.cậpNhậtTìnhTrạngVéToolStripMenuItem.Text = "Cập nhật tình trạng Vé";
            // 
            // ID_Ve
            // 
            this.ID_Ve.HeaderText = "ID";
            this.ID_Ve.Name = "ID_Ve";
            this.ID_Ve.Width = 50;
            // 
            // Ghe_ID_Ghe
            // 
            this.Ghe_ID_Ghe.HeaderText = "Ghế";
            this.Ghe_ID_Ghe.Name = "Ghe_ID_Ghe";
            this.Ghe_ID_Ghe.Width = 50;
            // 
            // Chuyen_ID_Chuyen
            // 
            this.Chuyen_ID_Chuyen.HeaderText = "Chuyến";
            this.Chuyen_ID_Chuyen.Name = "Chuyen_ID_Chuyen";
            this.Chuyen_ID_Chuyen.Width = 50;
            // 
            // KhachHang_ID_KhachHang
            // 
            this.KhachHang_ID_KhachHang.HeaderText = "Khách hàng";
            this.KhachHang_ID_KhachHang.Name = "KhachHang_ID_KhachHang";
            // 
            // TInhTrang
            // 
            this.TInhTrang.HeaderText = "Tình Trạng";
            this.TInhTrang.Name = "TInhTrang";
            // 
            // GiaTien
            // 
            this.GiaTien.HeaderText = "Giá tiền";
            this.GiaTien.Name = "GiaTien";
            this.GiaTien.Width = 130;
            // 
            // ngayXuatVe
            // 
            this.ngayXuatVe.HeaderText = "Ngày xuất vé";
            this.ngayXuatVe.Name = "ngayXuatVe";
            // 
            // ghiChu
            // 
            this.ghiChu.HeaderText = "Ghi chú";
            this.ghiChu.Name = "ghiChu";
            this.ghiChu.Width = 200;
            // 
            // frmVeBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 510);
            this.Controls.Add(this.panel_navbar_title);
            this.Controls.Add(this.dgvVe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmVeBan";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmVeBan";
            this.Load += new System.EventHandler(this.frmBanVe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVe)).EndInit();
            this.panel_navbar_title.ResumeLayout(false);
            this.menu_danhSachVe.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer_open;
        private System.Windows.Forms.Timer timer_close;
        private System.Windows.Forms.DataGridView dgvVe;
        private System.Windows.Forms.Panel panel_navbar_title;
        private UserController.ctr_navbar_title ctr_navbar_title;
        private System.Windows.Forms.ContextMenuStrip menu_danhSachVe;
        private System.Windows.Forms.ToolStripMenuItem cậpNhậtTìnhTrạngVéToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Ve;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ghe_ID_Ghe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Chuyen_ID_Chuyen;
        private System.Windows.Forms.DataGridViewTextBoxColumn KhachHang_ID_KhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn TInhTrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayXuatVe;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghiChu;
    }
}