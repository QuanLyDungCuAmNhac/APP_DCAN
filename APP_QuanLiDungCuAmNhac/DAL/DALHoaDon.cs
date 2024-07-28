using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class DALHoaDon
    {
        QL_DCANDataContext qldcan = new QL_DCANDataContext();
        public int SaveHoaDon(HoaDon hoaDon)
        {

            qldcan.HoaDons.InsertOnSubmit(hoaDon);
            qldcan.SubmitChanges();
            return hoaDon.MaHD; // Trả về MaHD của hóa đơn vừa được lưu
           
        }

        public bool SaveChiTietHoaDon(ChiTietHoaDon chiTietHoaDon)
        {
            try
            {
                qldcan.ChiTietHoaDons.InsertOnSubmit(chiTietHoaDon);
                qldcan.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                // Log or handle the exception
                return false;
            }
        }
    }
}
