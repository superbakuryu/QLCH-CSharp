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
    public partial class XemHDBanHang : UserControl
    {
        public XemHDBanHang()
        {
            InitializeComponent();
        }
        DataTable dt = new DataTable();
        int q;
        private void XemHDBanHang_Load(object sender, EventArgs e)
        {
            string where = "DATEPART(MONTH, NgayBan) = '" + Get_Day();
            HDBanHangBUS sv = new HDBanHangBUS();
            List<HDBanHang> lst = new List<HDBanHang>();
            lst = sv.HDBanHang_GetByTop("", where, "");
            dgvTimKiem2.DataSource = lst;
        }
        public string Get_Day()
        {
            string str = DateTime.Now.ToString().Trim();
            str = str.Substring(0, 2);
            return str;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DataRow row;
            row = dt.NewRow();
            string where = "MaHDBH like '%' + '" + dgvTimKiem2.Rows[q].Cells["MaHDBH"].Value.ToString() + "' + '%'";
            CTHDBanHangBUS sv = new CTHDBanHangBUS();
            List<CTHDBanHang> lsv = new List<CTHDBanHang>();
            lsv = sv.CTHDBanHang_GetByTop("", where, "");

        }

        private void dgvTimKiem2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            q = e.RowIndex;
        }
    }
}
