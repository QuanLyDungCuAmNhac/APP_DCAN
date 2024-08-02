using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DALPhanQuyen
    {
        QL_DCANDataContext qldc = new QL_DCANDataContext();
        public DALPhanQuyen() { }

        public List<QL_PhanQuyen> LoadPhanQuyen()
        {
            return qldc.QL_PhanQuyens.ToList<QL_PhanQuyen>();
        }

        public void UpdatePhanQuyen(string MaNhom,string MaManHinh,bool quyen)
        {
            var Loai = qldc.QL_PhanQuyens.FirstOrDefault(l => l.MaNhomNguoiDung == MaNhom && l.MaManHinh == MaManHinh);
            if (Loai != null)
            {
               Loai.CoQuyen = quyen;
                qldc.SubmitChanges();
            }
            else
                throw new Exception("Nhóm quyền không tồn tại.");
        }

        public bool CheckPermission(string maNhomNguoiDung, string maManHinh)
        {
            // Thực hiện truy vấn kiểm tra quyền hạn từ cơ sở dữ liệu     
                var permission = qldc.QL_PhanQuyens
                    .FirstOrDefault(p => p.MaNhomNguoiDung == maNhomNguoiDung && p.MaManHinh == maManHinh);

                return permission != null && permission.CoQuyen;  
        }
    }
}
