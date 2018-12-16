namespace LTUDQL1_ADONET
{
    partial class FrmKhachHang
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colCustID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colContactName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCompanyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbnthem = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.tbnsua = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCustID,
            this.colContactName,
            this.colCompanyName});
            this.dataGridView1.Location = new System.Drawing.Point(5, 10);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(523, 243);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.VirtualMode = true;
            // 
            // colCustID
            // 
            this.colCustID.DataPropertyName = "CustomerID";
            this.colCustID.Frozen = true;
            this.colCustID.HeaderText = "ID Khách hàng";
            this.colCustID.Name = "colCustID";
            this.colCustID.ReadOnly = true;
            // 
            // colContactName
            // 
            this.colContactName.DataPropertyName = "ContactName";
            this.colContactName.HeaderText = "Tên KH";
            this.colContactName.Name = "colContactName";
            // 
            // colCompanyName
            // 
            this.colCompanyName.DataPropertyName = "CompanyName";
            this.colCompanyName.HeaderText = "Công ty";
            this.colCompanyName.Name = "colCompanyName";
            // 
            // tbnthem
            // 
            this.tbnthem.Location = new System.Drawing.Point(12, 271);
            this.tbnthem.Name = "tbnthem";
            this.tbnthem.Size = new System.Drawing.Size(75, 23);
            this.tbnthem.TabIndex = 1;
            this.tbnthem.Text = "Thêm";
            this.tbnthem.UseVisualStyleBackColor = true;
            this.tbnthem.Click += new System.EventHandler(this.tbnthem_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(208, 271);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 23);
            this.btnxoa.TabIndex = 2;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.tbnxoa_Click);
            // 
            // tbnsua
            // 
            this.tbnsua.Location = new System.Drawing.Point(406, 271);
            this.tbnsua.Name = "tbnsua";
            this.tbnsua.Size = new System.Drawing.Size(75, 23);
            this.tbnsua.TabIndex = 3;
            this.tbnsua.Text = "Sửa";
            this.tbnsua.UseVisualStyleBackColor = true;
            this.tbnsua.Click += new System.EventHandler(this.tbnsua_Click);
            // 
            // FrmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 314);
            this.Controls.Add(this.tbnsua);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.tbnthem);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmKhachHang";
            this.Text = "Khách hàng";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colContactName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCompanyName;
        private System.Windows.Forms.Button tbnthem;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button tbnsua;
    }
}

