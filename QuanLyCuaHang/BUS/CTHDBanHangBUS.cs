using DAL.dal;
using DAL.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class CTHDBanHangBUS 
    {
        CTHDBanHangDAL cmd = new CTHDBanHangDAL();
        public List<CTHDBanHang> CTHDBanHang_GetByTop(string Top, string Where, string Order)
        {
            return cmd.CTHDBanHang_GetByTop(Top, Where, Order);
        }
        public bool CTHDBanHang_Insert(CTHDBanHang data)
        {
            return cmd.CTHDBanHang_Insert(data);
        }
    }
}
