using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP_QuanLiDungCuAmNhac.UserControls
{
    public partial class UC_NhanVien : UserControl
    {
        BLLNhanVien NhanVienBLL = new BLLNhanVien();
        public UC_NhanVien()
        {
            InitializeComponent();
        }

        private void UC_NhanVien_Load(object sender, EventArgs e)
        {
            DGVNhanVien.Font = new Font("Century", 15);
            DGVNhanVien.ColumnHeadersDefaultCellStyle.Font = new Font("Century", 17, FontStyle.Bold);
            LoadNV();
        }
        public void LoadNV()
        {
            DGVNhanVien.DataSource = NhanVienBLL.LoadNV();
            SetupDataGridViewColumns();
        }

        private void SetupDataGridViewColumns()
        {
            // Assuming that the 'HoatDong' column is at the 6th index (index starts from 0)
            int hoatDongColumnIndex = 6;

            // Remove existing column if already present
            if (DGVNhanVien.Columns["HoatDong"] != null)
            {
                DGVNhanVien.Columns.Remove("HoatDong");
            }

            // Add a new checkbox column for 'HoatDong'
            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.HeaderText = "Hoạt Động";
            checkBoxColumn.Name = "HoatDong";
            checkBoxColumn.DataPropertyName = "HoatDong";
            checkBoxColumn.TrueValue = true;
            checkBoxColumn.FalseValue = false;

            // Insert the checkbox column at the 6th position
            DGVNhanVien.Columns.Insert(hoatDongColumnIndex, checkBoxColumn);
        }

        private void DGVNhanVien_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DGVNhanVien.Columns["HoatDong"].Index)
            {
                int nhanVienId = (int)DGVNhanVien.Rows[e.RowIndex].Cells["MaNV"].Value;
                bool hoatDong = (bool)DGVNhanVien.Rows[e.RowIndex].Cells["HoatDong"].Value;

                // Update the database with the new value
                NhanVienBLL.UpdateHoatDongNV(nhanVienId, hoatDong);
            }
        }

        private void DGVNhanVien_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (DGVNhanVien.IsCurrentCellDirty)
            {
                DGVNhanVien.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenNV.Text))
            {
                MessageBox.Show("Không được để trống mã nhân viên");
                return;
            }
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Không được để trống email");
                return;
            }
            if (string.IsNullOrEmpty(txtSDT.Text))
            {
                MessageBox.Show("Không được để trống số điện thoại");
                return;
            }
            if (string.IsNullOrEmpty(txtUserName.Text))
            {
                MessageBox.Show("Không được để trống tài khoản");
                return;
            }
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Không được để trống mật khẩu");
                return;
            }
            if(NhanVienBLL.KTKC(int.Parse(txtMaNV.Text))!=0)
            {
                MessageBox.Show("Trùng khóa chính");
                return ;
            }    
            NhanVien nv = new NhanVien();
            nv.MaNV = int.Parse(txtMaNV.Text);
            nv.TenNV = txtTenNV.Text;
            nv.SDT = txtSDT.Text;
            nv.Email = txtEmail.Text;
            nv.Username = txtUserName.Text;
            nv.Password = txtPassword.Text;
            nv.HoatDong = false;
            NhanVienBLL.InsertNV(nv);
            LoadNV();
            MessageBox.Show("Thêm thành công");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenNV.Text))
            {
                MessageBox.Show("Không được để trống mã nhân viên");
                return;
            }
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Không được để trống email");
                return;
            }
            if (string.IsNullOrEmpty(txtSDT.Text))
            {
                MessageBox.Show("Không được để trống số điện thoại");
                return;
            }
            if (string.IsNullOrEmpty(txtUserName.Text))
            {
                MessageBox.Show("Không được để trống tài khoản");
                return;
            }
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Không được để trống mật khẩu");
                return;
            }
            NhanVien nv = new NhanVien();
            nv.MaNV = int.Parse(txtMaNV.Text);
            nv.TenNV = txtTenNV.Text;
            nv.SDT = txtSDT.Text;
            nv.Email = txtEmail.Text;
            nv.Username = txtUserName.Text;
            nv.Password = txtPassword.Text;
            nv.HoatDong = false;
            NhanVienBLL.UpdateNV(nv);
            LoadNV();
            MessageBox.Show("Update thành công");
           
        }

        private void DGVNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaNV.Text = DGVNhanVien.CurrentRow.Cells[0].Value.ToString();
            txtTenNV.Text = DGVNhanVien.CurrentRow.Cells[1].Value.ToString();
            txtSDT.Text = DGVNhanVien.CurrentRow.Cells[2].Value.ToString();
            txtEmail.Text = DGVNhanVien.CurrentRow.Cells[3].Value.ToString();
            txtUserName.Text = DGVNhanVien.CurrentRow.Cells[4].Value.ToString();
            txtPassword.Text = DGVNhanVien.CurrentRow.Cells[5].Value.ToString();

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenNV.Text))
            {
                MessageBox.Show("Không được để trống mã nhân viên");
                return;
            }
            NhanVienBLL.XoaNV(int.Parse(txtMaNV.Text));
            LoadNV();
            MessageBox.Show("Xóa thành công");
        }
    }
}
