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
    public partial class TTTaiKhoan : UserControl
    {
        public TTTaiKhoan()
        {
            InitializeComponent();
        }

        private void TTTaiKhoan_Load(object sender, EventArgs e)
        {
            txtQuyen.Enabled = false;
            GetData();
            txtQuyen.Text = "Nhân viên bán hàng";
        }

        public void GetData()
        {
            txtTenDangNhap.Enabled = true;
            btnSua.Enabled = false;
            TaiKhoanBUS ck = new TaiKhoanBUS();
            List<TaiKhoan> lckh = new List<TaiKhoan>();
            lckh = ck.TaiKhoan_GetByTop("", "", "");
            dgvTaiKhoan.DataSource = lckh;


        }

        public void ClearText()
        {
            txtTenDangNhap.Text = "";
            txtMatKhau.Text = "";
            txtTenNhanVien.Text = "";
            nbTrangThai.Value = 0;
            //txtQuyen.Text = "";
            btnCapNhat.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = false;

        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            ClearText();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            TaiKhoan obj = new TaiKhoan();
            if (txtTenDangNhap.Text == "" || nbTrangThai.Value == 0 || txtMatKhau.Text == "" || txtTenNhanVien.Text == "" || txtQuyen.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập hoặc nhập sai!");
            }
            else
            {
                string where = "TenDangNhap = N'" + txtTenDangNhap.Text + "'";
                TaiKhoanBUS ck = new TaiKhoanBUS();
                List<TaiKhoan> lckh = new List<TaiKhoan>();
                lckh = ck.TaiKhoan_GetByTop("", where, "");
                if (lckh.Count() == 1)
                {
                    MessageBox.Show("Tên đăng nhập bị trùng!");
                }
                else
                {
                    obj.TenDangNhap = txtTenDangNhap.Text;
                    obj.MatKhau = txtMatKhau.Text;
                    obj.TenNhanVien = txtTenNhanVien.Text;
                    obj.TrangThai = nbTrangThai.Value.ToString();
                    obj.MaQuyen = txtQuyen.Text;
                    TaiKhoanBUS sv1 = new TaiKhoanBUS();
                    sv1.TaiKhoan_Insert(obj);
                    ClearText();
                    MessageBox.Show("Thêm thành công!");
                }
            }
            GetData();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            TaiKhoan obj = new TaiKhoan();
            if (txtTenDangNhap.Text == "" || nbTrangThai.Value == 0 || txtMatKhau.Text == "" || txtTenNhanVien.Text == "" || txtQuyen.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập hoặc nhập sai!");
            }
            else
            {
                obj.TenDangNhap = txtTenDangNhap.Text;
                obj.MatKhau = txtMatKhau.Text;
                obj.TenNhanVien = txtTenNhanVien.Text;
                obj.TrangThai = nbTrangThai.Value.ToString();
                obj.MaQuyen = txtQuyen.Text;
                MessageBox.Show("Sửa thành công!");
            }
            TaiKhoanBUS sv = new TaiKhoanBUS();
            sv.TaiKhoan_UpDate(obj);
            GetData();
            ClearText();

        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            string where = "TenDangNhap like '%' + '" + txtTimKiem.Text + "' + '%'";
            TaiKhoanBUS sv = new TaiKhoanBUS();
            List<TaiKhoan> lst = new List<TaiKhoan>();
            lst = sv.TaiKhoan_GetByTop("", where, "");
            dgvTaiKhoan.DataSource = lst;
        }

        private void dgvTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex; // Vị trí hàng bấm vào
            int j = e.ColumnIndex; // Vị trí cột bấm vào
            if (i >= 0) //Nếu bấm vào trường dữ liệu thì mới lấy dữ liệu
            {
                txtTenDangNhap.Enabled = false;
                btnSua.Enabled = true;
                btnThem.Enabled = false;
                txtTenDangNhap.Text = dgvTaiKhoan.Rows[i].Cells["TenDangNhap"].Value.ToString();
                txtMatKhau.Text = dgvTaiKhoan.Rows[i].Cells["MatKhau"].Value.ToString();
                txtTenNhanVien.Text = dgvTaiKhoan.Rows[i].Cells["TenNhanVien"].Value.ToString();
                nbTrangThai.Value = decimal.Parse(dgvTaiKhoan.Rows[i].Cells["TrangThai"].Value.ToString());
                txtQuyen.Text = dgvTaiKhoan.Rows[i].Cells["MaQuyen"].Value.ToString();
            }
        }
    }
}
