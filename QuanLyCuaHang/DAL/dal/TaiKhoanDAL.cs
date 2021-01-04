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
    public class TaiKhoanDAL : Connect
    {
        public List<TaiKhoan> TaiKhoan_GetByTop(string Top, string Where, string Order)
        {
            List<TaiKhoan> lst = new List<TaiKhoan>();
            using (SqlCommand cmd = new SqlCommand("sp_GetByTop", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Top", Top));
                cmd.Parameters.Add(new SqlParameter("@Where", Where));
                cmd.Parameters.Add(new SqlParameter("@Order", Order));
                cmd.Parameters.Add(new SqlParameter("@Name", "[dbo].[TaiKhoan]"));
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        TaiKhoan obj = new TaiKhoan();
                        obj.TaiKhoanDataReader(dr);
                        lst.Add(obj);
                    }
                }
            }
            return lst;
        }

        public bool TaiKhoan_Insert(TaiKhoan data)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("sp_TaiKhoan_Add", GetConnection()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@TenDangNhap", data.TenDangNhap));
                    cmd.Parameters.Add(new SqlParameter("@MatKhau", data.MatKhau));
                    cmd.Parameters.Add(new SqlParameter("@TenNhanVien", data.TenNhanVien));
                    cmd.Parameters.Add(new SqlParameter("@TrangThai", data.TrangThai));
                    cmd.Parameters.Add(new SqlParameter("@MaQuyen", data.MaQuyen));
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public bool TaiKhoan_Update(TaiKhoan data)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("sp_TaiKhoan_Update", GetConnection()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@TenDangNhap", data.TenDangNhap));
                    cmd.Parameters.Add(new SqlParameter("@MatKhau", data.MatKhau));
                    cmd.Parameters.Add(new SqlParameter("@TenNhanVien", data.TenNhanVien));
                    cmd.Parameters.Add(new SqlParameter("@TrangThai", data.TrangThai));
                    cmd.Parameters.Add(new SqlParameter("@MaQuyen", data.MaQuyen));
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
