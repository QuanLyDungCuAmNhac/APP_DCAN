using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using CloudinaryDotNet;
using APP_QuanLiDungCuAmNhac.My_Control;
namespace APP_QuanLiDungCuAmNhac.UserControls
{
    public partial class UC_SanPham : UserControl
    {
        private Cloudinary cloudinary;
        BLLSanPham bll_sp = new BLLSanPham();
        public UC_SanPham()
        {
            InitializeCloudinary();
            InitializeComponent();
        }

        private void txtTenLoai_TextChanged(object sender, EventArgs e)
        {

        }

        private void UC_SanPham_Load(object sender, EventArgs e)
        {
            dataGridViewSanPham.Font = new Font("Segoe GUI", 12, FontStyle.Regular);
            dataGridViewSanPham.AutoGenerateColumns = false;
            //  dataGridViewSanPham.DataSource = bll_sp.LoadSP();
            LoadSanPhamAsync();
        }
        public async Task LoadSanPhamAsync()
        {
            AddImageColumnToDataGridView();

            // Lấy danh sách sản phẩm từ BLL
            var products = bll_sp.LoadSP();

            // Xóa các hàng hiện tại (nếu có)
            dataGridViewSanPham.Rows.Clear();

            // Lặp qua danh sách sản phẩm và thêm vào DataGridView
            foreach (var product in products)
            {
                // Tạo một hàng mới
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridViewSanPham);

                // Gán giá trị cho các ô
                row.Cells[0].Value = product.MaSP;
                row.Cells[1].Value = product.TenSP;
                row.Cells[2].Value = product.DonGia;
                row.Cells[3].Value = product.SoLuong;
                row.Cells[4].Value = product.MoTa;
                row.Cells[5].Value = product.MaLoai;
                row.Cells[6].Value = product.MaTH;


                var imageCell = (DataGridViewImageCell)row.Cells[7];
                string imageUrl = cloudinary.Api.UrlImgUp.BuildUrl(product.HinhAnh.Trim());
                await LoadImageAsync(imageUrl, imageCell);
                row.Height = 100;
                // Thêm hàng vào DataGridView
                dataGridViewSanPham.Rows.Add(row);
            }
        }
        private void InitializeCloudinary()
        {
            var account = new Account(
                "deuokbfws",
                "248837377936324",
                "KVCmXwtnx9zLnRet4SzN_Lee9xY");

            cloudinary = new Cloudinary(account);
        }

        private async Task LoadImageAsync(string imageUrl, DataGridViewImageCell imageCell)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    byte[] imageBytes = await client.GetByteArrayAsync(imageUrl);
                    using (MemoryStream ms = new MemoryStream(imageBytes))
                    {
                        Image img = Image.FromStream(ms);
                        Bitmap bitmap = new Bitmap(img, new Size(100, 100)); // Điều chỉnh kích thước hình ảnh lớn hơn, bạn có thể điều chỉnh giá trị này
                        imageCell.Value = bitmap;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading image: " + ex.Message);
                imageCell.Value = null; // Đặt hình ảnh mặc định nếu cần
            }
        }
        private void AddImageColumnToDataGridView()
        {
            DataGridViewImageColumn imgColumn = new DataGridViewImageColumn();
            imgColumn.Name = "HinhAnh";
            imgColumn.HeaderText = "Hình Ảnh";
          //  imgColumn.Width = 100; // Thiết lập chiều rộng cột lớn hơn, bạn có thể điều chỉnh giá trị này

            imgColumn.ImageLayout = DataGridViewImageCellLayout.Zoom; // Hoặc DataGridViewImageCellLayout.Stretch
            dataGridViewSanPham.Columns.Add(imgColumn);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmThemSanPham form = new frmThemSanPham();

            // Hiển thị form như một hộp thoại
            form.ShowDialog();
        }
    }
}
