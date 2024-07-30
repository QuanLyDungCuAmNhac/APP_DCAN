using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{

    public class DALSanPham
    {
        QL_DCANDataContext qldc = new QL_DCANDataContext();
        public DALSanPham()
        {

        }

        public List<SanPham> LoadSP()
        {
            return qldc.SanPhams.Select(nv => nv).ToList<SanPham>();
        }
        public List<SanPham> LoadSPTheoLoai(int maLoai)
        {
            return qldc.SanPhams.Where(sp => sp.MaLoai == maLoai).ToList<SanPham>();
        }
        public void AddSanPham(SanPham sanPham)
        {
            qldc.SanPhams.InsertOnSubmit(sanPham);
            qldc.SubmitChanges();
        }
    }
}
