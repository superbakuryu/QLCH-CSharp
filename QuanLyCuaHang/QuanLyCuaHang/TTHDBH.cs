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
    public partial class TTHDBH : Form
    {
        public TTHDBH()
        {
            InitializeComponent();
        }
        DataTable dt = new DataTable();
        int q;

        private void btnThem_Click(object sender, EventArgs e)
        {
            DataRow row;
            row = dt.NewRow();
            string where = "MaHDBH = '" + dgvTimKiem2.Rows[q].Cells["MaHDBH"].Value.ToString()+"'";
            CTHDBanHangBUS sv = new CTHDBanHangBUS();
            List<CTHDBanHang> lsv = new List<CTHDBanHang>();
            lsv = sv.CTHDBanHang_GetByTop("", where, "");
            dgvTimKiem1.DataSource = lsv;
        }

        private void TTHDBH_Load(object sender, EventArgs e)
        {
            DateTime today = DateTime.Now;
            int a=today.Day;
            int b = today.Month;
            string where = "DATEPART(DAY, NgayBan) = " + a.ToString()+" and DATEPART(MONTH, NgayBan) = "+b.ToString();
            HDBanHangBUS sv = new HDBanHangBUS();
            List<HDBanHang> lst = new List<HDBanHang>();
            lst = sv.HDBanHang_GetByTop("", where, "");
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

        private void button2_Click(object sender, EventArgs e)
        {
            //HDBanHang obj = new HDBanHang();
            //obj.MaHDBH = dgvTimKiem2.Rows[q].Cells["MaHDBH"].Value.ToString();
            //HDBanHangBUS sv = new HDBanHangBUS();
            //sv.HDBanHang_Delete(obj.MaHDBH);
        }
    }
}
