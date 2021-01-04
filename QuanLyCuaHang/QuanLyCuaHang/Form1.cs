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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // string ten, quyen;
        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if (cbQuyen.Text == "" || txtPass.Text == "" || txtUser.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập thông tin!");
            }
            else { 
                string where = "TenDangNhap = '" + txtUser.Text + "' and MatKhau = '" + txtPass.Text + "' and MaQuyen = N'" + cbQuyen.Text + "'";
                TaiKhoanBUS sv = new TaiKhoanBUS();
                List<TaiKhoan> lst = new List<TaiKhoan>();
                lst = sv.TaiKhoan_GetByTop("", where, "");
                if (lst.Count() == 1)
                {
                    TrangChu fm = new TrangChu();
                    fm.ten = lst[0].TenNhanVien; ;
                    fm.quyen = lst[0].MaQuyen;
                    fm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Không đúng tên đăng nhập và mật khẩu!");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
