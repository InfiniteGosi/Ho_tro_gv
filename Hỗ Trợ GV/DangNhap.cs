using Hỗ_Trợ_GV.Model;
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
        public static TaiKhoan taiKhoanHienTai;
        private void GetTaiKhoanHienTai(string tenTaiKhoan)
        {
            string query = $"select * from Taikhoan where TenDangNhap = '{tenTaiKhoan}'";
            using (SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=QL_CongViec;Integrated Security=True;TrustServerCertificate=True"))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    conn.Open();

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                        taiKhoanHienTai = new TaiKhoan(reader["TenDangNhap"].ToString(), reader["MatKhau"].ToString(), reader["Email"].ToString());
                    cmd.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection error");
                }
                finally
                {
                    conn.Close();
                }
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
                    MessageBox.Show("Đăng nhập thành công");
                    GetTaiKhoanHienTai(tk);
                    MainForm mainForm = new MainForm();
                    mainForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại");
                }
                conn.Close();
                cmd.Dispose();
            }
            catch (Exception)
            {
                throw new Exception("Kết nối thất bại");
            }
        }

    }
}
