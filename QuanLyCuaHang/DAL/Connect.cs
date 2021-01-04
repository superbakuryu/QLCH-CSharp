using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class Connect
    {
        private SqlConnection conn = null;
        private string ConStr = "Server = .\\SQLEXPRESS; Database = QuanLyCuaHang; Integrated Security = SSPI; Uid = sa; Pwd = 123456;";

        //Khởi tạo kết nối
        public Connect()
        {
            if (conn == null)
            {
                conn = new SqlConnection(ConStr);
            }
        }

        //Mở kết nối
        public SqlConnection GetConnection()
        {
            if (conn.State == ConnectionState.Closed)
            {
               conn.Open();
            }
            return conn;
        }
    }
}
