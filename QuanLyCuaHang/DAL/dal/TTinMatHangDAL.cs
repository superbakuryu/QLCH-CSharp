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
    public class TTinMatHangDAL : Connect
    {
        public List<TTinMatHang> TTinMatHang_GetByTop(string Top, string Where, string Order)
        {
            List<TTinMatHang> lst = new List<TTinMatHang>();
            using (SqlCommand cmd = new SqlCommand("sp_GetByTop", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Top", Top));
                cmd.Parameters.Add(new SqlParameter("@Where", Where));
                cmd.Parameters.Add(new SqlParameter("@Order", Order));
                cmd.Parameters.Add(new SqlParameter("@Name", "[dbo].[TTMatHang]"));
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        TTinMatHang obj = new TTinMatHang();
                        obj.TTinMatHangDataReader(dr);
                        lst.Add(obj);
                    }
                }
            }
            return lst;
        }

        public bool TTinMatHang_Insert(TTinMatHang data)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("sp_TTMatHang_Add", GetConnection()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@TenMH", data.TenMH));
                    cmd.Parameters.Add(new SqlParameter("@Size", data.Size));
                    cmd.Parameters.Add(new SqlParameter("@SoLuongTon", data.SoLuong));
                    cmd.Parameters.Add(new SqlParameter("@Gia", data.Gia));
                    cmd.Parameters.Add(new SqlParameter("@MoTa", data.MoTa));
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public bool TTinMatHangBan_Update(TTinMatHang data)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("sp_TTinMatHangBan_Update", GetConnection()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@MaMH", data.MaMH));
                    cmd.Parameters.Add(new SqlParameter("@SoLuong", data.SoLuong));
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public bool TTinMatHangNhap_Update(TTinMatHang data)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("sp_TTinMatHangNhap_Update", GetConnection()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@MaMH", data.MaMH));
                    cmd.Parameters.Add(new SqlParameter("@SoLuong", data.SoLuong));
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public bool TTinMatHang_Update(TTinMatHang data)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("sp_TTMatHang_Update", GetConnection()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@MaMH", data.MaMH));
                    cmd.Parameters.Add(new SqlParameter("@TenMH", data.TenMH));
                    cmd.Parameters.Add(new SqlParameter("@Size", data.Size));
                    cmd.Parameters.Add(new SqlParameter("@SoLuong", data.SoLuong));
                    cmd.Parameters.Add(new SqlParameter("@Gia", data.Gia));
                    cmd.Parameters.Add(new SqlParameter("@MoTa", data.MoTa));
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
