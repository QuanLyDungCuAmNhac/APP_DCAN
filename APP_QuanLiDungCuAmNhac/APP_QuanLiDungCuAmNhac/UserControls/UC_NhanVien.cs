using BLL;
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
    }
}
