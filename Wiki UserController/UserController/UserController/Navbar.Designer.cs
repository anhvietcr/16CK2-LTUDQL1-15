namespace UserController
{
    partial class ctr_navbar
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctr_navbar));
            this.imgListNavIcon = new System.Windows.Forms.ImageList(this.components);
            this.btn_toggle_menu = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.txt_title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // imgListNavIcon
            // 
            this.imgListNavIcon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgListNavIcon.ImageStream")));
            this.imgListNavIcon.TransparentColor = System.Drawing.Color.Transparent;
            this.imgListNavIcon.Images.SetKeyName(0, "icons8_Xbox_Menu_45px.png");
            this.imgListNavIcon.Images.SetKeyName(1, "icons8_Cancel_45px_1.png");
            this.imgListNavIcon.Images.SetKeyName(2, "icons8_Cancel_45px.png");
            // 
            // btn_toggle_menu
            // 
            this.btn_toggle_menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_toggle_menu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_toggle_menu.FlatAppearance.BorderSize = 0;
            this.btn_toggle_menu.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_toggle_menu.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_toggle_menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_toggle_menu.ImageIndex = 0;
            this.btn_toggle_menu.ImageList = this.imgListNavIcon;
            this.btn_toggle_menu.Location = new System.Drawing.Point(19, 0);
            this.btn_toggle_menu.Name = "btn_toggle_menu";
            this.btn_toggle_menu.Size = new System.Drawing.Size(42, 41);
            this.btn_toggle_menu.TabIndex = 1;
            this.btn_toggle_menu.UseVisualStyleBackColor = true;
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.Transparent;
            this.btn_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_close.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.ImageIndex = 2;
            this.btn_close.ImageList = this.imgListNavIcon;
            this.btn_close.Location = new System.Drawing.Point(771, 8);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(24, 24);
            this.btn_close.TabIndex = 0;
            this.btn_close.UseVisualStyleBackColor = false;
            // 
            // txt_title
            // 
            this.txt_title.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_title.AutoSize = true;
            this.txt_title.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.txt_title.Location = new System.Drawing.Point(380, 8);
            this.txt_title.Name = "txt_title";
            this.txt_title.Size = new System.Drawing.Size(161, 24);
            this.txt_title.TabIndex = 2;
            this.txt_title.Text = "Quản lý Nhà Xe";
            // 
            // ctr_navbar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.Controls.Add(this.txt_title);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_toggle_menu);
            this.Name = "ctr_navbar";
            this.Size = new System.Drawing.Size(800, 40);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ImageList imgListNavIcon;
        public System.Windows.Forms.Button btn_toggle_menu;
        public System.Windows.Forms.Button btn_close;
        public System.Windows.Forms.Label txt_title;
    }
}
