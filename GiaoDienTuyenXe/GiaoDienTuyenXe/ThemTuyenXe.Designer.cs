namespace GiaoDienTuyenXe
{
    partial class ThemTuyenXe
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTaoTram = new System.Windows.Forms.Button();
            this.txtDiaDiem = new System.Windows.Forms.TextBox();
            this.txtTenTram = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Id_Tram = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTaoTuyen = new System.Windows.Forms.Button();
            this.cbIdTramDi = new System.Windows.Forms.ComboBox();
            this.cbIdTramDen = new System.Windows.Forms.ComboBox();
            this.cbTramDi = new System.Windows.Forms.ComboBox();
            this.cbTramDen = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTGChay = new System.Windows.Forms.TextBox();
            this.txtKhoangCach = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbTramIdTram = new System.Windows.Forms.ComboBox();
            this.btn_TaoTramTrungGian = new System.Windows.Forms.Button();
            this.cbTenTram = new System.Windows.Forms.ComboBox();
            this.cbTuyenIdTuyen = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ID_Tuyen = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTaoTram);
            this.groupBox1.Controls.Add(this.txtDiaDiem);
            this.groupBox1.Controls.Add(this.txtTenTram);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Id_Tram);
            this.groupBox1.Location = new System.Drawing.Point(12, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 200);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thêm tên trạm";
            // 
            // btnTaoTram
            // 
            this.btnTaoTram.Location = new System.Drawing.Point(260, 65);
            this.btnTaoTram.Name = "btnTaoTram";
            this.btnTaoTram.Size = new System.Drawing.Size(75, 23);
            this.btnTaoTram.TabIndex = 4;
            this.btnTaoTram.Text = "Tạo";
            this.btnTaoTram.UseVisualStyleBackColor = true;
            this.btnTaoTram.Click += new System.EventHandler(this.btnTaoTram_Click);
            // 
            // txtDiaDiem
            // 
            this.txtDiaDiem.Location = new System.Drawing.Point(127, 102);
            this.txtDiaDiem.Name = "txtDiaDiem";
            this.txtDiaDiem.Size = new System.Drawing.Size(121, 20);
            this.txtDiaDiem.TabIndex = 3;
            // 
            // txtTenTram
            // 
            this.txtTenTram.Location = new System.Drawing.Point(127, 27);
            this.txtTenTram.Name = "txtTenTram";
            this.txtTenTram.Size = new System.Drawing.Size(121, 20);
            this.txtTenTram.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Địa điểm";
            // 
            // Id_Tram
            // 
            this.Id_Tram.AutoSize = true;
            this.Id_Tram.Location = new System.Drawing.Point(31, 34);
            this.Id_Tram.Name = "Id_Tram";
            this.Id_Tram.Size = new System.Drawing.Size(49, 13);
            this.Id_Tram.TabIndex = 0;
            this.Id_Tram.Text = "Tên trạm";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnTaoTuyen);
            this.groupBox2.Controls.Add(this.cbIdTramDi);
            this.groupBox2.Controls.Add(this.cbIdTramDen);
            this.groupBox2.Controls.Add(this.cbTramDi);
            this.groupBox2.Controls.Add(this.cbTramDen);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtTGChay);
            this.groupBox2.Controls.Add(this.txtKhoangCach);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(46, 249);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(658, 198);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thêm tên tuyến";
            // 
            // btnTaoTuyen
            // 
            this.btnTaoTuyen.Location = new System.Drawing.Point(276, 130);
            this.btnTaoTuyen.Name = "btnTaoTuyen";
            this.btnTaoTuyen.Size = new System.Drawing.Size(75, 23);
            this.btnTaoTuyen.TabIndex = 12;
            this.btnTaoTuyen.Text = "Tạo";
            this.btnTaoTuyen.UseVisualStyleBackColor = true;
            this.btnTaoTuyen.Click += new System.EventHandler(this.btnTaoTuyen_Click);
            // 
            // cbIdTramDi
            // 
            this.cbIdTramDi.FormattingEnabled = true;
            this.cbIdTramDi.Location = new System.Drawing.Point(585, 32);
            this.cbIdTramDi.Name = "cbIdTramDi";
            this.cbIdTramDi.Size = new System.Drawing.Size(32, 21);
            this.cbIdTramDi.TabIndex = 11;
            this.cbIdTramDi.Visible = false;
            // 
            // cbIdTramDen
            // 
            this.cbIdTramDen.FormattingEnabled = true;
            this.cbIdTramDen.Location = new System.Drawing.Point(585, 94);
            this.cbIdTramDen.Name = "cbIdTramDen";
            this.cbIdTramDen.Size = new System.Drawing.Size(33, 21);
            this.cbIdTramDen.TabIndex = 10;
            this.cbIdTramDen.Visible = false;
            // 
            // cbTramDi
            // 
            this.cbTramDi.FormattingEnabled = true;
            this.cbTramDi.Location = new System.Drawing.Point(438, 32);
            this.cbTramDi.Name = "cbTramDi";
            this.cbTramDi.Size = new System.Drawing.Size(121, 21);
            this.cbTramDi.TabIndex = 8;
            this.cbTramDi.SelectedIndexChanged += new System.EventHandler(this.cbTramDi_SelectedIndexChanged);
            // 
            // cbTramDen
            // 
            this.cbTramDen.FormattingEnabled = true;
            this.cbTramDen.Location = new System.Drawing.Point(438, 91);
            this.cbTramDen.Name = "cbTramDen";
            this.cbTramDen.Size = new System.Drawing.Size(121, 21);
            this.cbTramDen.TabIndex = 7;
            this.cbTramDen.SelectedIndexChanged += new System.EventHandler(this.cbTramDen_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(345, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Trạm Đến";
            // 
            // txtTGChay
            // 
            this.txtTGChay.Location = new System.Drawing.Point(185, 87);
            this.txtTGChay.Name = "txtTGChay";
            this.txtTGChay.Size = new System.Drawing.Size(121, 20);
            this.txtTGChay.TabIndex = 4;
            // 
            // txtKhoangCach
            // 
            this.txtKhoangCach.Location = new System.Drawing.Point(185, 35);
            this.txtKhoangCach.Name = "txtKhoangCach";
            this.txtKhoangCach.Size = new System.Drawing.Size(121, 20);
            this.txtKhoangCach.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(345, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Trạm Đi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Thời Gian Chạy";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Khoảng Cách";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbTramIdTram);
            this.groupBox3.Controls.Add(this.btn_TaoTramTrungGian);
            this.groupBox3.Controls.Add(this.cbTenTram);
            this.groupBox3.Controls.Add(this.cbTuyenIdTuyen);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.ID_Tuyen);
            this.groupBox3.Location = new System.Drawing.Point(416, 43);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(343, 200);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thêm trạm trung gian";
            // 
            // cbTramIdTram
            // 
            this.cbTramIdTram.FormattingEnabled = true;
            this.cbTramIdTram.Location = new System.Drawing.Point(282, 94);
            this.cbTramIdTram.Name = "cbTramIdTram";
            this.cbTramIdTram.Size = new System.Drawing.Size(32, 21);
            this.cbTramIdTram.TabIndex = 6;
            this.cbTramIdTram.Visible = false;
            // 
            // btn_TaoTramTrungGian
            // 
            this.btn_TaoTramTrungGian.Location = new System.Drawing.Point(150, 149);
            this.btn_TaoTramTrungGian.Name = "btn_TaoTramTrungGian";
            this.btn_TaoTramTrungGian.Size = new System.Drawing.Size(75, 23);
            this.btn_TaoTramTrungGian.TabIndex = 5;
            this.btn_TaoTramTrungGian.Text = "Tạo";
            this.btn_TaoTramTrungGian.UseVisualStyleBackColor = true;
            this.btn_TaoTramTrungGian.Click += new System.EventHandler(this.btn_TaoTramTrungGian_Click);
            // 
            // cbTenTram
            // 
            this.cbTenTram.FormattingEnabled = true;
            this.cbTenTram.Location = new System.Drawing.Point(127, 94);
            this.cbTenTram.Name = "cbTenTram";
            this.cbTenTram.Size = new System.Drawing.Size(121, 21);
            this.cbTenTram.TabIndex = 4;
            this.cbTenTram.SelectedIndexChanged += new System.EventHandler(this.cbTenTram_SelectedIndexChanged);
            // 
            // cbTuyenIdTuyen
            // 
            this.cbTuyenIdTuyen.FormattingEnabled = true;
            this.cbTuyenIdTuyen.Location = new System.Drawing.Point(127, 26);
            this.cbTuyenIdTuyen.Name = "cbTuyenIdTuyen";
            this.cbTuyenIdTuyen.Size = new System.Drawing.Size(121, 21);
            this.cbTuyenIdTuyen.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Trạm trung gian";
            // 
            // ID_Tuyen
            // 
            this.ID_Tuyen.AutoSize = true;
            this.ID_Tuyen.Location = new System.Drawing.Point(37, 34);
            this.ID_Tuyen.Name = "ID_Tuyen";
            this.ID_Tuyen.Size = new System.Drawing.Size(54, 13);
            this.ID_Tuyen.TabIndex = 0;
            this.ID_Tuyen.Text = "ID_Tuyen";
            // 
            // ThemTuyenXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 465);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ThemTuyenXe";
            this.Text = "ThemTuyenXe";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ThemTuyenXe_FormClosed);
            this.Load += new System.EventHandler(this.ThemTuyenXe_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label Id_Tram;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTGChay;
        private System.Windows.Forms.TextBox txtKhoangCach;
        private System.Windows.Forms.TextBox txtDiaDiem;
        private System.Windows.Forms.TextBox txtTenTram;
        private System.Windows.Forms.ComboBox cbTramDi;
        private System.Windows.Forms.ComboBox cbTramDen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnTaoTram;
        private System.Windows.Forms.Button btnTaoTuyen;
        private System.Windows.Forms.ComboBox cbIdTramDi;
        private System.Windows.Forms.ComboBox cbIdTramDen;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbTuyenIdTuyen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label ID_Tuyen;
        private System.Windows.Forms.Button btn_TaoTramTrungGian;
        private System.Windows.Forms.ComboBox cbTenTram;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox cbTramIdTram;
    }
}