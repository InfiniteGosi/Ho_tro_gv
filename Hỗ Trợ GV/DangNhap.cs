using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hỗ_Trợ_GV
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            DangKy dk = new DangKy();
            dk.ShowDialog();
            // Khi đăng ký thành công sẽ refresh lại trang đăng nhập
            if (DangKy.getRegisterBtnClicked())
            {
                this.Refresh();
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=QL_CongViec;Integrated Security=True;TrustServerCertificate=True");
            try
            {
                conn.Open();
                string tk = tb_Ten.Text;
                string mk = TB_MK.Text;
                string sql = "select * from Taikhoan where TenDangNhap = '" + tk + "' and Matkhau = '" + mk + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader data = cmd.ExecuteReader();
                if (data.Read() == true)
                {
                    MessageBox.Show("Login successfully");
                    MainForm mainForm = new MainForm();
                    this.Hide();
                    mainForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Failed to login");
                }
                conn.Close();
            }
            catch (Exception)
            {
                throw new Exception("Connection Error");
            }
        }

    }
}
