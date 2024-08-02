using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DALNND
    {
        QL_DCANDataContext qldc = new QL_DCANDataContext();
        public DALNND() { }
        public List<QL_NhomNguoiDung> LoadNND()
        {
            return qldc.QL_NhomNguoiDungs.Select(nv => nv).ToList<QL_NhomNguoiDung>();
        }
    }
}
