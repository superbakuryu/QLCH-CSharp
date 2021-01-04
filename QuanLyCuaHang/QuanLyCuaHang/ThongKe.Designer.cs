namespace QuanLyCuaHang
{
    partial class ThongKe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThongKe));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbThongKe = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.QuanLyCuaHangDataSet = new QuanLyCuaHang.QuanLyCuaHangDataSet();
            this.pr_MHBanChayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pr_MHBanChayTableAdapter = new QuanLyCuaHang.QuanLyCuaHangDataSetTableAdapters.pr_MHBanChayTableAdapter();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.QuanLyCuaHangDataSet1 = new QuanLyCuaHang.QuanLyCuaHangDataSet1();
            this.pr_DoanhThuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pr_DoanhThuTableAdapter = new QuanLyCuaHang.QuanLyCuaHangDataSet1TableAdapters.pr_DoanhThuTableAdapter();
            this.reportViewer3 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.QuanLyCuaHangDataSet2 = new QuanLyCuaHang.QuanLyCuaHangDataSet2();
            this.pr_SoLuongTonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pr_SoLuongTonTableAdapter = new QuanLyCuaHang.QuanLyCuaHangDataSet2TableAdapters.pr_SoLuongTonTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuanLyCuaHangDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pr_MHBanChayBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuanLyCuaHangDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pr_DoanhThuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuanLyCuaHangDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pr_SoLuongTonBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(24, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 23);
            this.label3.TabIndex = 20;
            this.label3.Text = "Thống kê";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(189)))), ((int)(((byte)(175)))));
            this.groupBox1.Controls.Add(this.reportViewer3);
            this.groupBox1.Controls.Add(this.reportViewer2);
            this.groupBox1.Controls.Add(this.reportViewer1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbThongKe);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(29, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(884, 443);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thống kê của cửa hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(589, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 19);
            this.label1.TabIndex = 24;
            this.label1.Text = "Tháng cần thống kê:";
            // 
            // cbThongKe
            // 
            this.cbThongKe.FormattingEnabled = true;
            this.cbThongKe.Items.AddRange(new object[] {
            "Xem thống kê mặt hàng bán chạy theo tháng",
            "Xem thống kê doanh thu",
            "Xem thống kê số lượng tồn"});
            this.cbThongKe.Location = new System.Drawing.Point(30, 25);
            this.cbThongKe.Name = "cbThongKe";
            this.cbThongKe.Size = new System.Drawing.Size(441, 27);
            this.cbThongKe.TabIndex = 23;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(139)))), ((int)(((byte)(95)))));
            this.button3.ForeColor = System.Drawing.SystemColors.Control;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(505, 22);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(30, 30);
            this.button3.TabIndex = 3;
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(745, 26);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown1.TabIndex = 4;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // reportViewer1
            // 
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.pr_MHBanChayBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyCuaHang.MatHangBanChay.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(30, 58);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(835, 354);
            this.reportViewer1.TabIndex = 25;
            // 
            // QuanLyCuaHangDataSet
            // 
            this.QuanLyCuaHangDataSet.DataSetName = "QuanLyCuaHangDataSet";
            this.QuanLyCuaHangDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pr_MHBanChayBindingSource
            // 
            this.pr_MHBanChayBindingSource.DataMember = "pr_MHBanChay";
            this.pr_MHBanChayBindingSource.DataSource = this.QuanLyCuaHangDataSet;
            // 
            // pr_MHBanChayTableAdapter
            // 
            this.pr_MHBanChayTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer2
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.pr_DoanhThuBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "QuanLyCuaHang.DoanhThu.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(30, 58);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.Size = new System.Drawing.Size(835, 354);
            this.reportViewer2.TabIndex = 26;
            // 
            // QuanLyCuaHangDataSet1
            // 
            this.QuanLyCuaHangDataSet1.DataSetName = "QuanLyCuaHangDataSet1";
            this.QuanLyCuaHangDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pr_DoanhThuBindingSource
            // 
            this.pr_DoanhThuBindingSource.DataMember = "pr_DoanhThu";
            this.pr_DoanhThuBindingSource.DataSource = this.QuanLyCuaHangDataSet1;
            // 
            // pr_DoanhThuTableAdapter
            // 
            this.pr_DoanhThuTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer3
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.pr_SoLuongTonBindingSource;
            this.reportViewer3.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer3.LocalReport.ReportEmbeddedResource = "QuanLyCuaHang.SoLuongTonKho.rdlc";
            this.reportViewer3.Location = new System.Drawing.Point(30, 58);
            this.reportViewer3.Name = "reportViewer3";
            this.reportViewer3.Size = new System.Drawing.Size(835, 354);
            this.reportViewer3.TabIndex = 27;
            // 
            // QuanLyCuaHangDataSet2
            // 
            this.QuanLyCuaHangDataSet2.DataSetName = "QuanLyCuaHangDataSet2";
            this.QuanLyCuaHangDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pr_SoLuongTonBindingSource
            // 
            this.pr_SoLuongTonBindingSource.DataMember = "pr_SoLuongTon";
            this.pr_SoLuongTonBindingSource.DataSource = this.QuanLyCuaHangDataSet2;
            // 
            // pr_SoLuongTonTableAdapter
            // 
            this.pr_SoLuongTonTableAdapter.ClearBeforeFill = true;
            // 
            // ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(196)))), ((int)(((byte)(109)))));
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ThongKe";
            this.Size = new System.Drawing.Size(946, 507);
            this.Load += new System.EventHandler(this.ThongKe_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuanLyCuaHangDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pr_MHBanChayBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuanLyCuaHangDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pr_DoanhThuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuanLyCuaHangDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pr_SoLuongTonBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ComboBox cbThongKe;
        private System.Windows.Forms.Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource pr_MHBanChayBindingSource;
        private QuanLyCuaHangDataSet QuanLyCuaHangDataSet;
        private QuanLyCuaHangDataSetTableAdapters.pr_MHBanChayTableAdapter pr_MHBanChayTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.BindingSource pr_DoanhThuBindingSource;
        private QuanLyCuaHangDataSet1 QuanLyCuaHangDataSet1;
        private QuanLyCuaHangDataSet1TableAdapters.pr_DoanhThuTableAdapter pr_DoanhThuTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer3;
        private System.Windows.Forms.BindingSource pr_SoLuongTonBindingSource;
        private QuanLyCuaHangDataSet2 QuanLyCuaHangDataSet2;
        private QuanLyCuaHangDataSet2TableAdapters.pr_SoLuongTonTableAdapter pr_SoLuongTonTableAdapter;
    }
}
