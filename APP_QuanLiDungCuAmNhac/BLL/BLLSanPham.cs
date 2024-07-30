using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DAL;
using DTO;

namespace BLL
{
    public class BLLSanPham
    {
        DALSanPham SanPhamDAL = new DALSanPham();
        public BLLSanPham()
        {

        }

        public List<SanPham> LoadSP()
        {
            return SanPhamDAL.LoadSP();
        }
        public List<SanPham> LoadSPTheoLoai(int maLoai)
        {
            return SanPhamDAL.LoadSPTheoLoai(maLoai);
        }
        public void AddSanPham(string tenSP, decimal donGia, int soLuong, string hinhAnh, string moTa, int maLoai, int maThuongHieu, int trangThai)
        {
            var product = new SanPham
            {
                
                TenSP = tenSP,
                DonGia = donGia,
                SoLuong = soLuong,
                HinhAnh = hinhAnh,
                MoTa = moTa,
                MaLoai = maLoai,
                MaTH = maThuongHieu,
                TrangThai = trangThai
            };

            SanPhamDAL.AddSanPham(product);
        }
    }
}
