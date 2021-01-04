using DAL.dal;
using DAL.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class TTinMatHangBUS
    {
        TTinMatHangDAL cmd = new TTinMatHangDAL();
        public List<TTinMatHang> TTinMatHang_GetByTop(string Top, string Where, string Order)
        {
            return cmd.TTinMatHang_GetByTop(Top, Where, Order);
        }
        public bool TTinMatHang_Insert(TTinMatHang data)
        {
            return cmd.TTinMatHang_Insert(data);
        }
        public bool TTinMatHangBan_UpDate(TTinMatHang data)
        {
            return cmd.TTinMatHangBan_Update(data);
        }
        public bool TTinMatHangNhap_UpDate(TTinMatHang data)
        {
            return cmd.TTinMatHangNhap_Update(data);
        }
        public bool TTinMatHang_UpDate(TTinMatHang data)
        {
            return cmd.TTinMatHang_Update(data);
        }
    }
}
