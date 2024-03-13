using Hỗ_Trợ_GV.Model;
using Hỗ_Trợ_GV.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.Design.WebControls;
using System.Windows.Forms;

namespace Hỗ_Trợ_GV
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            UC_LichDay uC_LichDay = new UC_LichDay();
            AddUserControl(uC_LichDay);
        }

        private void bt_DangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void btn_LichDay_Click(object sender, EventArgs e)
        {
            UC_LichDay uC_LichDay = new UC_LichDay();
            AddUserControl(uC_LichDay);
        }

        private void btn_TinhLuong_Click(object sender, EventArgs e)
        {
            UC_TinhLuong uC_TinhLuong = new UC_TinhLuong();
            AddUserControl(uC_TinhLuong);
        }

        private void btn_ThongKe_Click(object sender, EventArgs e)
        {
            UC_ThongKe uC_ThongKe = new UC_ThongKe();
            AddUserControl(uC_ThongKe);
        }
    }
}
