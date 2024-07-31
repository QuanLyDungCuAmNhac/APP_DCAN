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
using System.Windows.Forms.DataVisualization.Charting;
using DTO;

namespace APP_QuanLiDungCuAmNhac.UserControls
{
    public partial class ThongKeDoanhThu : UserControl
    {
        BLLHoaDon HoaDonBLL = new BLLHoaDon();
        public ThongKeDoanhThu()
        {
            InitializeComponent();
        }

        private void cbbThang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbThang.SelectedItem != null)
            {
                int month = int.Parse(cbbThang.SelectedItem.ToString());
                DisplayDoanhThu(month);
            }
        }

        private void LoadThang()
        {
            // Giả sử bạn có một danh sách tháng, có thể thay đổi cách nạp dữ liệu phù hợp với yêu cầu
            for (int i = 1; i <= 12; i++)
            {
                cbbThang.Items.Add(i.ToString());
            }
        }

        private void DisplayDoanhThu(int month)
        {
            LoadChart(month);
        }

        private void LoadChart(int month)
        {
            
        }

        private void chartDoanhThu_Click(object sender, EventArgs e)
        {

        }
    }
}
