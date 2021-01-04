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
    public partial class TTHDX : Form
    {
        public TTHDX()
        {
            InitializeComponent();
        }
        DataTable dt = new DataTable();
        int q;
        private void TTHDX_Load(object sender, EventArgs e)
        {
            DateTime today = DateTime.Now;
            int a = today.Day;
            int b = today.Month;
            string where = "DATEPART(DAY, NgayXuat) = " + a.ToString() + " and DATEPART(MONTH, NgayXuat) = " + b.ToString();
            HDXuatBUS sv = new HDXuatBUS();
            List<HDXuat> lst = new List<HDXuat>();
            lst = sv.HDXuat_GetByTop("", where, "");
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
            string where = "MaHDXuat = '" + dgvTimKiem2.Rows[q].Cells["MaHDXuat"].Value.ToString() + "'";
            CTHDXuatBUS sv = new CTHDXuatBUS();
            List<CTHDXuat> lsv = new List<CTHDXuat>();
            lsv = sv.CTHDXuat_GetByTop("", where, "");
            dgvTimKiem1.DataSource = lsv;
        }
    }
}
