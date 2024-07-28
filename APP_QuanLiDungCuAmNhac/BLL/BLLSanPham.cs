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
    }
}
