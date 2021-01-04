using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.model
{
    public class HDBanHang
    {
        private string _MaHDBH;
        private string _NgayBan;
        private string _TenNhanVien;
        private string _ThanhTien;
        public string MaHDBH { get { return _MaHDBH; } set { _MaHDBH = value; } }
        public string NgayBan { get { return _NgayBan; } set { _NgayBan = value; } }
        public string TenNhanVien { get { return _TenNhanVien; } set { _TenNhanVien = value; } }
        public string ThanhTien { get { return _ThanhTien; } set { _ThanhTien = value; } }
        public void HDBanHangDataReader(SqlDataReader dr)
        {
            MaHDBH = dr["MaHDBH"] is DBNull ? "" : dr["MaHDBH"].ToString();
            NgayBan = dr["NgayBan"] is DBNull ? "" : dr["NgayBan"].ToString();
            TenNhanVien = dr["TenNhanVien"] is DBNull ? "" : dr["TenNhanVien"].ToString();
            ThanhTien = dr["ThanhTien"] is DBNull ? "" : dr["ThanhTien"].ToString();
        }
    }
}
