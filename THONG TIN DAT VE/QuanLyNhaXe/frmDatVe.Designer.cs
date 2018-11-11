namespace QuanLyNhaXe
{
    partial class frmDatVe
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ctr_navbar1 = new UserController.ctr_navbar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ctr_menu1 = new UserController.ctr_menu();
            this.panel3 = new System.Windows.Forms.Panel();
            this.timer_open = new System.Windows.Forms.Timer(this.components);
            this.timer_close = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ctr_navbar1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 40);
            this.panel1.TabIndex = 0;
            // 
            // ctr_navbar1
            // 
            this.ctr_navbar1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ctr_navbar1.Location = new System.Drawing.Point(0, 0);
            this.ctr_navbar1.Name = "ctr_navbar1";
            this.ctr_navbar1.Size = new System.Drawing.Size(800, 40);
            this.ctr_navbar1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ctr_menu1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 470);
            this.panel2.TabIndex = 0;
            // 
            // ctr_menu1
            // 
            this.ctr_menu1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ctr_menu1.ForeColor = System.Drawing.Color.White;
            this.ctr_menu1.Location = new System.Drawing.Point(0, 1);
            this.ctr_menu1.Name = "ctr_menu1";
            this.ctr_menu1.Size = new System.Drawing.Size(200, 470);
            this.ctr_menu1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(200, 40);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(600, 470);
            this.panel3.TabIndex = 0;
            // 
            // timer_open
            // 
            this.timer_open.Tick += new System.EventHandler(this.timer_open_Tick);
            // 
            // timer_close
            // 
            this.timer_close.Tick += new System.EventHandler(this.time_close_Tick);
            // 
            // frmDatVe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 510);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDatVe";
            this.Opacity = 0D;
            this.Text = "DatVe";
            this.Load += new System.EventHandler(this.frmDatVe_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private UserController.ctr_navbar ctr_navbar1;
        private UserController.ctr_menu ctr_menu1;
        private System.Windows.Forms.Timer timer_open;
        private System.Windows.Forms.Timer timer_close;
    }
}