﻿namespace QuanLyNhaXe
{
    partial class frmXe
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
            this.dgvXe = new System.Windows.Forms.DataGridView();
            this.grXe = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXe)).BeginInit();
            this.grXe.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvXe
            // 
            this.dgvXe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvXe.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvXe.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvXe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvXe.Location = new System.Drawing.Point(1, 88);
            this.dgvXe.Margin = new System.Windows.Forms.Padding(2);
            this.dgvXe.Name = "dgvXe";
            this.dgvXe.RowTemplate.Height = 24;
            this.dgvXe.Size = new System.Drawing.Size(585, 284);
            this.dgvXe.TabIndex = 0;
            // 
            // grXe
            // 
            this.grXe.BackColor = System.Drawing.SystemColors.Control;
            this.grXe.Controls.Add(this.label1);
            this.grXe.Location = new System.Drawing.Point(1, 1);
            this.grXe.Margin = new System.Windows.Forms.Padding(2);
            this.grXe.Name = "grXe";
            this.grXe.Padding = new System.Windows.Forms.Padding(2);
            this.grXe.Size = new System.Drawing.Size(585, 81);
            this.grXe.TabIndex = 1;
            this.grXe.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(98)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(195, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông Tin Xe";
            // 
            // frmXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 368);
            this.Controls.Add(this.grXe);
            this.Controls.Add(this.dgvXe);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmXe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xe";
            this.Load += new System.EventHandler(this.frmXe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvXe)).EndInit();
            this.grXe.ResumeLayout(false);
            this.grXe.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvXe;
        private System.Windows.Forms.GroupBox grXe;
        private System.Windows.Forms.Label label1;
    }
}