using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;

namespace DAL
{
    public class DALLoaiSP
    {
        QL_DCANDataContext qldc = new QL_DCANDataContext();
        
        public DALLoaiSP() 
        {
            
        }

        public List<LoaiSP> LoadLoai()
        {
            return qldc.LoaiSPs.Select(loai=>loai).ToList<LoaiSP>();
        }

        public bool ThemLoai(LoaiSP LoaiSpMoi)
        {
            try
            {
                qldc.LoaiSPs.InsertOnSubmit(LoaiSpMoi);
                qldc.SubmitChanges();
                return true; // Trả về true nếu thêm thành công
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ nếu có lỗi xảy ra
                Console.WriteLine("Lỗi khi thêm loại sản phẩm mới: " + ex.Message);
                return false; // Trả về false nếu thêm không thành công
            }
        }
    }
}
