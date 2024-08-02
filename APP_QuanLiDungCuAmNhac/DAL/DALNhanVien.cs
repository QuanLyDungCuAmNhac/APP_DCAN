using System;
using System.Collections;
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
            var nv = qldc.NhanViens.SingleOrDefault(n => n.Username == TenDangNhap && n.Password == MatKhau);
            return nv != null;
            //return true;
        }

        public void UpdateHoatDongNV (int id, bool HoatDong)
        {
            var NV = qldc.NhanViens.FirstOrDefault(l => l.MaNV == id);
            if (NV != null)
            {
                NV.HoatDong = HoatDong;
                qldc.SubmitChanges();
            }
            else
                throw new Exception("NV không tồn tại.");
        }
    }
}
