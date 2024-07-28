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
using APP_QuanLiDungCuAmNhac.My_Control;
using System.IO;
using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using System.Globalization;

namespace APP_QuanLiDungCuAmNhac.UserControls
{
    public partial class UC_BanHang : UserControl
    {
        BLLSanPham bllsp = new BLLSanPham();
        BLLLoai bllloai = new BLLLoai();
        public UC_BanHang()
        {
            InitializeComponent();
            InitializeDataGridView();
            btn_TienMat.Enabled = btn_ChuyenKhoan.Enabled = false;
        }

        private void sanPhamBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();


        }
        private void InitializeDataGridView()
        {
            dataGridViewHoaDon.Columns.Clear();
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn
            {
                Name = "Xoa",
                Text = "Xóa",
                UseColumnTextForButtonValue = true,
                Width = 12,
                FlatStyle = FlatStyle.Flat,
                HeaderText = "",
                FillWeight = 24

            };
            
            dataGridViewHoaDon.Columns.Add(buttonColumn);

            // Thêm các cột khác
            dataGridViewHoaDon.Columns.Add("TenSP", "Tên Sản Phẩm");
            dataGridViewHoaDon.Columns.Add("DonGia", "Đơn Giá");
            dataGridViewHoaDon.Columns.Add("SoLuong", "Số Lượng");
            dataGridViewHoaDon.Columns.Add("TongTien", "Tổng Tiền");

            // Đặt các thuộc tính cho DataGridView
            dataGridViewHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewHoaDon.AllowUserToAddRows = false;
            dataGridViewHoaDon.AllowUserToDeleteRows = false;
            dataGridViewHoaDon.CellContentClick += dataGridViewHoaDon_CellContentClick_1;
        }

      
        private void UC_BanHang_Load(object sender, EventArgs e)
        {
            LoadSanPham();
            LoadLoai();
            btn_TienMat.Enabled = btn_ChuyenKhoan.Enabled = dataGridViewHoaDon.Rows.Count > 0;
            comboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedCategoryId = (int)comboBox1.SelectedValue;

            // Tải lại sản phẩm theo mã loại sản phẩm
            LoadSanPham(selectedCategoryId);
        }

