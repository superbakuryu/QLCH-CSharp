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
    public class HDXuatDAL: Connect
    {
        public List<HDXuat> HDXuat_GetByTop(string Top, string Where, string Order)
        {
            List<HDXuat> lst = new List<HDXuat>();
            using (SqlCommand cmd = new SqlCommand("sp_GetByTop", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Top", Top));
                cmd.Parameters.Add(new SqlParameter("@Where", Where));
                cmd.Parameters.Add(new SqlParameter("@Order", Order));
                cmd.Parameters.Add(new SqlParameter("@Name", "[dbo].[HDXuat]"));
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        HDXuat obj = new HDXuat();
                        obj.HDXuatDataReader(dr);
                        lst.Add(obj);
                    }
                }
            }
            return lst;
        }

        public bool HDXuat_Insert(HDXuat data)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("sp_HDXuat_Add", GetConnection()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                   // cmd.Parameters.Add(new SqlParameter("@MaHDXuat", data.MaHDXuat));
                    cmd.Parameters.Add(new SqlParameter("@NgayXuat", data.NgayXuat));
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }


        public bool HDXuat_Delete(string MaHDXuat)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("sp_HDXuat_Delete", GetConnection()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@MaHDXuat", MaHDXuat));
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
