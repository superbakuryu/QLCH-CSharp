namespace QuanLyCuaHang
{
    partial class TTHDBH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TTHDBH));
            this.dgvTimKiem2 = new System.Windows.Forms.DataGridView();
            this.dgvTimKiem1 = new System.Windows.Forms.DataGridView();
            this.MaHDB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaHDBH = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.MaHDBH,
            this.NgayBan,
            this.TenNhanVien,
            this.ThanhTien});
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
            this.MaHDB,
            this.MaMH,
            this.SoLuong,
            this.GiaBan});
            this.dgvTimKiem1.Location = new System.Drawing.Point(35, 211);
            this.dgvTimKiem1.Name = "dgvTimKiem1";
            this.dgvTimKiem1.ReadOnly = true;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.dgvTimKiem1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTimKiem1.Size = new System.Drawing.Size(824, 198);
            this.dgvTimKiem1.TabIndex = 2;
            // 
            // MaHDB
            // 
            this.MaHDB.DataPropertyName = "MaHDBH";
            this.MaHDB.HeaderText = "Mã hóa đơn bán hàng";
            this.MaHDB.Name = "MaHDB";
            this.MaHDB.ReadOnly = true;
            this.MaHDB.Width = 180;
            // 
            // MaMH
            // 
            this.MaMH.DataPropertyName = "MaMH";
            this.MaMH.HeaderText = "Mã mặt hàng";
            this.MaMH.Name = "MaMH";
            this.MaMH.ReadOnly = true;
            this.MaMH.Width = 200;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuongBan";
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            this.SoLuong.Width = 200;
            // 
            // GiaBan
            // 
            this.GiaBan.DataPropertyName = "GiaBan";
            this.GiaBan.HeaderText = "Giá bán";
            this.GiaBan.Name = "GiaBan";
            this.GiaBan.ReadOnly = true;
            this.GiaBan.Width = 200;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(36, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 23);
            this.label3.TabIndex = 23;
            this.label3.Text = "Hóa đơn bán hàng";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(189)))), ((int)(((byte)(175)))));
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.dgvTimKiem2);
            this.groupBox1.Controls.Add(this.dgvTimKiem1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(40, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(888, 442);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hóa đơn";
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(139)))), ((int)(((byte)(95)))));
            this.btnThem.Location = new System.Drawing.Point(747, 175);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(104, 30);
            this.btnThem.TabIndex = 8;
            this.btnThem.Text = "Xem Chi tiết";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(139)))), ((int)(((byte)(95)))));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(864, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 30);
            this.button1.TabIndex = 24;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ThanhTien
            // 
            this.ThanhTien.DataPropertyName = "ThanhTien";
            this.ThanhTien.HeaderText = "Thành tiền";
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.ReadOnly = true;
            // 
            // TenNhanVien
            // 
            this.TenNhanVien.DataPropertyName = "TenNhanVien";
            this.TenNhanVien.HeaderText = "Tên nhân viên";
            this.TenNhanVien.Name = "TenNhanVien";
            this.TenNhanVien.ReadOnly = true;
            this.TenNhanVien.Width = 300;
            // 
            // NgayBan
            // 
            this.NgayBan.DataPropertyName = "NgayBan";
            this.NgayBan.HeaderText = "Ngày bán";
            this.NgayBan.Name = "NgayBan";
            this.NgayBan.ReadOnly = true;
            this.NgayBan.Width = 200;
            // 
            // MaHDBH
            // 
            this.MaHDBH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaHDBH.DataPropertyName = "MaHDBH";
            this.MaHDBH.HeaderText = "Mã hóa đơn bán hàng";
            this.MaHDBH.Name = "MaHDBH";
            this.MaHDBH.ReadOnly = true;
            // 
            // TTHDBH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(196)))), ((int)(((byte)(109)))));
            this.ClientSize = new System.Drawing.Size(965, 494);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Name = "TTHDBH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TTHDBH";
            this.Load += new System.EventHandler(this.TTHDBH_Load);
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
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHDB;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaBan;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHDBH;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
    }
}