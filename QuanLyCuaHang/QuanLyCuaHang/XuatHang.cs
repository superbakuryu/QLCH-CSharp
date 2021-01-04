using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL.model;
using BUS;

namespace QuanLyCuaHang
{
    public partial class XuatHang : UserControl
    {
        public XuatHang()
        {
            InitializeComponent();
        }
        int i, j;
        DataTable dt = new DataTable();

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
            //row["Giá"] = dgvTimKiem.Rows[i].Cells["Gia"].Value.ToString();
            if (nbSoLuong.Value == 0)
            {
                MessageBox.Show("Bạn chưa nhập số lượng hoặc giá");
            }
            else
            {
                row["Giá"] = nbGia.Value;
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
            HDXuat obj = new HDXuat();
            obj.NgayXuat = dtpNgay.Text;
            HDXuatBUS sv = new HDXuatBUS();
            sv.HDXuat_Insert(obj);
            themChiTietNhap();
            MessageBox.Show("Lưu thành công!");
            for (int i = 0; i < dgvHoaDon.Rows.Count; i++)
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
            HDXuatBUS svv = new HDXuatBUS();
            List<HDXuat> lst = new List<HDXuat>();
            lst = svv.HDXuat_GetByTop("1", "", "MaHDXuat DESC");
            for (int i = 0; i < dgvHoaDon.Rows.Count; i++)
            {
                CTHDXuat objj = new CTHDXuat();
                objj.MaHDXuat = lst[0].MaHDXuat;
                objj.MaMH = dgvHoaDon.Rows[i].Cells[0].Value.ToString();
                objj.SoLuongXuat = dgvHoaDon.Rows[i].Cells[2].Value.ToString();
                objj.GiaXuat = dgvHoaDon.Rows[i].Cells[3].Value.ToString();
                CTHDXuatBUS ssv = new CTHDXuatBUS();
                ssv.CTHDXuat_Insert(objj);
            }
        }

        public void xoaSauLuu()
        {
            int a = dgvHoaDon.Rows.Count - 1;
            for (int q = a; q >= 0; q--)
            {
                dgvHoaDon.Rows.Remove(dgvHoaDon.Rows[q]);

            }

        }

        int tinhTien()
        {
            int tong = 0;
            for (int i = 0; i < dgvHoaDon.Rows.Count; i++)
            {
                tong += (Convert.ToInt32(dgvHoaDon.Rows[i].Cells[2].Value.ToString()) * Convert.ToInt32(dgvHoaDon.Rows[i].Cells[3].Value.ToString()));
            }
            return tong;
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string where = "MaMH like '%' + '" + txtTimKiem.Text + "' + '%'";
            TTinMatHangBUS sv = new TTinMatHangBUS();
            List<TTinMatHang> lst = new List<TTinMatHang>();
            lst = sv.TTinMatHang_GetByTop("", where, "");
            dgvTimKiem.DataSource = lst;
        }

        private void btnXemHD_Click(object sender, EventArgs e)
        {
            TTHDX fm = new TTHDX();
            fm.Show();
            this.Hide();
        }

        private void XuatHang_Load(object sender, EventArgs e)
        {
            TaoCot();
        }
    }
}
