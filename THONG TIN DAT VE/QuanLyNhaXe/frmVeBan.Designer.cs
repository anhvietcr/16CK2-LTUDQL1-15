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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel_navbar_title = new System.Windows.Forms.Panel();
            this.ctr_navbar_title = new UserController.ctr_navbar_title();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Ghe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Chuyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_KH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TInhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayXuatVe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel_navbar_title.SuspendLayout();
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.ID_Ghe,
            this.ID_Chuyen,
            this.ID_KH,
            this.TInhTrang,
            this.gia,
            this.ngayXuatVe,
            this.ghiChu});
            this.dataGridView1.Location = new System.Drawing.Point(0, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 472);
            this.dataGridView1.TabIndex = 0;
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
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.Width = 50;
            // 
            // ID_Ghe
            // 
            this.ID_Ghe.HeaderText = "ID Ghế";
            this.ID_Ghe.Name = "ID_Ghe";
            // 
            // ID_Chuyen
            // 
            this.ID_Chuyen.HeaderText = "ID Chuyến";
            this.ID_Chuyen.Name = "ID_Chuyen";
            // 
            // ID_KH
            // 
            this.ID_KH.HeaderText = "ID Khách hàng";
            this.ID_KH.Name = "ID_KH";
            // 
            // TInhTrang
            // 
            this.TInhTrang.HeaderText = "Tình Trạng";
            this.TInhTrang.Name = "TInhTrang";
            // 
            // gia
            // 
            this.gia.HeaderText = "Giá tiền";
            this.gia.Name = "gia";
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
            // 
            // frmVeBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 510);
            this.Controls.Add(this.panel_navbar_title);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmVeBan";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmVeBan";
            this.Load += new System.EventHandler(this.frmBanVe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel_navbar_title.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer_open;
        private System.Windows.Forms.Timer timer_close;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel_navbar_title;
        private UserController.ctr_navbar_title ctr_navbar_title;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Ghe;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Chuyen;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_KH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TInhTrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayXuatVe;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghiChu;
    }
}