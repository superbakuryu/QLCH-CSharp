using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.model
{
    public class TTinMatHang
    {
        private string _MaMH;
        private string _TenMH;
        private string _Size;
        private string _SoLuong;
        private string _Gia;
        private string _MoTa;

        public string MaMH { get { return _MaMH; } set { _MaMH = value; } }
        public string TenMH { get { return _TenMH; } set { _TenMH = value; } }
        public string Size { get { return _Size; } set { _Size = value; } }
        public string SoLuong { get { return _SoLuong; } set { _SoLuong = value; } }
        public string Gia { get { return _Gia; } set { _Gia = value; } }
        public string MoTa { get { return _MoTa; } set { _MoTa = value; } }

        public void TTinMatHangDataReader(SqlDataReader dr)
        {
            MaMH = dr["MaMH"] is DBNull ? "" : dr["MaMH"].ToString();
            TenMH = dr["TenMH"] is DBNull ? "" : dr["TenMH"].ToString();
            Size = dr["Size"] is DBNull ? "0" : dr["Size"].ToString();
            SoLuong = dr["SoLuong"] is DBNull ? "0" : dr["SoLuong"].ToString();
            Gia = dr["Gia"] is DBNull ? "0" : dr["Gia"].ToString();
            MoTa = dr["MoTa"] is DBNull ? "" : dr["MoTa"].ToString();
        }
    }
}
