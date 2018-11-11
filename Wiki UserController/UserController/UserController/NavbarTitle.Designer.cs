namespace UserController
{
    partial class ctr_navbar_title
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctr_navbar_title));
            this.imgListNavIcon = new System.Windows.Forms.ImageList(this.components);
            this.btn_close = new System.Windows.Forms.Button();
            this.txt_title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // imgListNavIcon
            // 
            this.imgListNavIcon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgListNavIcon.ImageStream")));
            this.imgListNavIcon.TransparentColor = System.Drawing.Color.Transparent;
            this.imgListNavIcon.Images.SetKeyName(0, "icons8_Cancel_45px.png");
            this.imgListNavIcon.Images.SetKeyName(1, "icons8_Cancel_45px_1.png");
            // 
            // btn_close
            // 
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Mistral", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.ImageIndex = 0;
            this.btn_close.ImageList = this.imgListNavIcon;
            this.btn_close.Location = new System.Drawing.Point(470, 8);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(24, 24);
            this.btn_close.TabIndex = 0;
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.MouseLeave += new System.EventHandler(this.btn_close_MouseLeave);
            this.btn_close.MouseHover += new System.EventHandler(this.btn_close_MouseHover);
            // 
            // txt_title
            // 
            this.txt_title.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_title.AutoSize = true;
            this.txt_title.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.txt_title.Location = new System.Drawing.Point(182, 8);
            this.txt_title.Name = "txt_title";
            this.txt_title.Size = new System.Drawing.Size(168, 24);
            this.txt_title.TabIndex = 1;
            this.txt_title.Text = "Quản Lý Nhà Xe";
            // 
            // ctr_navbar_title
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.Controls.Add(this.txt_title);
            this.Controls.Add(this.btn_close);
            this.Name = "ctr_navbar_title";
            this.Size = new System.Drawing.Size(500, 40);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imgListNavIcon;
        public System.Windows.Forms.Button btn_close;
        public System.Windows.Forms.Label txt_title;
    }
}
