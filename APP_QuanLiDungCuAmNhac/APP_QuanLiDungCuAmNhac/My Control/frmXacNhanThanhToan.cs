using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;
namespace APP_QuanLiDungCuAmNhac.My_Control
{
    public partial class frmXacNhanThanhToan : Form
    {
        BLLNhanVien bllnv = new BLLNhanVien();
        BLLHoaDon bllHoaDon = new BLLHoaDon();
        BLLSanPham bllsp = new BLLSanPham();
        public event Action OnSaveSuccess;
        public frmXacNhanThanhToan()
        {
            InitializeComponent();
            InitializeDataGridView();
        }
        public DataGridView HoaDonDataGridView
        {
            get { return dataGridView1; }
        }
        public TextBox TongTienTextBox
        {
            get { return textBox1; }
        }
        private void frmXacNhanThanhToan_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = bllnv.LoadNV();
            comboBox1.DisplayMember = "TenNV";
            comboBox1.ValueMember = "MaNV";
            dateTimePicker1.Value = DateTime.Now;
            textBox3.Text = "Tiền Mặt";
        }
        private void InitializeDataGridView()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("TenSP", "Tên Sản Phẩm");
            dataGridView1.Columns.Add("DonGia", "Đơn Giá");
            dataGridView1.Columns.Add("SoLuong", "Số Lượng");
            dataGridView1.Columns.Add("TongTien", "Tổng Tiền");

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
        }

        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {
            try
            {
                // Lưu hóa đơn
                HoaDon hoaDon = new HoaDon
                {
                    MaNV = (int)comboBox1.SelectedValue,
                    NgayDat = dateTimePicker1.Value,
                    HinhThucThanhToan = textBox3.Text,
                    TongTien = decimal.Parse(TongTienTextBox.Text.Replace(" đ", "").Replace(".", ""), NumberStyles.Currency, new CultureInfo("vi-VN"))
                };

                int maHD = bllHoaDon.SaveHoaDon(hoaDon);

                // Lưu chi tiết hóa đơn
                foreach (DataGridViewRow row in HoaDonDataGridView.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        ChiTietHoaDon chiTietHoaDon = new ChiTietHoaDon
                        {
                            MaHD = maHD,
                            MaSP = GetMaSP(row.Cells["TenSP"].Value.ToString()), // Bạn cần có phương thức để lấy MaSP từ tên sản phẩm
                            SoLuong = Convert.ToInt32(row.Cells["SoLuong"].Value),
                            DonGia = Convert.ToDecimal(row.Cells["DonGia"].Value)
                        };

                        if (!bllHoaDon.SaveChiTietHoaDon(chiTietHoaDon))
                        {
                            throw new Exception("Lưu chi tiết hóa đơn không thành công.");
                        }
                    }
                }

                MessageBox.Show("Thanh toán thành công!");
                var result = MessageBox.Show("Thanh toán thành công! Bạn có muốn in hóa đơn không?", "Thông Báo", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    PrintInvoice(maHD); // Method to print the invoice
                }
                OnSaveSuccess?.Invoke();
                this.Close(); // Đóng form sau khi thanh toán thành công
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }
        private void PrintInvoice(int maHD)
        {
            try
            {
                // Lấy danh sách chi tiết hóa đơn
                List<HD> invoiceDetails = new List<HD>();
                foreach (DataGridViewRow row in HoaDonDataGridView.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        invoiceDetails.Add(new HD
                        {
                            TenSP = row.Cells["TenSP"].Value.ToString(),
                            DonGia = Convert.ToDecimal(row.Cells["DonGia"].Value),
                            SoLuong = Convert.ToInt32(row.Cells["SoLuong"].Value),
                            TongTien = Convert.ToDecimal(row.Cells["TongTien"].Value)
                        });
                    }
                }

                // Tạo báo cáo và thiết lập nguồn dữ liệu
                CrystalReport1 rpt = new CrystalReport1(); // Thay thế bằng tên báo cáo của bạn
                rpt.SetDataSource(invoiceDetails);

                // Thiết lập các tham số nếu cần
                rpt.SetParameterValue("MaHD", maHD);
                rpt.SetParameterValue("NgayDat", dateTimePicker1.Value);
                rpt.SetParameterValue("HinhThucThanhToan", textBox3.Text);
                rpt.SetParameterValue("TongTien", decimal.Parse(TongTienTextBox.Text.Replace(" đ", "").Replace(".", ""), NumberStyles.Currency, new CultureInfo("vi-VN")));

                // Hiển thị báo cáo
                frmInHD reportViewer = new frmInHD(); // Form chứa CrystalReportViewer
                reportViewer.crystalReportViewer1.ReportSource = rpt;
                reportViewer.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra khi in hóa đơn: " + ex.Message);
            }
        }



        private int GetMaSP(string tenSP)
        {
            // Implement this method to return the product ID based on the product name
            // Example implementation:
            var products = bllsp.LoadSP();
            var product = products.FirstOrDefault(p => p.TenSP == tenSP);
            return product?.MaSP ?? 0;
        }
    }
}
