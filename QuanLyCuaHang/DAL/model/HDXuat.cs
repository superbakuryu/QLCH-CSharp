using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.model
{
    public class HDXuat
    {
        private string _MaHDXuat;
        private string _NgayXuat;
        public string MaHDXuat { get { return _MaHDXuat; } set { _MaHDXuat = value; } }
        public string NgayXuat { get { return _NgayXuat; } set { _NgayXuat = value; } }
        public void HDXuatDataReader(SqlDataReader dr)
        {
            MaHDXuat = dr["MaHDXuat"] is DBNull ? "" : dr["MaHDXuat"].ToString();
            NgayXuat = dr["NgayXuat"] is DBNull ? "" : dr["NgayXuat"].ToString();

        }
    }
}
