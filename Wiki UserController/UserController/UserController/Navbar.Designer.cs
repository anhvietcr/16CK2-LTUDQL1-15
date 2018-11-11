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
            this.iconNavbar = new System.Windows.Forms.ImageList(this.components);
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_toggle_menu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // iconNavbar
            // 
            this.iconNavbar.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iconNavbar.ImageStream")));
            this.iconNavbar.TransparentColor = System.Drawing.Color.Transparent;
            this.iconNavbar.Images.SetKeyName(0, "icons8_Cancel_32px_2.png");
            this.iconNavbar.Images.SetKeyName(1, "icons8_Cancel_50px.png");
            this.iconNavbar.Images.SetKeyName(2, "icons8_Menu_45px_9.png");
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.Transparent;
            this.btn_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_close.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.ImageIndex = 0;
            this.btn_close.ImageList = this.iconNavbar;
            this.btn_close.Location = new System.Drawing.Point(765, 3);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(32, 32);
            this.btn_close.TabIndex = 0;
            this.btn_close.UseVisualStyleBackColor = false;
            // 
            // btn_toggle_menu
            // 
            this.btn_toggle_menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_toggle_menu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_toggle_menu.FlatAppearance.BorderSize = 0;
            this.btn_toggle_menu.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_toggle_menu.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_toggle_menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_toggle_menu.ImageIndex = 2;
            this.btn_toggle_menu.ImageList = this.iconNavbar;
            this.btn_toggle_menu.Location = new System.Drawing.Point(18, 3);
            this.btn_toggle_menu.Name = "btn_toggle_menu";
            this.btn_toggle_menu.Size = new System.Drawing.Size(45, 34);
            this.btn_toggle_menu.TabIndex = 1;
            this.btn_toggle_menu.UseVisualStyleBackColor = true;
            // 
            // ctr_navbar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_toggle_menu);
            this.Name = "ctr_navbar";
            this.Size = new System.Drawing.Size(800, 40);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList iconNavbar;
        public System.Windows.Forms.Button btn_close;
        public System.Windows.Forms.Button btn_toggle_menu;
    }
}
