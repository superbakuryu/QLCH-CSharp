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
    public partial class ThongTinMatHang : UserControl
    {
        public ThongTinMatHang()
        {
            InitializeComponent();
        }

        private void ThongTinMatHang_Load(object sender, EventArgs e)
        {
            GetData();
        }

        public void GetData()
        {
            txtMaMH.Enabled = false;
            btnSua.Enabled = false;
            TTinMatHangBUS ck = new TTinMatHangBUS();
            List<TTinMatHang> lckh = new List<TTinMatHang>();
            lckh = ck.TTinMatHang_GetByTop("", "", "");
            dgvTTMatHang.DataSource = lckh;


        }

        public void ClearText()
        {
            txtMaMH.Text = "";
            txtTenMH.Text = "";
            nbGia.Value = 0;
            nbSize.Value = 0;
            nbSoLuong.Value = 0;
            txtMoTa.Text = "";
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
            TTinMatHang obj = new TTinMatHang();
            if (txtTenMH.Text == "" || nbSize.Value == 0 || nbSoLuong.Text == "" || txtMoTa.Text == "" || nbGia.Value == 0)
            {
                MessageBox.Show("Bạn chưa nhập hoặc nhập sai!");
            }
            else
            {
                obj.TenMH = txtTenMH.Text;
                obj.Size = nbSize.Value.ToString();
                obj.SoLuong = nbSoLuong.Value.ToString();
                obj.Gia = nbGia.Value.ToString();
                obj.MoTa = txtMoTa.Text;
                TTinMatHangBUS sv = new TTinMatHangBUS();
                sv.TTinMatHang_Insert(obj);
                ClearText();
                MessageBox.Show("Thêm thành công!");
            }
            GetData();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            TTinMatHang obj = new TTinMatHang();
            obj.MaMH = txtMaMH.Text;
            if (txtTenMH.Text == "" || nbSize.Value == 0 || nbSoLuong.Text == "" || txtMoTa.Text == "" || nbGia.Value == 0)
            {
                MessageBox.Show("Bạn chưa nhập hoặc nhập sai!");
            }
            else
            {
                obj.TenMH = txtTenMH.Text;
                obj.Size = nbSize.Value.ToString();
                obj.SoLuong = nbSoLuong.Value.ToString();
                obj.Gia = nbGia.Value.ToString();
                obj.MoTa = txtMoTa.Text;
                ClearText();
                MessageBox.Show("Sửa thành công!");
            }
            TTinMatHangBUS sv = new TTinMatHangBUS();
            sv.TTinMatHang_UpDate(obj);
            GetData();
            ClearText();
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            string where = "MaMH like '%' + '" + txtTimKiem.Text + "' + '%'";
            TTinMatHangBUS sv = new TTinMatHangBUS();
            List<TTinMatHang> lst = new List<TTinMatHang>();
            lst = sv.TTinMatHang_GetByTop("", where, "");
            dgvTTMatHang.DataSource = lst;
        }

        private void dgvTTMatHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex; // Vị trí hàng bấm vào
            int j = e.ColumnIndex; // Vị trí cột bấm vào
            if (i >= 0) //Nếu bấm vào trường dữ liệu thì mới lấy dữ liệu
            {
                btnSua.Enabled = true;
                btnThem.Enabled = false;
                txtMaMH.Text = dgvTTMatHang.Rows[i].Cells["MaMH"].Value.ToString();
                txtTenMH.Text = dgvTTMatHang.Rows[i].Cells["TenMH"].Value.ToString();
                nbSize.Value = decimal.Parse(dgvTTMatHang.Rows[i].Cells[2].Value.ToString());
                nbSoLuong.Value = decimal.Parse(dgvTTMatHang.Rows[i].Cells["SoLuong"].Value.ToString());
                nbGia.Value = decimal.Parse(dgvTTMatHang.Rows[i].Cells["Gia"].Value.ToString());
                txtMoTa.Text = dgvTTMatHang.Rows[i].Cells["MoTa"].Value.ToString();
            }
        }

    }
}
