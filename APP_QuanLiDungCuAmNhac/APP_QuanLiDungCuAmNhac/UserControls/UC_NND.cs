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
    public partial class UC_NND : UserControl
    {
        BLLNND NNDBLL = new BLLNND();
        public UC_NND()
        {
            InitializeComponent();
        }

        private void UC_NND_Load(object sender, EventArgs e)
        {
            DGVNND.DataSource = NNDBLL.LoadNND();
        }
    }
}
