using BUS;
using DAL.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHang
{
    public partial class TTHDN : Form
    {
        public TTHDN()
        {
            InitializeComponent();
        }
        DataTable dt = new DataTable();
        int q;
        private void TTHDN_Load(object sender, EventArgs e)
        {
            DateTime today = DateTime.Now;
            int a = today.Day;
            int b = today.Month;
            string where = "DATEPART(DAY, NgayNhap) = " + a.ToString() + " and DATEPART(MONTH, NgayNhap) = " + b.ToString();
            HDNhapBUS sv = new HDNhapBUS();
            List<HDNhap> lst = new List<HDNhap>();
            lst = sv.HDNhap_GetByTop("", where, "");
            dgvTimKiem2.DataSource = lst;
        }

        private void dgvTimKiem2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            q = e.RowIndex;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            DataRow row;
            row = dt.NewRow();
            string where = "MaHDNhap = '" + dgvTimKiem2.Rows[q].Cells["MaHDNhap"].Value.ToString() + "'";
            CTHDNhapBUS sv = new CTHDNhapBUS();
            List<CTHDNhap> lsv = new List<CTHDNhap>();
            lsv = sv.CTHDNhap_GetByTop("", where, "");
            dgvTimKiem1.DataSource = lsv;
        }
    }
}
