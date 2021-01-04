using DAL.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.dal
{
    public class HDBanHangDAL : Connect
    {
        public List<HDBanHang> HDBanHang_GetByTop(string Top, string Where, string Order)
        {
            List<HDBanHang> lst = new List<HDBanHang>();
            using (SqlCommand cmd = new SqlCommand("sp_GetByTop", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Top", Top));
                cmd.Parameters.Add(new SqlParameter("@Where", Where));
                cmd.Parameters.Add(new SqlParameter("@Order", Order));
                cmd.Parameters.Add(new SqlParameter("@Name", "[dbo].[HDBanHang]"));
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        HDBanHang obj = new HDBanHang();
                        obj.HDBanHangDataReader(dr);
                        lst.Add(obj);
                    }
                }
            }
            return lst;
        }

        public bool HDBanHang_Insert(HDBanHang data)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("sp_HDBanHang_Add", GetConnection()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@NgayBan", data.NgayBan));
                    cmd.Parameters.Add(new SqlParameter("@TenNhanVien", data.TenNhanVien));
                    cmd.Parameters.Add(new SqlParameter("@ThanhTien", data.ThanhTien));
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public bool HDBanHang_Update(HDBanHang data)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("sp_HDBanHang_Update", GetConnection()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@MaHDBH", data.MaHDBH));
                    cmd.Parameters.Add(new SqlParameter("@NgayBan", data.NgayBan));
                    cmd.Parameters.Add(new SqlParameter("@TenNhanVien", data.TenNhanVien));
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public bool HDBanHang_Delete(string MaHDBH)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("sp_HDBanHang_Delete", GetConnection()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@MaHDBH", MaHDBH));
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
