namespace ReprotQLCX
{
    partial class fm_Reprot
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
            this.crvQLCX = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvQLCX
            // 
            this.crvQLCX.ActiveViewIndex = -1;
            this.crvQLCX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvQLCX.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvQLCX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvQLCX.Location = new System.Drawing.Point(0, 0);
            this.crvQLCX.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.crvQLCX.Name = "crvQLCX";
            this.crvQLCX.Size = new System.Drawing.Size(600, 366);
            this.crvQLCX.TabIndex = 0;
            this.crvQLCX.ToolPanelWidth = 150;
            // 
            // fm_Reprot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.crvQLCX);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "fm_Reprot";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.fm_Reprot_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvQLCX;
    }
}

