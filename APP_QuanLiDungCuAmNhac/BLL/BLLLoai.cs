﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class BLLLoai
    {
        DALLoaiSP LoaiDAL = new DALLoaiSP();

        public BLLLoai()
        {

        }

        public List<LoaiSP> LoadLoai()
        {
            return LoaiDAL.LoadLoai();
        }
    }
}