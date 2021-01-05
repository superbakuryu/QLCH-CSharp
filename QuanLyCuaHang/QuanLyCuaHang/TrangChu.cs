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
    public partial class TrangChu : Form
    {
        public TrangChu()
        {
            InitializeComponent();
        }
        public string ten,quyen;
        public void xetquyen()
        {
            if(quyen=="Nhân viên bán hàng")
            {
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = false; button4.Visible = false;
                button5.Enabled = false; button5.Visible = false;
                button6.Enabled = false; button6.Visible = false;
                button7.Enabled = false; button7.Visible = false;
            }
            if (quyen == "Quản lý kho")
            {
                button1.Enabled = false; button1.Visible = false;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = false; button7.Visible = false;
            }
            if (quyen == "Chủ cửa hàng")
            {
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            panel4.Controls.Clear();
            BanHang bh = new BanHang();
            bh.ten = ten;
            panel4.Controls.Add(bh);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel4.Controls.Clear();
            panel4.Controls.Add(new QuanLyCuaHang.TimKiem());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel4.Controls.Clear();
            panel4.Controls.Add(new QuanLyCuaHang.ThongKe());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel4.Controls.Clear();
            panel4.Controls.Add(new QuanLyCuaHang.ThongTinMatHang());
        }

        private void TrangChu_Load(object sender, EventArgs e)
        {
            xetquyen();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel4.Controls.Clear();
            panel4.Controls.Add(new QuanLyCuaHang.NhapHang());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel4.Controls.Clear();
            panel4.Controls.Add(new QuanLyCuaHang.XuatHang());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Bạn có muốn thoát khỏi chương trình không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            panel4.Controls.Clear();
            panel4.Controls.Add(new QuanLyCuaHang.TTTaiKhoan());
        }
    }
}
