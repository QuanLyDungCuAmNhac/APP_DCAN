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
using APP_QuanLiDungCuAmNhac.Forms;

namespace APP_QuanLiDungCuAmNhac.UserControls
{
    public partial class UC_PhanQUyen : UserControl
    {
        BLLPhanQuyen PhanQuyenBLL = new BLLPhanQuyen();
        public UC_PhanQUyen()
        {
            InitializeComponent();
        }

        private void DGVPQ_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UC_PhanQUyen_Load(object sender, EventArgs e)
        {
            DGVPQ.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            LoadPQ();
        }

        public void LoadPQ()
        {
       
            DGVPQ.DataSource = PhanQuyenBLL.LoadPhanQuyen();
           
          
        }

        private void DGVPQ_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DGVPQ.Columns["CoQuyen"].Index)
            {
                string MaNhom = DGVPQ.Rows[e.RowIndex].Cells["MaNhomNguoiDung"].Value.ToString();
                string MaMH = DGVPQ.Rows[e.RowIndex].Cells["MaManHinh"].Value.ToString();
                bool hoatDong = (bool)DGVPQ.Rows[e.RowIndex].Cells["CoQuyen"].Value;

                // Update the database with the new value
                PhanQuyenBLL.UpdatePhanQuyen(MaNhom, MaMH, hoatDong);

                // Find the parent form
                FormMain formMain = (FormMain)this.FindForm();
                if (formMain != null)
                {
                    // Update UI based on the new permission
                    foreach (Control control in formMain.Controls)
                    {
                        formMain.EnableButtonBasedOnTag(control, formMain.LoggedInMaNhomNguoiDung);
                    }
                }
            }
        }    

        private void EnableButtonBasedOnTag(Control control, string tag, bool enabled)
        {
            if (control is Button btn && btn.Tag != null && btn.Tag.ToString() == tag)
            {
                btn.Enabled = enabled;
            }

            // If control has child controls, iterate through them
            foreach (Control childControl in control.Controls)
            {
                EnableButtonBasedOnTag(childControl, tag, enabled); // Recursively check child controls
            }
        }

        private void DGVPQ_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void DGVPQ_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (DGVPQ.IsCurrentCellDirty)
            {
                DGVPQ.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }
    }
}
