﻿namespace QuanLyNhaXe
{
    partial class frmKhachhang
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
            System.Windows.Forms.GroupBox groupBox1;
            System.Windows.Forms.Label label8;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKhachhang));
            System.Windows.Forms.Label label9;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Button btnsua;
            System.Windows.Forms.Button btnxoa;
            System.Windows.Forms.Button btnthem;
            System.Windows.Forms.GroupBox groupBox3;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.TextBox txttimkiem;
            this.txtloai = new System.Windows.Forms.TextBox();
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.txtten = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtma = new System.Windows.Forms.TextBox();
            this.dgrv_kh = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ctr_navbar1 = new UserController.ctr_navbar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ctr_menu1 = new UserController.ctr_menu();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            groupBox1 = new System.Windows.Forms.GroupBox();
            label8 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            btnsua = new System.Windows.Forms.Button();
            btnxoa = new System.Windows.Forms.Button();
            btnthem = new System.Windows.Forms.Button();
            groupBox3 = new System.Windows.Forms.GroupBox();
            label3 = new System.Windows.Forms.Label();
            txttimkiem = new System.Windows.Forms.TextBox();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrv_kh)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = System.Drawing.Color.Transparent;
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(this.txtloai);
            groupBox1.Controls.Add(this.txtsdt);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(this.txtten);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(this.txtemail);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(this.txtma);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(btnsua);
            groupBox1.Controls.Add(btnxoa);
            groupBox1.Controls.Add(btnthem);
            resources.ApplyResources(groupBox1, "groupBox1");
            groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            groupBox1.Name = "groupBox1";
            groupBox1.TabStop = false;
            // 
            // label8
            // 
            resources.ApplyResources(label8, "label8");
            label8.Name = "label8";
            // 
            // txtloai
            // 
            resources.ApplyResources(this.txtloai, "txtloai");
            this.txtloai.Name = "txtloai";
            // 
            // txtsdt
            // 
            resources.ApplyResources(this.txtsdt, "txtsdt");
            this.txtsdt.Name = "txtsdt";
            // 
            // label9
            // 
            resources.ApplyResources(label9, "label9");
            label9.Name = "label9";
            // 
            // txtten
            // 
            resources.ApplyResources(this.txtten, "txtten");
            this.txtten.Name = "txtten";
            // 
            // label7
            // 
            resources.ApplyResources(label7, "label7");
            label7.Name = "label7";
            // 
            // txtemail
            // 
            resources.ApplyResources(this.txtemail, "txtemail");
            this.txtemail.Name = "txtemail";
            // 
            // label6
            // 
            resources.ApplyResources(label6, "label6");
            label6.Name = "label6";
            // 
            // txtma
            // 
            resources.ApplyResources(this.txtma, "txtma");
            this.txtma.Name = "txtma";
            // 
            // label5
            // 
            resources.ApplyResources(label5, "label5");
            label5.Name = "label5";
            // 
            // btnsua
            // 
            btnsua.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            resources.ApplyResources(btnsua, "btnsua");
            btnsua.Name = "btnsua";
            btnsua.UseVisualStyleBackColor = false;
            btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            btnxoa.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            resources.ApplyResources(btnxoa, "btnxoa");
            btnxoa.ForeColor = System.Drawing.Color.Black;
            btnxoa.Name = "btnxoa";
            btnxoa.UseVisualStyleBackColor = false;
            btnxoa.Click += new System.EventHandler(this.btnxoa_Click_1);
            // 
            // btnthem
            // 
            btnthem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            resources.ApplyResources(btnthem, "btnthem");
            btnthem.Name = "btnthem";
            btnthem.UseVisualStyleBackColor = false;
            btnthem.Click += new System.EventHandler(this.btnthem_Click_1);
            // 
            // groupBox3
            // 
            groupBox3.BackColor = System.Drawing.Color.Transparent;
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(txttimkiem);
            groupBox3.Controls.Add(this.dgrv_kh);
            resources.ApplyResources(groupBox3, "groupBox3");
            groupBox3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            groupBox3.Name = "groupBox3";
            groupBox3.TabStop = false;
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            // 
            // txttimkiem
            // 
            resources.ApplyResources(txttimkiem, "txttimkiem");
            txttimkiem.Name = "txttimkiem";
            // 
            // dgrv_kh
            // 
            this.dgrv_kh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dgrv_kh, "dgrv_kh");
            this.dgrv_kh.Name = "dgrv_kh";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ctr_navbar1);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // ctr_navbar1
            // 
            this.ctr_navbar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            resources.ApplyResources(this.ctr_navbar1, "ctr_navbar1");
            this.ctr_navbar1.Name = "ctr_navbar1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.ctr_menu1);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // groupBox2
            // 
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // ctr_menu1
            // 
            this.ctr_menu1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(245)))), ((int)(((byte)(254)))));
            this.ctr_menu1.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.ctr_menu1, "ctr_menu1");
            this.ctr_menu1.Name = "ctr_menu1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer_open_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer_close_Tick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(groupBox3);
            this.panel3.Controls.Add(groupBox1);
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // frmKhachhang
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmKhachhang";
            this.Opacity = 0D;
            this.Load += new System.EventHandler(this.frmDatVe_Load);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrv_kh)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private UserController.ctr_menu ctr_menu1;
        private UserController.ctr_navbar ctr_navbar1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtloai;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgrv_kh;
        private System.Windows.Forms.TextBox txtsdt;
        private System.Windows.Forms.TextBox txtten;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtma;
    }
}