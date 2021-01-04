using DAL.dal;
using DAL.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class HDBanHangBUS
    {
        HDBanHangDAL cmd = new HDBanHangDAL();
        public List<HDBanHang> HDBanHang_GetByTop(string Top, string Where, string Order)
        {
            return cmd.HDBanHang_GetByTop(Top, Where, Order);
        }
        public bool HDBanHang_Insert(HDBanHang data)
        {
            return cmd.HDBanHang_Insert(data);
        }
        public bool HDBanHang_UpDate(HDBanHang data)
        {
            return cmd.HDBanHang_Update(data);
        }
        public bool HDBanHang_Delete(string MaHDBH)
        {
            return cmd.HDBanHang_Delete(MaHDBH);
        }
    }
}
