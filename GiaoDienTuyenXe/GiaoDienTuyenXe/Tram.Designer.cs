namespace GiaoDienTuyenXe
{
    partial class Tram
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbDiaDiem = new System.Windows.Forms.ComboBox();
            this.cbIdTram = new System.Windows.Forms.ComboBox();
            this.cbTenTram = new System.Windows.Forms.ComboBox();
            this.dgrv_Tram = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.ID_Tram = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTram = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dia_diem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrv_Tram)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(-1, -4);
            this.groupBox1.MaximumSize = new System.Drawing.Size(803, 93);
            this.groupBox1.MinimumSize = new System.Drawing.Size(803, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(803, 93);
            this.groupBox1.TabIndex = 64;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::GiaoDienTuyenXe.Properties.Resources.download1;
            this.pictureBox1.Location = new System.Drawing.Point(573, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(66, 56);
            this.pictureBox1.TabIndex = 49;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Courier New", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(265, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 41);
            this.label1.TabIndex = 48;
            this.label1.Text = "Quản lý trạm";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox2.Controls.Add(this.cbDiaDiem);
            this.groupBox2.Controls.Add(this.cbIdTram);
            this.groupBox2.Controls.Add(this.cbTenTram);
            this.groupBox2.Controls.Add(this.dgrv_Tram);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnSua);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(-1, 95);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(799, 360);
            this.groupBox2.TabIndex = 65;
            this.groupBox2.TabStop = false;
            // 
            // cbDiaDiem
            // 
            this.cbDiaDiem.FormattingEnabled = true;
            this.cbDiaDiem.Location = new System.Drawing.Point(485, 29);
            this.cbDiaDiem.Name = "cbDiaDiem";
            this.cbDiaDiem.Size = new System.Drawing.Size(304, 29);
            this.cbDiaDiem.TabIndex = 66;
            this.cbDiaDiem.SelectedIndexChanged += new System.EventHandler(this.cbDiaDiem_SelectedIndexChanged);
            // 
            // cbIdTram
            // 
            this.cbIdTram.FormattingEnabled = true;
            this.cbIdTram.Location = new System.Drawing.Point(13, 60);
            this.cbIdTram.Name = "cbIdTram";
            this.cbIdTram.Size = new System.Drawing.Size(49, 29);
            this.cbIdTram.TabIndex = 65;
            // 
            // cbTenTram
            // 
            this.cbTenTram.FormattingEnabled = true;
            this.cbTenTram.Location = new System.Drawing.Point(134, 28);
            this.cbTenTram.Name = "cbTenTram";
            this.cbTenTram.Size = new System.Drawing.Size(188, 29);
            this.cbTenTram.TabIndex = 65;
            this.cbTenTram.SelectedIndexChanged += new System.EventHandler(this.cbTenTram_SelectedIndexChanged);
            // 
            // dgrv_Tram
            // 
            this.dgrv_Tram.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgrv_Tram.BackgroundColor = System.Drawing.Color.White;
            this.dgrv_Tram.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgrv_Tram.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgrv_Tram.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrv_Tram.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Tram,
            this.TenTram,
            this.Dia_diem});
            this.dgrv_Tram.GridColor = System.Drawing.Color.White;
            this.dgrv_Tram.Location = new System.Drawing.Point(-4, 144);
            this.dgrv_Tram.MultiSelect = false;
            this.dgrv_Tram.Name = "dgrv_Tram";
            this.dgrv_Tram.Size = new System.Drawing.Size(802, 216);
            this.dgrv_Tram.TabIndex = 64;
            this.dgrv_Tram.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrv_Tram_CellClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label7.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(13, 29);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(3);
            this.label7.Size = new System.Drawing.Size(115, 27);
            this.label7.TabIndex = 59;
            this.label7.Text = "Tên trạm:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label6.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(364, 28);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(3);
            this.label6.Size = new System.Drawing.Size(115, 27);
            this.label6.TabIndex = 58;
            this.label6.Text = "Địa điểm:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnXoa.ImageIndex = 3;
            this.btnXoa.Location = new System.Drawing.Point(336, 93);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnXoa.Size = new System.Drawing.Size(114, 34);
            this.btnXoa.TabIndex = 57;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.ImageIndex = 2;
            this.btnSua.Location = new System.Drawing.Point(473, 93);
            this.btnSua.Name = "btnSua";
            this.btnSua.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSua.Size = new System.Drawing.Size(114, 34);
            this.btnSua.TabIndex = 56;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.ImageIndex = 1;
            this.btnThem.Location = new System.Drawing.Point(202, 93);
            this.btnThem.Name = "btnThem";
            this.btnThem.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnThem.Size = new System.Drawing.Size(114, 34);
            this.btnThem.TabIndex = 55;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // ID_Tram
            // 
            this.ID_Tram.Frozen = true;
            this.ID_Tram.HeaderText = "Trạm";
            this.ID_Tram.Name = "ID_Tram";
            this.ID_Tram.Width = 55;
            // 
            // TenTram
            // 
            this.TenTram.HeaderText = "Tên Trạm";
            this.TenTram.Name = "TenTram";
            this.TenTram.Width = 250;
            // 
            // Dia_diem
            // 
            this.Dia_diem.HeaderText = "Địa điểm";
            this.Dia_diem.Name = "Dia_diem";
            this.Dia_diem.Width = 450;
            // 
            // Tram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Tram";
            this.Text = "Tram";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Tram_FormClosed);
            this.Load += new System.EventHandler(this.Tram_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrv_Tram)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbIdTram;
        private System.Windows.Forms.ComboBox cbTenTram;
        private System.Windows.Forms.DataGridView dgrv_Tram;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ComboBox cbDiaDiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Tram;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTram;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dia_diem;
    }
}