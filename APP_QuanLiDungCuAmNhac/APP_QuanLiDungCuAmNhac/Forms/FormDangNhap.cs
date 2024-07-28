﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;

namespace APP_QuanLiDungCuAmNhac.Forms
{
    public partial class FormDangNhap : Form
    {
        BLLNhanVien NhanVienBLL = new BLLNhanVien();
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (NhanVienBLL.Login(textBox1.Text,textBox2.Text) == true)
            {
                using (FormMain fd = new FormMain())
                {
                    fd.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Ten dang nhap hoac mat khau khong dung");
                return;
            } 
                
                
        }
    }
}