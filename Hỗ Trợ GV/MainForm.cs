using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hỗ_Trợ_GV
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private Form currentFormChild;
        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pn_main.Controls.Add(childForm);
            pn_main.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void bnt_lichday_Click(object sender, EventArgs e)
        {
            OpenChildForm(new LichDay());
        }

        private void btn_tinhluong_Click(object sender, EventArgs e)
        {
            OpenChildForm(new TinhLuong());
        }

        private void btn_thongke_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ThongKe());
        }

        private void btn_dangxuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
