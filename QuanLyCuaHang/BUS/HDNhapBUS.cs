using DAL.dal;
using DAL.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class HDNhapBUS
    {
        HDNhapDAL cmd = new HDNhapDAL();
        public List<HDNhap> HDNhap_GetByTop(string Top, string Where, string Order)
        {
            return cmd.HDNhap_GetByTop(Top, Where, Order);
        }
        public bool HDNhap_Insert(HDNhap data)
        {
            return cmd.HDNhap_Insert(data);
        }
        public bool HDNhap_Delete(string MaHDNhap)
        {
            return cmd.HDNhap_Delete(MaHDNhap);
        }
    }
}
