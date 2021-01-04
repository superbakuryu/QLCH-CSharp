using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.model
{
    public class HDNhap
    {
        private string _MaHDNhap;
        private string _NgayNhap;
        public string MaHDNhap { get { return _MaHDNhap; } set { _MaHDNhap = value; } }
        public string NgayNhap { get { return _NgayNhap; } set { _NgayNhap = value; } }
        public void HDNhapDataReader(SqlDataReader dr)
        {
            MaHDNhap = dr["MaHDNhap"] is DBNull ? "" : dr["MaHDNhap"].ToString();
            NgayNhap = dr["NgayNhap"] is DBNull ? "" : dr["NgayNhap"].ToString();

        }
    }
}
