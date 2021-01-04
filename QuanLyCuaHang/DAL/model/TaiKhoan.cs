using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.model
{
    public class TaiKhoan
    {
        private string _TenDangNhap;
        private string _MatKhau;
        private string _TenNhanVien;
        private string _TrangThai;
        private string _MaQuyen;

        public string TenDangNhap { get { return _TenDangNhap; } set { _TenDangNhap = value; } }
        public string MatKhau { get { return _MatKhau; } set { _MatKhau = value; } }
        public string TenNhanVien { get { return _TenNhanVien; } set { _TenNhanVien = value; } }
        public string TrangThai { get { return _TrangThai; } set { _TrangThai = value; } }
        public string MaQuyen { get { return _MaQuyen; } set { _MaQuyen = value; } }

        public void TaiKhoanDataReader(SqlDataReader dr)
        {
            TenDangNhap = dr["TenDangNhap"] is DBNull ? "" : dr["TenDangNhap"].ToString();
            MatKhau = dr["MatKhau"] is DBNull ? "" : dr["MatKhau"].ToString();
            TenNhanVien = dr["TenNhanVien"] is DBNull ? "0" : dr["TenNhanVien"].ToString();
            TrangThai = dr["TrangThai"] is DBNull ? "0" : dr["TrangThai"].ToString();
            MaQuyen = dr["MaQuyen"] is DBNull ? "0" : dr["MaQuyen"].ToString();
        }
    }
}
