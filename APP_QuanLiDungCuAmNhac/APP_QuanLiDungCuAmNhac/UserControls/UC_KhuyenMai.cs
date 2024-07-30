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

namespace APP_QuanLiDungCuAmNhac.UserControls
{
    public partial class UC_KhuyenMai : UserControl
    {
        BLLKhuyenMai KhuyenMaiBLL = new BLLKhuyenMai();
        public UC_KhuyenMai()
        {
            InitializeComponent();
            this.Load += UC_KhuyenMai_Load;
        }

        private void UC_KhuyenMai_Load(object sender, EventArgs e)
        {
            dgvKM.Font = new Font("Century", 15);
            dgvKM.ColumnHeadersDefaultCellStyle.Font = new Font("Century", 17, FontStyle.Bold);
            LoadCBBKM();
            LoadDGVKM();
            LoadCBBSP();
        }

        public void LoadDGVKM()
        {
            dgvKM.DataSource = KhuyenMaiBLL.LoadKM();
        }

        public void LoadCBBSP()
        {
            var KMList = KhuyenMaiBLL.LoadSP();
            KMList.Insert(0, new SanPham { MaSP = -1, TenSP = "Tat ca" });
            cbbMaSP.DataSource = KMList;
            cbbMaSP.DisplayMember = "TenSP";
            cbbMaSP.ValueMember = "MaSP";
        }

        public void LoadCBBKM()
        {
            var KMList = KhuyenMaiBLL.LoadKM();
            KMList.Insert(0, new KhuyenMai { MaKM = -1, TenKM = "Tat ca" });
            cbbKM.DataSource = KMList;
            cbbKM.DisplayMember = "TenKM";
            cbbKM.ValueMember = "MaKM";
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string TenLoai = txtKM.Text;
            if (TenLoai == "")
                LoadDGVKM();
            else
                dgvKM.DataSource = KhuyenMaiBLL.LoadKMTheoTen(TenLoai);
        }

        private void cbbKM_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbKM.SelectedIndex != 0)
            {
                int MaKM = int.Parse(cbbKM.SelectedValue.ToString());
                dgvKM.DataSource = KhuyenMaiBLL.LoadKMTheoMa(MaKM);
            }
            else
            {
                dgvKM.DataSource = KhuyenMaiBLL.LoadKM();
            }
        }

        private void dgvKM_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Đảm bảo chỉ thực hiện khi click vào các ô hợp lệ
            {
                txtMaKM.Text = dgvKM.CurrentRow.Cells[0].Value.ToString();
                txtTenKM.Text = dgvKM.CurrentRow.Cells[1].Value.ToString();
                txtGiamGia.Text = dgvKM.CurrentRow.Cells[2].Value.ToString();
                txtNgayBD.Text = dgvKM.CurrentRow.Cells[3].Value.ToString();
                txtNgayKT.Text = dgvKM.CurrentRow.Cells[4].Value.ToString();

                // Lấy giá trị từ ô và gán cho ComboBox
                string maSP = dgvKM.CurrentRow.Cells[5].Value.ToString();
                // Cố gắng parse giá trị MaSP nếu có thể, nếu không, sử dụng giá trị mặc định
                int selectedMaSP;
                if (int.TryParse(maSP, out selectedMaSP))
                {
                    cbbMaSP.SelectedValue = selectedMaSP;
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvKM.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvKM.SelectedRows[0];
                int MaKM = int.Parse(selectedRow.Cells[0].Value.ToString());
                if (KhuyenMaiBLL.IsMaKH(MaKM))
                {
                    MessageBox.Show("Mã khuyến mãi không tồn tại");
                    return;
                }
                KhuyenMaiBLL.XoaKM(MaKM);
                MessageBox.Show("Xoa thanh cong");
                LoadDGVKM();
                LoadCBBKM();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaKM.Text))
            {
                MessageBox.Show("Không được để trống mã khuyến mãi");
                return;
            }
            if (string.IsNullOrEmpty(txtTenKM.Text))
            {
                MessageBox.Show("Không được để trống tên khuyến mãi");
                return;
            }
            if (string.IsNullOrEmpty(txtGiamGia.Text))
            {
                MessageBox.Show("Không được để trống giảm giá");
                return;
            }
            if (string.IsNullOrEmpty(txtNgayBD.Text))
            {
                MessageBox.Show("Không được để trông ngày bắt đầu");
                return;
            }
            if (string.IsNullOrEmpty(txtNgayKT.Text))
            {
                MessageBox.Show("Không được để trông ngày kết thúc");
                return;
            }
         
                KhuyenMai KM = new KhuyenMai();
                KM.MaKM = int.Parse(txtMaKM.Text);
                KM.TenKM = txtTenKM.Text;
                KM.GiamGia = float.Parse(txtGiamGia.Text);
                KM.NgayBD = DateTime.Now;
                KM.NgayKT = DateTime.Now;
                KM.MaSP = int.Parse(cbbMaSP.SelectedValue.ToString());
                KhuyenMaiBLL.UpdateKM(KM);
                MessageBox.Show("Update thành công");
                LoadCBBKM();
                LoadDGVKM();
        }
    }
}
