using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class BLLPhanQuyen
    {
        DALPhanQuyen PhanQuyenDAL = new DALPhanQuyen();
        public BLLPhanQuyen()
        {

        }

        public List<QL_PhanQuyen> LoadPhanQuyen()
        {
            return PhanQuyenDAL.LoadPhanQuyen();
        }

        public void UpdatePhanQuyen(string MaNhom,string MMM,bool quyen)
        {
            PhanQuyenDAL.UpdatePhanQuyen(MaNhom, MMM, quyen);
        }
        public bool CheckPermission(string maNhomNguoiDung, string maManHinh)
        {
            return PhanQuyenDAL.CheckPermission(maNhomNguoiDung,maManHinh);
        }
    }
}
