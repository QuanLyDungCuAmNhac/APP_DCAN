using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class BLLNhanVien
    {
        DALNhanVien NhanVienDAL = new DALNhanVien();
        public BLLNhanVien()
        {

        }

        public List<NhanVien> LoadNV()
        {
            return NhanVienDAL.LoadNV();
        }

        public bool Login(string TenDangNhap,string MatKhau)
        {
            if(NhanVienDAL.Login(TenDangNhap, MatKhau)== true)
                return true;  
            else
                return false;
        }

        public void UpdateHoatDongNV(int id, bool HoatDong)
        {
            NhanVienDAL.UpdateHoatDongNV(id,HoatDong);
        }
    }
}
