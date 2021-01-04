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
    public partial class BanHang : UserControl
    {
        public BanHang()
        {
            InitializeComponent();
        }
        public string ten;
        int i, j;
        DataTable dt = new DataTable();
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string where = "MaMH like '%' + '" + txtTimKiem.Text + "' + '%'";
            TTinMatHangBUS sv = new TTinMatHangBUS();
            List<TTinMatHang> lst = new List<TTinMatHang>();
            lst = sv.TTinMatHang_GetByTop("", where, "");
            dgvTimKiem.DataSource = lst;
        }

        private void BanHang_Load(object sender, EventArgs e)
        {
            TaoCot();
            txtNhanVien.Enabled = false;
            txtNhanVien.Text = ten;
        }

        private void dgvTimKiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            i = e.RowIndex;
        }

        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            j = e.RowIndex;
        }

        public void TaoCot()
        {
            // DataTable dt = new DataTable();
            dt.Columns.Add("Mã mặt hàng", typeof(String));
            dt.Columns.Add("Tên mặt hàng", typeof(String));
            //dt.Columns.Add("Size", typeof(int));
            dt.Columns.Add("Số lượng", typeof(int));
            dt.Columns.Add("Giá", typeof(int));
            //dt.Columns.Add("Mô tả", typeof(String));
            dgvHoaDon.DataSource = dt;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DataRow row;
            row = dt.NewRow();
            row["Mã mặt hàng"] = dgvTimKiem.Rows[i].Cells["MaMH"].Value.ToString();
            row["Tên mặt hàng"] = dgvTimKiem.Rows[i].Cells["TenMH"].Value.ToString();
            row["Giá"] = dgvTimKiem.Rows[i].Cells["Gia"].Value.ToString();
            if (nbSoLuong.Value == 0)
            {
                MessageBox.Show("Bạn chưa nhập số lượng");
            }
            else
            {
                row["Số lượng"] = nbSoLuong.Value;
                dt.Rows.Add(row);
                dgvHoaDon.DataSource = dt;
            }
            txtThanhTien.Text = tinhTien().ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                dgvHoaDon.Rows.Remove(dgvHoaDon.Rows[j]);

            }
            catch (Exception)
            {
                MessageBox.Show("Bạn đã xóa hết!");
            }

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            HDBanHang obj = new HDBanHang();
            obj.NgayBan = dtpNgay.Text;
            obj.TenNhanVien = txtNhanVien.Text;
            obj.ThanhTien = txtThanhTien.Text;
            HDBanHangBUS sv = new HDBanHangBUS();
            sv.HDBanHang_Insert(obj);
            themChiTietNhap();
            MessageBox.Show("Lưu thành công!");
            for (int i = 0; i < dgvHoaDon.Rows.Count ; i++)
            {
                TTinMatHang objj = new TTinMatHang();
                objj.MaMH = dgvHoaDon.Rows[i].Cells[0].Value.ToString();
                objj.SoLuong = dgvHoaDon.Rows[i].Cells[2].Value.ToString();
                TTinMatHangBUS ssv = new TTinMatHangBUS();
                ssv.TTinMatHangBan_UpDate(objj);
            }
            xoaSauLuu();
        }
        public void themChiTietNhap()
        {
            HDBanHangBUS svv = new HDBanHangBUS();
            List<HDBanHang> lst = new List<HDBanHang>();
            lst = svv.HDBanHang_GetByTop("1", "", "MaHDBH DESC");
            for (int i = 0; i < dgvHoaDon.Rows.Count ; i++)
            {
                CTHDBanHang objj = new CTHDBanHang();
                objj.MaHDBH = lst[0].MaHDBH;
                objj.MaMH = dgvHoaDon.Rows[i].Cells[0].Value.ToString();
                objj.SoLuongBan = dgvHoaDon.Rows[i].Cells[2].Value.ToString();
                objj.GiaBan = dgvHoaDon.Rows[i].Cells[3].Value.ToString();
                CTHDBanHangBUS ssv = new CTHDBanHangBUS();
                ssv.CTHDBanHang_Insert(objj);
            }
        }
        public void xoaSauLuu()
        {
            int a = dgvHoaDon.Rows.Count - 1;
            for (int q = a; q >= 0; q--)
            {
                dgvHoaDon.Rows.Remove(dgvHoaDon.Rows[q]);
                txtThanhTien.Text = "";

            }

        }

        int tinhTien()
        {
            int km = Convert.ToInt32(nbChietKhau.Value.ToString());
            int tong = 0;
            for (int i = 0; i < dgvHoaDon.Rows.Count ; i++)
            {
                tong += (Convert.ToInt32(dgvHoaDon.Rows[i].Cells[2].Value.ToString()) * Convert.ToInt32(dgvHoaDon.Rows[i].Cells[3].Value.ToString()));
            }
            tong = tong - km;
            return tong;
        }

        private void nbChietKhau_ValueChanged(object sender, EventArgs e)
        {
            txtThanhTien.Text=tinhTien().ToString();
        }

        private void btnXemHD_Click(object sender, EventArgs e)
        {
            TTHDBH fm = new TTHDBH();
            fm.Show();
            this.Hide();
        }

    }
}
