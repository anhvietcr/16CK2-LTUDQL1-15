namespace QuanLyNhaXe
{
    partial class frmIUChuyen
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
            this.btUpdate = new System.Windows.Forms.Button();
            this.lbID_Chuyen = new System.Windows.Forms.Label();
            this.tbID_Chuyen = new System.Windows.Forms.TextBox();
            this.lbXe = new System.Windows.Forms.Label();
            this.tbIDXe = new System.Windows.Forms.TextBox();
            this.lbID_Tuyen = new System.Windows.Forms.Label();
            this.tbIDTuyen = new System.Windows.Forms.TextBox();
            this.lbID_TaiXe = new System.Windows.Forms.Label();
            this.tbIDTaiXe = new System.Windows.Forms.TextBox();
            this.lbNKH = new System.Windows.Forms.Label();
            this.lbGhichu = new System.Windows.Forms.Label();
            this.dtpNKH = new System.Windows.Forms.DateTimePicker();
            this.tbGhichu = new System.Windows.Forms.TextBox();
            this.btInsert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btUpdate
            // 
            this.btUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.btUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.btUpdate.Location = new System.Drawing.Point(247, 322);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(112, 29);
            this.btUpdate.TabIndex = 0;
            this.btUpdate.Text = "Update";
            this.btUpdate.UseVisualStyleBackColor = false;
            this.btUpdate.Visible = false;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // lbID_Chuyen
            // 
            this.lbID_Chuyen.AutoSize = true;
            this.lbID_Chuyen.Location = new System.Drawing.Point(39, 53);
            this.lbID_Chuyen.Name = "lbID_Chuyen";
            this.lbID_Chuyen.Size = new System.Drawing.Size(77, 17);
            this.lbID_Chuyen.TabIndex = 1;
            this.lbID_Chuyen.Text = "ID_Chuyen";
            // 
            // tbID_Chuyen
            // 
            this.tbID_Chuyen.Location = new System.Drawing.Point(148, 48);
            this.tbID_Chuyen.Name = "tbID_Chuyen";
            this.tbID_Chuyen.Size = new System.Drawing.Size(130, 22);
            this.tbID_Chuyen.TabIndex = 2;
            this.tbID_Chuyen.TextChanged += new System.EventHandler(this.tbID_Chuyen_TextChanged);
            // 
            // lbXe
            // 
            this.lbXe.AutoSize = true;
            this.lbXe.Location = new System.Drawing.Point(382, 53);
            this.lbXe.Name = "lbXe";
            this.lbXe.Size = new System.Drawing.Size(46, 17);
            this.lbXe.TabIndex = 1;
            this.lbXe.Text = "ID_Xe";
            // 
            // tbIDXe
            // 
            this.tbIDXe.Location = new System.Drawing.Point(460, 48);
            this.tbIDXe.Name = "tbIDXe";
            this.tbIDXe.Size = new System.Drawing.Size(130, 22);
            this.tbIDXe.TabIndex = 2;
            this.tbIDXe.TextChanged += new System.EventHandler(this.tbIDXe_TextChanged);
            // 
            // lbID_Tuyen
            // 
            this.lbID_Tuyen.AutoSize = true;
            this.lbID_Tuyen.Location = new System.Drawing.Point(39, 101);
            this.lbID_Tuyen.Name = "lbID_Tuyen";
            this.lbID_Tuyen.Size = new System.Drawing.Size(69, 17);
            this.lbID_Tuyen.TabIndex = 1;
            this.lbID_Tuyen.Text = "ID_Tuyen";
            // 
            // tbIDTuyen
            // 
            this.tbIDTuyen.Location = new System.Drawing.Point(148, 96);
            this.tbIDTuyen.Name = "tbIDTuyen";
            this.tbIDTuyen.Size = new System.Drawing.Size(130, 22);
            this.tbIDTuyen.TabIndex = 2;
            this.tbIDTuyen.TextChanged += new System.EventHandler(this.tbIDTuyen_TextChanged);
            // 
            // lbID_TaiXe
            // 
            this.lbID_TaiXe.AutoSize = true;
            this.lbID_TaiXe.Location = new System.Drawing.Point(382, 101);
            this.lbID_TaiXe.Name = "lbID_TaiXe";
            this.lbID_TaiXe.Size = new System.Drawing.Size(66, 17);
            this.lbID_TaiXe.TabIndex = 1;
            this.lbID_TaiXe.Text = "ID_TaiXe";
            // 
            // tbIDTaiXe
            // 
            this.tbIDTaiXe.Location = new System.Drawing.Point(460, 96);
            this.tbIDTaiXe.Name = "tbIDTaiXe";
            this.tbIDTaiXe.Size = new System.Drawing.Size(130, 22);
            this.tbIDTaiXe.TabIndex = 2;
            this.tbIDTaiXe.TextChanged += new System.EventHandler(this.tbIDTaiXe_TextChanged);
            // 
            // lbNKH
            // 
            this.lbNKH.AutoSize = true;
            this.lbNKH.Location = new System.Drawing.Point(38, 151);
            this.lbNKH.Name = "lbNKH";
            this.lbNKH.Size = new System.Drawing.Size(103, 17);
            this.lbNKH.TabIndex = 1;
            this.lbNKH.Text = "NgayKhoiHanh";
            // 
            // lbGhichu
            // 
            this.lbGhichu.AutoSize = true;
            this.lbGhichu.Location = new System.Drawing.Point(24, 232);
            this.lbGhichu.Name = "lbGhichu";
            this.lbGhichu.Size = new System.Drawing.Size(59, 17);
            this.lbGhichu.TabIndex = 1;
            this.lbGhichu.Text = "Ghi Chu";
            // 
            // dtpNKH
            // 
            this.dtpNKH.Location = new System.Drawing.Point(178, 146);
            this.dtpNKH.Name = "dtpNKH";
            this.dtpNKH.Size = new System.Drawing.Size(311, 22);
            this.dtpNKH.TabIndex = 3;
            this.dtpNKH.ValueChanged += new System.EventHandler(this.dtpNKH_ValueChanged);
            // 
            // tbGhichu
            // 
            this.tbGhichu.Location = new System.Drawing.Point(148, 189);
            this.tbGhichu.Multiline = true;
            this.tbGhichu.Name = "tbGhichu";
            this.tbGhichu.Size = new System.Drawing.Size(387, 108);
            this.tbGhichu.TabIndex = 2;
            this.tbGhichu.TextChanged += new System.EventHandler(this.tbGhichu_TextChanged);
            // 
            // btInsert
            // 
            this.btInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.btInsert.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.btInsert.Location = new System.Drawing.Point(247, 322);
            this.btInsert.Name = "btInsert";
            this.btInsert.Size = new System.Drawing.Size(112, 29);
            this.btInsert.TabIndex = 0;
            this.btInsert.Text = "Insert";
            this.btInsert.UseVisualStyleBackColor = false;
            this.btInsert.Visible = false;
            this.btInsert.Click += new System.EventHandler(this.btInsert_Click);
            // 
            // frmIUChuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(245)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(648, 363);
            this.Controls.Add(this.dtpNKH);
            this.Controls.Add(this.lbGhichu);
            this.Controls.Add(this.tbIDTaiXe);
            this.Controls.Add(this.lbID_TaiXe);
            this.Controls.Add(this.tbIDXe);
            this.Controls.Add(this.tbGhichu);
            this.Controls.Add(this.tbIDTuyen);
            this.Controls.Add(this.lbNKH);
            this.Controls.Add(this.lbXe);
            this.Controls.Add(this.lbID_Tuyen);
            this.Controls.Add(this.tbID_Chuyen);
            this.Controls.Add(this.lbID_Chuyen);
            this.Controls.Add(this.btInsert);
            this.Controls.Add(this.btUpdate);
            this.Name = "frmIUChuyen";
            this.Text = "Chuyen";
            this.Load += new System.EventHandler(this.frmIUChuyen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Label lbID_Chuyen;
        private System.Windows.Forms.TextBox tbID_Chuyen;
        private System.Windows.Forms.Label lbXe;
        private System.Windows.Forms.TextBox tbIDXe;
        private System.Windows.Forms.Label lbID_Tuyen;
        private System.Windows.Forms.TextBox tbIDTuyen;
        private System.Windows.Forms.Label lbID_TaiXe;
        private System.Windows.Forms.TextBox tbIDTaiXe;
        private System.Windows.Forms.Label lbNKH;
        private System.Windows.Forms.Label lbGhichu;
        private System.Windows.Forms.DateTimePicker dtpNKH;
        private System.Windows.Forms.TextBox tbGhichu;
        private System.Windows.Forms.Button btInsert;
    }
}