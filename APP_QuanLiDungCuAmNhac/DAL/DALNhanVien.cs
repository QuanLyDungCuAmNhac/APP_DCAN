using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DALNhanVien
    {
        QL_DCANDataContext qldc = new QL_DCANDataContext();
        public DALNhanVien() 
        { 
            
        }

        public List<NhanVien> LoadNV()
        {
            return qldc.NhanViens.Select(nv => nv).ToList<NhanVien>();
        }

        public bool Login(string TenDangNhap, string MatKhau)
        {
            // var nv = qldc.NhanViens.SingleOrDefault(n => n.TenDangNhap == TenDangNhap && n.MatKhau == MatKhau);
            //  return nv != null;
            return true;
        }
    }
}
