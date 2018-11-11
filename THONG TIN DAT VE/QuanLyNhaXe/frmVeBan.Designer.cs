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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ctr_navbar1 = new UserController.ctr_navbar();
            this.btn_menu_1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.dataGridView1.Location = new System.Drawing.Point(0, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(730, 305);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ctr_navbar1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 40);
            this.panel1.TabIndex = 1;
            // 
            // ctr_navbar1
            // 
            this.ctr_navbar1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ctr_navbar1.Location = new System.Drawing.Point(0, 0);
            this.ctr_navbar1.Name = "ctr_navbar1";
            this.ctr_navbar1.Size = new System.Drawing.Size(800, 40);
            this.ctr_navbar1.TabIndex = 0;
            // 
            // btn_menu_1
            // 
            this.btn_menu_1.Location = new System.Drawing.Point(156, 47);
            this.btn_menu_1.Name = "btn_menu_1";
            this.btn_menu_1.Size = new System.Drawing.Size(75, 23);
            this.btn_menu_1.TabIndex = 2;
            this.btn_menu_1.Text = "open dat ve";
            this.btn_menu_1.UseVisualStyleBackColor = true;
            this.btn_menu_1.Click += new System.EventHandler(this.btn_menu_1_Click);
            // 
            // frmVeBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 470);
            this.Controls.Add(this.btn_menu_1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmVeBan";
            this.Opacity = 0D;
            this.Text = "frmVeBan";
            this.Load += new System.EventHandler(this.frmBanVe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer_open;
        private System.Windows.Forms.Timer timer_close;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private UserController.ctr_navbar ctr_navbar1;
        private System.Windows.Forms.Button btn_menu_1;
    }
}