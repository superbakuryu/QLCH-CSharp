using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.model
{
    public class CTHDBanHang
    {
        private string _MaHDBH;
        private string _MaMH;
        private string _SoLuongBan;
        private string _GiaBan;
        public string MaHDBH { get { return _MaHDBH; } set { _MaHDBH = value; } }
        public string MaMH { get { return _MaMH; } set { _MaMH = value; } }
        public string SoLuongBan { get { return _SoLuongBan; } set { _SoLuongBan = value; } }
        public string GiaBan { get { return _GiaBan; } set { _GiaBan = value; } }

        public void CTHDBanHangDataReader(SqlDataReader dr)
        {
            MaHDBH = dr["MaHDBH"] is DBNull ? "" : dr["MaHDBH"].ToString();
            MaMH = dr["MaMH"] is DBNull ? "" : dr["MaMH"].ToString();
            SoLuongBan = dr["SoLuongBan"] is DBNull ? "" : dr["SoLuongBan"].ToString();
            GiaBan = dr["GiaBan"] is DBNull ? "" : dr["GiaBan"].ToString();

        }
    }
}
