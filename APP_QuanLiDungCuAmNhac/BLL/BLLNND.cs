using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class BLLNND
    {
        DALNND NNDDAL = new DALNND();
        public BLLNND() { }

        public List<QL_NhomNguoiDung> LoadNND()
        {
            return NNDDAL.LoadNND();
        }
    }
}
