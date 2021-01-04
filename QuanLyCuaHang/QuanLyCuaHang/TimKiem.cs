using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DAL.model;

namespace QuanLyCuaHang
{
    public partial class TimKiem : UserControl
    {
        public TimKiem()
        {
            InitializeComponent();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (cbTieuChi.Text == "Tìm kiếm theo mã mặt hàng")
            {
                dgvTimKiem1.Visible = true;
                dgvTimKiem2.Visible = false;
                string where = "MaMH like '%' + '" + txtTimKiem.Text + "' + '%'";
                TTinMatHangBUS sv = new TTinMatHangBUS();
                List<TTinMatHang> lst = new List<TTinMatHang>();
                lst = sv.TTinMatHang_GetByTop("", where, "");
                dgvTimKiem1.DataSource = lst;
            }
            if (cbTieuChi.Text == "Tìm kiếm hóa đơn bán hàng")
            {
                dgvTimKiem2.Visible = true;
                dgvTimKiem1.Visible = false;
                string where = "MaHDBH like '%' + '" + txtTimKiem.Text + "' + '%'";
                HDBanHangBUS sv = new HDBanHangBUS();
                List<HDBanHang> lst = new List<HDBanHang>();
                lst = sv.HDBanHang_GetByTop("", where, "");
                dgvTimKiem2.DataSource = lst;
            }
        }

        private void TimKiem_Load(object sender, EventArgs e)
        {

        }
    }
}