        public void LoadLoai()
        {
            
            comboBox1.DisplayMember = "TenLoai";
            comboBox1.ValueMember = "MaLoai";
            comboBox1.DataSource = bllloai.LoadLoai();
            
        }
        public void LoadSanPham(int categoryId = 0)
        {
            flowLayoutPanel1.Controls.Clear();
            var products = bllsp.LoadSP();
            if (categoryId != 0)
            {
                products = bllsp.LoadSPTheoLoai(categoryId);
            }
            else
            {
                products = bllsp.LoadSP();
            }
            var cloudinary = new Cloudinary(new Account(
            "deuokbfws",
            "248837377936324",
            "KVCmXwtnx9zLnRet4SzN_Lee9xY"));

            foreach (var product in products)
            {
                // Lấy URL của hình ảnh từ tên ảnh
                var imageUrl = cloudinary.Api.UrlImgUp.BuildUrl(product.HinhAnh.Trim());

                var sanPhamControl = new My_Control.SanPham
                {
                    TenSP = product.TenSP,
                    Price = product.DonGia.ToString(),
                    ImageUrl = imageUrl,
                    //Location = new System.Drawing.Point(x, y)
                };
                sanPhamControl.Click += (s, e) => OnProductClick(product);
                flowLayoutPanel1.Controls.Add(sanPhamControl);
            }
        }
        private void UpdateTongTien()
        {
            decimal totalAmount = 0;

            // Duyệt qua các hàng của DataGridView và cộng giá trị của cột giá
            foreach (DataGridViewRow row in dataGridViewHoaDon.Rows)
            {
                if (row.Cells["TongTien"].Value != null)
                {
                    totalAmount += Convert.ToDecimal(row.Cells["TongTien"].Value);
                }
            }
            CultureInfo vietnamCulture = new CultureInfo("vi-VN");
            //textBoxTongTien.Text = totalAmount.ToString("C", vietnamCulture);
            // Hiển thị tổng tiền trong TextBox
            textBox2.Text = totalAmount.ToString("N0",vietnamCulture) + " đ";
        }
        private void OnProductClick(DTO.SanPham product)
        {
            foreach (DataGridViewRow row in dataGridViewHoaDon.Rows)
            {
                if (row.IsNewRow) continue;

                // Kiểm tra nếu ô "TenSP" không phải là null và so sánh với tên sản phẩm
                if (row.Cells["TenSP"].Value != null &&
                    row.Cells["TenSP"].Value.ToString() == product.TenSP)
                {
                    // Cập nhật số lượng và tổng tiền
                    int currentQuantity = Convert.ToInt32(row.Cells["SoLuong"].Value);
                    currentQuantity += 1;
                    row.Cells["SoLuong"].Value = currentQuantity;
                    row.Cells["TongTien"].Value = currentQuantity * Convert.ToDouble(row.Cells["DonGia"].Value);
                    return;
                }
            }

            // Nếu sản phẩm chưa có trong DataGridView, thêm mới
            dataGridViewHoaDon.Rows.Add(null,product.TenSP, product.DonGia, 1, product.DonGia);
            UpdateTongTien();
            // Nếu sản phẩm chưa có trong DataGridView, thêm mới
            btn_TienMat.Enabled = btn_ChuyenKhoan.Enabled = dataGridViewHoaDon.Rows.Count > 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal totalAmount = 0;
            frmXacNhanThanhToan frm = new frmXacNhanThanhToan();

          
            // Cấu hình Form để tự động điều chỉnh kích thước
         //   frm.AutoSize = true;
            frm.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.Dock = DockStyle.Fill;
            frm.OnSaveSuccess += Frm_OnSaveSuccess;
            // Hiển thị Form
            foreach (DataGridViewRow row in dataGridViewHoaDon.Rows)
            {
                if (!row.IsNewRow)
                {
                    frm.HoaDonDataGridView.Rows.Add(row.Cells["TenSP"].Value,
                                                       row.Cells["DonGia"].Value,
                                                       row.Cells["SoLuong"].Value,
                                                       row.Cells["TongTien"].Value);
                    totalAmount += Convert.ToDecimal(row.Cells["TongTien"].Value);
                }

            }
            CultureInfo vietnamCulture = new CultureInfo("vi-VN");
            //textBoxTongTien.Text = totalAmount.ToString("C", vietnamCulture);
            // Hiển thị tổng tiền trong TextBox
            frm.TongTienTextBox.Text = totalAmount.ToString("N0", vietnamCulture) + " đ";
            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridViewHoaDon_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridViewHoaDon.Columns["Xoa"].Index)
            {
                // Kiểm tra nếu có hàng nào trong DataGridView
                if (dataGridViewHoaDon.Rows.Count > e.RowIndex)
                {
                    // Xóa hàng tại e.RowIndex
                    dataGridViewHoaDon.Rows.RemoveAt(e.RowIndex);
                    UpdateTongTien();
                   btn_TienMat.Enabled = btn_ChuyenKhoan.Enabled = dataGridViewHoaDon.Rows.Count > 0;
                }
            }
        }

        private void dataGridViewHoaDon_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                
                using (SolidBrush brush = new SolidBrush(Color.SteelBlue)) // Thay đổi màu nền ở đây
                {
                    e.Graphics.FillRectangle(brush, e.CellBounds);
                }

               
                using (SolidBrush textBrush = new SolidBrush(Color.White)) // Thay đổi màu văn bản ở đây
                {
                    e.Graphics.DrawString(e.Value?.ToString() ?? "", e.CellStyle.Font, textBrush, e.CellBounds,
                        new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });
                }
                e.Handled = true;
            }
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            int selectedCategoryId = (int)comboBox1.SelectedValue;

            // Tải lại sản phẩm theo mã loại sản phẩm
            LoadSanPham(selectedCategoryId);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        private bool isFormatting = false;
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (isFormatting) return;

            isFormatting = true;

            try
            {
                // Lấy giá trị hiện tại của textBox3 và loại bỏ dấu chấm
                string text = textBox3.Text.Replace(".", "");

                // Chuyển đổi giá trị thành số thập phân
                if (decimal.TryParse(text, out decimal tienKhachDua))
                {
                    // Định dạng lại giá trị với dấu chấm ngăn cách hàng nghìn
                    textBox3.Text = tienKhachDua.ToString("N0", new CultureInfo("vi-VN"));
                    textBox3.SelectionStart = textBox3.Text.Length; // Đặt con trỏ chuột ở cuối TextBox

                    // Tính tiền thừa và cập nhật textBox4
                    decimal totalAmount = decimal.Parse(textBox2.Text.Replace(" đ", "").Replace(".", ""), NumberStyles.Currency, new CultureInfo("vi-VN"));
                    decimal tienThua = tienKhachDua - totalAmount;
                    textBox4.Text = tienThua.ToString("N0", new CultureInfo("vi-VN")) + " đ";
                }
            }
            catch
            {
                textBox4.Text = "0 đ";
            }
            finally
            {
                isFormatting = false;
            }
        }
        private void Frm_OnSaveSuccess()
        {
            dataGridViewHoaDon.Rows.Clear();
            UpdateTongTien();
        }
    }
    
}
