using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using System;
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
namespace APP_QuanLiDungCuAmNhac.My_Control
{
    public partial class frmThemSanPham : Form
    {
        BLLSanPham bll_sp = new BLLSanPham();
        
        public frmThemSanPham()
        {
            InitializeComponent();
        }

        private void btn_ChonHinh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp",
                Title = "Select an Image"
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox_HinhAnh.Image = Image.FromFile(openFileDialog.FileName);
                txt_Url.Text = openFileDialog.FileName;
            }
        }

        private async void btn_Luu_Click(object sender, EventArgs e)
        {
          //  string maSP = txt_MaSP.Text;
            string tenSP = txt_TenSP.Text;
            decimal donGia = decimal.Parse(txt_DonGia.Text);
            int soLuong = int.Parse(txt_SoLuong.Text);
            string moTa = txt_MoTa.Text;
            int maLoai = int.Parse(txt_MaLoai.Text);
            int maThuongHieu = int.Parse(txt_MaTH.Text);
            int trangThai = int.Parse(txt_TrangThai.Text);

            // Upload image to Cloudinary and get URL
            string hinhAnhUrl = await UploadImageToCloudinaryAsync();

            bll_sp.AddSanPham(tenSP, donGia, soLuong, hinhAnhUrl, moTa, maLoai, maThuongHieu, trangThai);

         //  LoadProducts(); // Reload data grid view
        }
        private async Task<string> UploadImageToCloudinaryAsync()
        {
            // Assuming you have a method to get the image file
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() != DialogResult.OK)
            {
                return null;
            }

            string imageFilePath = openFileDialog.FileName;

            try
            {
                var cloudinary = new Cloudinary(new Account("deuokbfws", "248837377936324", "KVCmXwtnx9zLnRet4SzN_Lee9xY"));
                var uploadParams = new ImageUploadParams
                {
                    File = new FileDescription(imageFilePath),
                    Transformation = new Transformation().Width(500).Height(500).Crop("limit")
                };
                var uploadResult = await cloudinary.UploadAsync(uploadParams);

                return uploadResult.SecureUrl.ToString(); // Return the URL of the uploaded image
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error uploading image: " + ex.Message);
                return null;
            }
        }
    }
}

