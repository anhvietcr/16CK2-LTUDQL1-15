namespace QuanLyNhaXe
{
    partial class frmThemTuyenXe
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbTramIdTram = new System.Windows.Forms.ComboBox();
            this.btn_TaoTramTrungGian = new System.Windows.Forms.Button();
            this.cbTenTram = new System.Windows.Forms.ComboBox();
            this.cbTuyenIdTuyen = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ID_Tuyen = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbTramIdTram);
            this.groupBox3.Controls.Add(this.btn_TaoTramTrungGian);
            this.groupBox3.Controls.Add(this.cbTenTram);
            this.groupBox3.Controls.Add(this.cbTuyenIdTuyen);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.ID_Tuyen);
            this.groupBox3.Location = new System.Drawing.Point(236, 101);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(343, 200);
            this.groupBox3.TabIndex = 3;
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
            // 
            // cbTenTram
            // 
            this.cbTenTram.FormattingEnabled = true;
            this.cbTenTram.Location = new System.Drawing.Point(127, 94);
            this.cbTenTram.Name = "cbTenTram";
            this.cbTenTram.Size = new System.Drawing.Size(121, 21);
            this.cbTenTram.TabIndex = 4;
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
            // frmThemTuyenXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 465);
            this.Controls.Add(this.groupBox3);
            this.Name = "frmThemTuyenXe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThemTuyenXe";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ThemTuyenXe_FormClosed);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbTramIdTram;
        private System.Windows.Forms.Button btn_TaoTramTrungGian;
        private System.Windows.Forms.ComboBox cbTenTram;
        private System.Windows.Forms.ComboBox cbTuyenIdTuyen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label ID_Tuyen;
    }
}