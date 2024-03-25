using Hỗ_Trợ_GV.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
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
                catch
                {
                    MessageBox.Show("Connection error");
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        private void BtnDangKy_Click(object sender, EventArgs e)
        {
            DangKy dk = new DangKy();
            dk.ShowDialog();
            // Khi đăng ký thành công sẽ refresh lại trang đăng nhập
            if (DangKy.GetRegisterBtnClicked())
            {
                this.Refresh();
            }
        }
        private string Decrypt(string encryptedText)
        {
            using (Aes aesAlg = Aes.Create())
            {
                byte[] fixedKey = new byte[] {
                    0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08,
                    0x09, 0x0A, 0x0B, 0x0C, 0x0D, 0x0E, 0x0F, 0x10
                };
                aesAlg.Key = Encoding.UTF8.GetBytes(Convert.ToBase64String(fixedKey));
                aesAlg.IV = new byte[16];

                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msDecrypt = new MemoryStream(Convert.FromBase64String(encryptedText)))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {
                            return srDecrypt.ReadToEnd();
                        }
                    }
                }
            }
        }

        private void BtnDangNhap_Click(object sender, EventArgs e)
        {
            string username = tb_Ten.Text;
            string pwd = TB_MK.Text;

            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Vui lòng nhập tên người dùng");
                return;
            }
            if (string.IsNullOrEmpty(pwd))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu");
                return;
            }

            string encryptedPwd = null;

            string query = $"select MatKhau from TaiKhoan where TenDangNhap = '{username}'";
            using (SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=QL_CongViec;Integrated Security=True;TrustServerCertificate=True"))
            {

                try
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    conn.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        encryptedPwd = reader["Matkhau"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Tài khoản không tồn tại, vui lòng đăng ký");
                        return;
                    }
                }
                catch
                {
                    MessageBox.Show("Kết nối thất bại");
                    return;
                }
            }

            if (Decrypt(encryptedPwd) == pwd && pwd != null)
            {
                MessageBox.Show("Đăng nhập thành công");
                GetTaiKhoanHienTai(username);
                MainForm mainForm = new MainForm();
                mainForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Mật khẩu hoặc tên đăng nhập không đúng");
            }
        }
    }
}
