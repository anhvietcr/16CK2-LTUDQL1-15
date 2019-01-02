namespace Report
{
    partial class Form1
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
            this.crvQLCX.Name = "crvQLCX";
            this.crvQLCX.Size = new System.Drawing.Size(800, 450);
            this.crvQLCX.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crvQLCX);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvQLCX;
    }
}

