namespace QuanLyCuaHang
{
    partial class TTHDX
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TTHDX));
            this.dgvTimKiem2 = new System.Windows.Forms.DataGridView();
            this.dgvTimKiem1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnXem = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.MaHDXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaHDX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimKiem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimKiem1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTimKiem2
            // 
            this.dgvTimKiem2.AllowUserToAddRows = false;
            this.dgvTimKiem2.AllowUserToDeleteRows = false;
            this.dgvTimKiem2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTimKiem2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHDXuat,
            this.NgayXuat});
            this.dgvTimKiem2.Location = new System.Drawing.Point(35, 19);
            this.dgvTimKiem2.Name = "dgvTimKiem2";
            this.dgvTimKiem2.ReadOnly = true;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvTimKiem2.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTimKiem2.Size = new System.Drawing.Size(824, 147);
            this.dgvTimKiem2.TabIndex = 7;
            this.dgvTimKiem2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTimKiem2_CellClick);
            // 
            // dgvTimKiem1
            // 
            this.dgvTimKiem1.AllowUserToAddRows = false;
            this.dgvTimKiem1.AllowUserToDeleteRows = false;
            this.dgvTimKiem1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvTimKiem1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTimKiem1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHDX,
            this.MaMH,
            this.SoLuongXuat,
            this.GiaXuat});
            this.dgvTimKiem1.Location = new System.Drawing.Point(35, 211);
            this.dgvTimKiem1.Name = "dgvTimKiem1";
            this.dgvTimKiem1.ReadOnly = true;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.dgvTimKiem1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTimKiem1.Size = new System.Drawing.Size(824, 198);
            this.dgvTimKiem1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(36, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 23);
            this.label3.TabIndex = 29;
            this.label3.Text = "Hóa đơn xuất hàng";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(189)))), ((int)(((byte)(175)))));
            this.groupBox1.Controls.Add(this.btnXem);
            this.groupBox1.Controls.Add(this.dgvTimKiem2);
            this.groupBox1.Controls.Add(this.dgvTimKiem1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(40, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(888, 442);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hóa đơn";
            // 
            // btnXem
            // 
            this.btnXem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(139)))), ((int)(((byte)(95)))));
            this.btnXem.Location = new System.Drawing.Point(747, 175);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(104, 30);
            this.btnXem.TabIndex = 8;
            this.btnXem.Text = "Xem Chi tiết";
            this.btnXem.UseVisualStyleBackColor = false;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(139)))), ((int)(((byte)(95)))));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(864, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 30);
            this.button1.TabIndex = 30;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MaHDXuat
            // 
            this.MaHDXuat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaHDXuat.DataPropertyName = "MaHDXuat";
            this.MaHDXuat.HeaderText = "Mã hóa đơn xuất hàng";
            this.MaHDXuat.Name = "MaHDXuat";
            this.MaHDXuat.ReadOnly = true;
            // 
            // NgayXuat
            // 
            this.NgayXuat.DataPropertyName = "NgayXuat";
            this.NgayXuat.HeaderText = "Ngày xuất";
            this.NgayXuat.Name = "NgayXuat";
            this.NgayXuat.ReadOnly = true;
            this.NgayXuat.Width = 200;
            // 
            // MaHDX
            // 
            this.MaHDX.DataPropertyName = "MaHDXuat";
            this.MaHDX.HeaderText = "Mã hóa đơn xuất hàng";
            this.MaHDX.Name = "MaHDX";
            this.MaHDX.ReadOnly = true;
            this.MaHDX.Width = 180;
            // 
            // MaMH
            // 
            this.MaMH.DataPropertyName = "MaMH";
            this.MaMH.HeaderText = "Mã mặt hàng";
            this.MaMH.Name = "MaMH";
            this.MaMH.ReadOnly = true;
            this.MaMH.Width = 200;
            // 
            // SoLuongXuat
            // 
            this.SoLuongXuat.DataPropertyName = "SoLuongXuat";
            this.SoLuongXuat.HeaderText = "Số lượng xuất";
            this.SoLuongXuat.Name = "SoLuongXuat";
            this.SoLuongXuat.ReadOnly = true;
            this.SoLuongXuat.Width = 200;
            // 
            // GiaXuat
            // 
            this.GiaXuat.DataPropertyName = "GiaXuat";
            this.GiaXuat.HeaderText = "Giá xuất";
            this.GiaXuat.Name = "GiaXuat";
            this.GiaXuat.ReadOnly = true;
            this.GiaXuat.Width = 200;
            // 
            // TTHDX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(196)))), ((int)(((byte)(109)))));
            this.ClientSize = new System.Drawing.Size(965, 494);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TTHDX";
            this.Text = "TTHDX";
            this.Load += new System.EventHandler(this.TTHDX_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimKiem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimKiem1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTimKiem2;
        private System.Windows.Forms.DataGridView dgvTimKiem1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHDXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHDX;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaXuat;
    }
}