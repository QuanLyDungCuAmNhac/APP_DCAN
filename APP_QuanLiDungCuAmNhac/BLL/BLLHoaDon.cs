using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BLL
{
    public class BLLHoaDon
    {
        private DALHoaDon dalHoaDon = new DALHoaDon();

        public int SaveHoaDon(HoaDon hoaDon)
        {
            return dalHoaDon.SaveHoaDon(hoaDon);
        }

        public bool SaveChiTietHoaDon(ChiTietHoaDon chiTietHoaDon)
        {
            return dalHoaDon.SaveChiTietHoaDon(chiTietHoaDon);
        }
    }
}
