using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHang
{
    public partial class ThongKe : UserControl
    {
        public ThongKe()
        {
            InitializeComponent();
        }


        private void ThongKe_Load(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (cbThongKe.Text == "Xem thống kê mặt hàng bán chạy theo tháng")
            {
                reportViewer1.Visible = true;
                reportViewer2.Visible = false;
                reportViewer3.Visible = false;
                int thang = Convert.ToInt32(numericUpDown1.Value);
                this.pr_MHBanChayTableAdapter.Fill(this.QuanLyCuaHangDataSet.pr_MHBanChay, thang);
                this.reportViewer1.RefreshReport();
            }
            if (cbThongKe.Text == "Xem thống kê doanh thu")
            {
                reportViewer2.Visible = true;
                reportViewer1.Visible = false;
                reportViewer3.Visible = false;
                this.pr_DoanhThuTableAdapter.Fill(this.QuanLyCuaHangDataSet1.pr_DoanhThu);
                this.reportViewer2.RefreshReport();
            }
            if (cbThongKe.Text == "Xem thống kê số lượng tồn")
            {
                reportViewer3.Visible = true;
                reportViewer1.Visible = false;
                reportViewer2.Visible = false;
                this.pr_SoLuongTonTableAdapter.Fill(this.QuanLyCuaHangDataSet2.pr_SoLuongTon,1);
                this.reportViewer3.RefreshReport();
            }
        }

    }
}
