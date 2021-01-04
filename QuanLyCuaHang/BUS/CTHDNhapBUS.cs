using DAL.dal;
using DAL.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class CTHDNhapBUS
    {
        CTHDNhapDAL cmd = new CTHDNhapDAL();
        public List<CTHDNhap> CTHDNhap_GetByTop(string Top, string Where, string Order)
        {
            return cmd.CTHDNhap_GetByTop(Top, Where, Order);
        }
        public bool CTHDNhap_Insert(CTHDNhap data)
        {
            return cmd.CTHDNhap_Insert(data);
        }
    }
}
