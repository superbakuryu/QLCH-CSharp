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
    public class HDNhapDAL : Connect
    {
        public List<HDNhap> HDNhap_GetByTop(string Top, string Where, string Order)
        {
            List<HDNhap> lst = new List<HDNhap>();
            using (SqlCommand cmd = new SqlCommand("sp_GetByTop", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Top", Top));
                cmd.Parameters.Add(new SqlParameter("@Where", Where));
                cmd.Parameters.Add(new SqlParameter("@Order", Order));
                cmd.Parameters.Add(new SqlParameter("@Name", "[dbo].[HDNhap]"));
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        HDNhap obj = new HDNhap();
                        obj.HDNhapDataReader(dr);
                        lst.Add(obj);
                    }
                }
            }
            return lst;
        }

        public bool HDNhap_Insert(HDNhap data)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("sp_HDNhap_Add", GetConnection()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    //cmd.Parameters.Add(new SqlParameter("@MaHDNhap", data.MaHDNhap));
                    cmd.Parameters.Add(new SqlParameter("@NgayNhap", data.NgayNhap));
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }


        public bool HDNhap_Delete(string MaHDNhap)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("sp_HDNhap_Delete", GetConnection()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@MaHDNhap", MaHDNhap));
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
