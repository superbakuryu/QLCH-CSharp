using DAL.dal;
using DAL.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class TaiKhoanBUS
    {
        TaiKhoanDAL cmd = new TaiKhoanDAL();
        public List<TaiKhoan> TaiKhoan_GetByTop(string Top, string Where, string Order)
        {
            return cmd.TaiKhoan_GetByTop(Top, Where, Order);
        }
        public bool TaiKhoan_Insert(TaiKhoan data)
        {
            return cmd.TaiKhoan_Insert(data);
        }
        
        public bool TaiKhoan_UpDate(TaiKhoan data)
        {
            return cmd.TaiKhoan_Update(data);
        }
    }
}
