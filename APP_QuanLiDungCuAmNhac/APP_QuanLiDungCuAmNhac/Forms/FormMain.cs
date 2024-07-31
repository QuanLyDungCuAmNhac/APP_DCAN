using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using APP_QuanLiDungCuAmNhac.UserControls;

namespace APP_QuanLiDungCuAmNhac.Forms
{
    public partial class FormMain : Form
    {
        int PanelWidth;
        bool isCollapsed;
        public FormMain()
        {
            InitializeComponent();
            timerTime.Start();
            PanelWidth = panelLeft.Width;
            isCollapsed = false;
           
            UC_BanHang uch = new UC_BanHang();
            AddControlsToPanel(uch);
           
        }
        public void AddControlsToPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            panelControls.Controls.Clear();
            panelControls.Controls.Add(c);
        }

        

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timerTime_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            labelTime.Text = dt.ToString("HH:MM:ss");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

       

        private void button9_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                subMenu.Visible = true;
            }
            else
                subMenu.Visible=false;
        }
        private void btnBanHang_Click(object sender, EventArgs e)
        {
           
            UC_BanHang uch = new UC_BanHang();
            AddControlsToPanel(uch);
        }

        

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                panelLeft.Width = panelLeft.Width + 10;
                if (panelLeft.Width >= PanelWidth)
                {
                    timer1.Stop();
                    isCollapsed = false;
                    this.Refresh();
                }
            }
            else
            {
                panelLeft.Width = panelLeft.Width - 10;
                if (panelLeft.Width <= 59)
                {
                    timer1.Stop();
                    isCollapsed = true;
                    this.Refresh();
                }
            }
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
           
            UC_Home uch = new UC_Home();
            AddControlsToPanel(uch);
        }

        private void btnLoai_Click(object sender, EventArgs e)
        {
            
            UC_Home uch = new UC_Home();
            AddControlsToPanel(uch);
        }

        private void btnThuongHieu_Click(object sender, EventArgs e)
        {
           
            UC_Home uch = new UC_Home();
            AddControlsToPanel(uch);
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            
            UC_Home uch = new UC_Home();
            AddControlsToPanel(uch);
        }

        private void btnKhoHang_Click(object sender, EventArgs e)
        {
            
            UC_Home uch = new UC_Home();
            AddControlsToPanel(uch);
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
           
            UC_Home uch = new UC_Home();
            AddControlsToPanel(uch);
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            
            UC_Home uch = new UC_Home();
            AddControlsToPanel(uch);
        }

        private void btnHeThong_Click(object sender, EventArgs e)
        {
            
            UC_Home uch = new UC_Home();
            AddControlsToPanel(uch);
        }

        private void btnQLSP_Click(object sender, EventArgs e)
        {
            UC_QLSP uC_QLSP = new UC_QLSP(this);
            AddControlsToPanel(uC_QLSP);
        }

        private void btnDQDN_Click(object sender, EventArgs e)
        {
            UC_QLDN uch = new UC_QLDN(this);
            AddControlsToPanel(uch);
        }

        private void btn_QLKho_Click(object sender, EventArgs e)
        {
            UC_QLKho uch = new UC_QLKho(this);
            AddControlsToPanel(uch);
        }

        private void btnThongKe_Click_1(object sender, EventArgs e)
        {
            UC_ThongKe uch = new UC_ThongKe(this);
            AddControlsToPanel(uch);
        }
    }
}
