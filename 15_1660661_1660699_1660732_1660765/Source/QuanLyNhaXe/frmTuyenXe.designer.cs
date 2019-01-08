namespace QuanLyNhaXe
{
    partial class frmTuyenXe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTuyenXe));
            this.pnlTop = new System.Windows.Forms.Panel();
            this.ctr_navbar1 = new UserController.ctr_navbar();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.ctr_menu1 = new UserController.ctr_menu();
            this.pnlFill = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTram = new System.Windows.Forms.Button();
            this.cbIDTramDen = new System.Windows.Forms.ComboBox();
            this.cbIDTramDi = new System.Windows.Forms.ComboBox();
            this.cbIdTuyen = new System.Windows.Forms.ComboBox();
            this.cbTramDi = new System.Windows.Forms.ComboBox();
            this.dgrv_TuyenXe = new System.Windows.Forms.DataGridView();
            this.ID_Tuyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KhoangCach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiGianChay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tram_ID_Tram1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tram_ID_Tram = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtThoiGianChay = new System.Windows.Forms.TextBox();
            this.txtKhoangCach = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbTramDen = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.timer_open = new System.Windows.Forms.Timer(this.components);
            this.timer_close = new System.Windows.Forms.Timer(this.components);
            this.pnlTop.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.pnlFill.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrv_TuyenXe)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.ctr_navbar1);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(800, 40);
            this.pnlTop.TabIndex = 0;
            // 
            // ctr_navbar1
            // 
            this.ctr_navbar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.ctr_navbar1.Location = new System.Drawing.Point(0, 0);
            this.ctr_navbar1.Name = "ctr_navbar1";
            this.ctr_navbar1.Size = new System.Drawing.Size(800, 40);
            this.ctr_navbar1.TabIndex = 0;
            // 
            // pnlLeft
            // 
            this.pnlLeft.Controls.Add(this.ctr_menu1);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 40);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(200, 470);
            this.pnlLeft.TabIndex = 1;
            // 
            // ctr_menu1
            // 
            this.ctr_menu1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(245)))), ((int)(((byte)(254)))));
            this.ctr_menu1.ForeColor = System.Drawing.Color.White;
            this.ctr_menu1.Location = new System.Drawing.Point(0, 0);
            this.ctr_menu1.Name = "ctr_menu1";
            this.ctr_menu1.Size = new System.Drawing.Size(200, 470);
            this.ctr_menu1.TabIndex = 0;
            // 
            // pnlFill
            // 
            this.pnlFill.Controls.Add(this.groupBox1);
            this.pnlFill.Controls.Add(this.groupBox2);
            this.pnlFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFill.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlFill.Location = new System.Drawing.Point(200, 40);
            this.pnlFill.Name = "pnlFill";
            this.pnlFill.Size = new System.Drawing.Size(600, 470);
            this.pnlFill.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(594, 64);
            this.groupBox1.TabIndex = 62;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(460, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 57);
            this.pictureBox1.TabIndex = 49;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(123, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 32);
            this.label1.TabIndex = 48;
            this.label1.Text = "Quản lý Tuyến xe";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.btnTram);
            this.groupBox2.Controls.Add(this.cbIDTramDen);
            this.groupBox2.Controls.Add(this.cbIDTramDi);
            this.groupBox2.Controls.Add(this.cbIdTuyen);
            this.groupBox2.Controls.Add(this.cbTramDi);
            this.groupBox2.Controls.Add(this.dgrv_TuyenXe);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnSua);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Controls.Add(this.txtThoiGianChay);
            this.groupBox2.Controls.Add(this.txtKhoangCach);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cbTramDen);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(3, 58);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(593, 409);
            this.groupBox2.TabIndex = 63;
            this.groupBox2.TabStop = false;
            // 
            // btnTram
            // 
            this.btnTram.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnTram.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnTram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTram.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTram.Location = new System.Drawing.Point(440, 25);
            this.btnTram.Name = "btnTram";
            this.btnTram.Size = new System.Drawing.Size(139, 35);
            this.btnTram.TabIndex = 68;
            this.btnTram.Text = "Quản lý Trạm";
            this.btnTram.UseVisualStyleBackColor = false;
            this.btnTram.Click += new System.EventHandler(this.btnTram_Click);
            // 
            // cbIDTramDen
            // 
            this.cbIDTramDen.FormattingEnabled = true;
            this.cbIDTramDen.Location = new System.Drawing.Point(578, 176);
            this.cbIDTramDen.Name = "cbIDTramDen";
            this.cbIDTramDen.Size = new System.Drawing.Size(13, 26);
            this.cbIDTramDen.TabIndex = 67;
            this.cbIDTramDen.Visible = false;
            // 
            // cbIDTramDi
            // 
            this.cbIDTramDi.FormattingEnabled = true;
            this.cbIDTramDi.Location = new System.Drawing.Point(578, 139);
            this.cbIDTramDi.Name = "cbIDTramDi";
            this.cbIDTramDi.Size = new System.Drawing.Size(13, 26);
            this.cbIDTramDi.TabIndex = 66;
            this.cbIDTramDi.Visible = false;
            // 
            // cbIdTuyen
            // 
            this.cbIdTuyen.FormattingEnabled = true;
            this.cbIdTuyen.Location = new System.Drawing.Point(417, 95);
            this.cbIdTuyen.Name = "cbIdTuyen";
            this.cbIdTuyen.Size = new System.Drawing.Size(18, 26);
            this.cbIdTuyen.TabIndex = 65;
            this.cbIdTuyen.Visible = false;
            // 
            // cbTramDi
            // 
            this.cbTramDi.FormattingEnabled = true;
            this.cbTramDi.Location = new System.Drawing.Point(228, 127);
            this.cbTramDi.Name = "cbTramDi";
            this.cbTramDi.Size = new System.Drawing.Size(182, 26);
            this.cbTramDi.TabIndex = 65;
            this.cbTramDi.SelectedIndexChanged += new System.EventHandler(this.cbTramDi_SelectedIndexChanged);
            // 
            // dgrv_TuyenXe
            // 
            this.dgrv_TuyenXe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgrv_TuyenXe.BackgroundColor = System.Drawing.Color.White;
            this.dgrv_TuyenXe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgrv_TuyenXe.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgrv_TuyenXe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrv_TuyenXe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Tuyen,
            this.KhoangCach,
            this.ThoiGianChay,
            this.Tram_ID_Tram1,
            this.Tram_ID_Tram});
            this.dgrv_TuyenXe.GridColor = System.Drawing.Color.White;
            this.dgrv_TuyenXe.Location = new System.Drawing.Point(0, 225);
            this.dgrv_TuyenXe.MultiSelect = false;
            this.dgrv_TuyenXe.Name = "dgrv_TuyenXe";
            this.dgrv_TuyenXe.Size = new System.Drawing.Size(591, 192);
            this.dgrv_TuyenXe.TabIndex = 64;
            this.dgrv_TuyenXe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrv_TuyenXe_CellClick);
            // 
            // ID_Tuyen
            // 
            this.ID_Tuyen.Frozen = true;
            this.ID_Tuyen.HeaderText = "Tuyến";
            this.ID_Tuyen.Name = "ID_Tuyen";
            this.ID_Tuyen.Width = 80;
            // 
            // KhoangCach
            // 
            this.KhoangCach.HeaderText = "Khoảng Cách";
            this.KhoangCach.Name = "KhoangCach";
            this.KhoangCach.Width = 120;
            // 
            // ThoiGianChay
            // 
            this.ThoiGianChay.HeaderText = "Thời Gian";
            this.ThoiGianChay.Name = "ThoiGianChay";
            // 
            // Tram_ID_Tram1
            // 
            this.Tram_ID_Tram1.HeaderText = "Trạm Đi";
            this.Tram_ID_Tram1.Name = "Tram_ID_Tram1";
            this.Tram_ID_Tram1.Width = 120;
            // 
            // Tram_ID_Tram
            // 
            this.Tram_ID_Tram.HeaderText = "Trạm Đến";
            this.Tram_ID_Tram.Name = "Tram_ID_Tram";
            this.Tram_ID_Tram.Width = 120;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label7.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(29, 30);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(3);
            this.label7.Size = new System.Drawing.Size(181, 27);
            this.label7.TabIndex = 59;
            this.label7.Text = "Khoảng cách:   ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label6.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(29, 77);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(3);
            this.label6.Size = new System.Drawing.Size(181, 27);
            this.label6.TabIndex = 58;
            this.label6.Text = "Thời gian chạy:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnXoa.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnXoa.ImageIndex = 3;
            this.btnXoa.ImageList = this.imageList1;
            this.btnXoa.Location = new System.Drawing.Point(445, 118);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnXoa.Size = new System.Drawing.Size(114, 34);
            this.btnXoa.TabIndex = 57;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "download.png");
            this.imageList1.Images.SetKeyName(1, "Car-128.png");
            this.imageList1.Images.SetKeyName(2, "Car-List-128.png");
            this.imageList1.Images.SetKeyName(3, "beach_car-128.png");
            this.imageList1.Images.SetKeyName(4, "Inkcontober_Furious-128.png");
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnSua.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.ImageIndex = 2;
            this.btnSua.ImageList = this.imageList1;
            this.btnSua.Location = new System.Drawing.Point(445, 171);
            this.btnSua.Name = "btnSua";
            this.btnSua.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSua.Size = new System.Drawing.Size(114, 34);
            this.btnSua.TabIndex = 56;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnThem.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.ImageIndex = 1;
            this.btnThem.ImageList = this.imageList1;
            this.btnThem.Location = new System.Drawing.Point(445, 70);
            this.btnThem.Name = "btnThem";
            this.btnThem.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnThem.Size = new System.Drawing.Size(114, 34);
            this.btnThem.TabIndex = 55;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtThoiGianChay
            // 
            this.txtThoiGianChay.Location = new System.Drawing.Point(228, 79);
            this.txtThoiGianChay.Name = "txtThoiGianChay";
            this.txtThoiGianChay.Size = new System.Drawing.Size(82, 26);
            this.txtThoiGianChay.TabIndex = 54;
            // 
            // txtKhoangCach
            // 
            this.txtKhoangCach.Location = new System.Drawing.Point(228, 30);
            this.txtKhoangCach.Name = "txtKhoangCach";
            this.txtKhoangCach.Size = new System.Drawing.Size(82, 26);
            this.txtKhoangCach.TabIndex = 53;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label3.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(29, 179);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(3);
            this.label3.Size = new System.Drawing.Size(181, 27);
            this.label3.TabIndex = 50;
            this.label3.Text = "Điểm đưa đến:  ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbTramDen
            // 
            this.cbTramDen.FormattingEnabled = true;
            this.cbTramDen.Location = new System.Drawing.Point(228, 179);
            this.cbTramDen.Name = "cbTramDen";
            this.cbTramDen.Size = new System.Drawing.Size(182, 26);
            this.cbTramDen.TabIndex = 52;
            this.cbTramDen.SelectedIndexChanged += new System.EventHandler(this.cbTramDen_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label2.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(29, 127);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(3);
            this.label2.Size = new System.Drawing.Size(181, 27);
            this.label2.TabIndex = 49;
            this.label2.Text = "Điểm khởi hành:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer_open
            // 
            this.timer_open.Tick += new System.EventHandler(this.timer_open_Tick);
            // 
            // timer_close
            // 
            this.timer_close.Tick += new System.EventHandler(this.time_close_Tick);
            // 
            // frmTuyenXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 510);
            this.Controls.Add(this.pnlFill);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTuyenXe";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmTuyenXe_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlLeft.ResumeLayout(false);
            this.pnlFill.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrv_TuyenXe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlFill;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer_open;
        private System.Windows.Forms.Timer timer_close;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgrv_TuyenXe;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtThoiGianChay;
        private System.Windows.Forms.TextBox txtKhoangCach;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbTramDen;
        private System.Windows.Forms.Label label2;
        private UserController.ctr_navbar ctr_navbar1;
        private UserController.ctr_menu ctr_menu1;
        private System.Windows.Forms.ComboBox cbTramDi;
        private System.Windows.Forms.ComboBox cbIdTuyen;
        private System.Windows.Forms.ComboBox cbIDTramDen;
        private System.Windows.Forms.ComboBox cbIDTramDi;
        private System.Windows.Forms.Button btnTram;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Tuyen;
        private System.Windows.Forms.DataGridViewTextBoxColumn KhoangCach;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiGianChay;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tram_ID_Tram1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tram_ID_Tram;
    }
}