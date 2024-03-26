using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Net;
using System.Security.Cryptography;
using System.IO;

namespace Hỗ_Trợ_GV
{
    public partial class DangKy : Form
    {
        public DangKy()
        {
            InitializeComponent();
        }
        public static int RandomCode()
        {
            Random rdn = new Random();
            int num = rdn.Next(10000, 99999);
            return num;
        }
        public bool CheckValidEmail(String email)
        {
            Regex reg = new Regex(@"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");
            if (!reg.IsMatch(email))
            {
                return false;
            }
            return true;
        }

        public bool CheckIdenticalPassword(String password, String confirmation)
        {
            return password.Equals(confirmation);
        }

        public bool CheckEmptyPassword(String password)
        {
            return String.IsNullOrEmpty(password);
        }

        public bool CheckEmptyConfirmationPassword(String confirmation) 
        { 
            return String.IsNullOrEmpty(confirmation);
        }

        public bool CheckEmptyEmail(String email)
        {
            return String.IsNullOrEmpty(email);
        }

        int num = RandomCode();
        bool allInformationFilled = false;
        private bool CheckEmailAlreadyExists(string email)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=QL_CongViec;Integrated Security=True;TrustServerCertificate=True");
            conn.Open();
            MailAddress addr = new MailAddress(email);
            string tenDangNhap = addr.User;
            string sql = "select * from Taikhoan where TenDangNhap = '" + tenDangNhap + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader data = cmd.ExecuteReader();
            if (data.Read() == true)
            {
                return true;
            }
            return false;
        }
        private void btn_SendVerify_Click(object sender, EventArgs e)
        {
            if (CheckEmptyEmail(TB_NhapEmail.Text))
            {
                MessageBox.Show("Vui lòng không bỏ trống trường Email");
                TB_NhapEmail.Focus();
                return;
            }
            if (!CheckValidEmail(TB_NhapEmail.Text))
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng Email");
                TB_NhapEmail.Focus();
                return;
            }
            if (CheckEmptyPassword(TB_Pass.Text))
            {
                MessageBox.Show("Vui lòng không bỏ trống trường mật khẩu");
                TB_Pass.Focus();
                return;
            }
            if (CheckEmptyConfirmationPassword(TB_PassVerify.Text))
            {
                MessageBox.Show("Vui lòng xác minh mật khẩu");
                TB_PassVerify.Focus();
                return;
            }
            if (!CheckIdenticalPassword(TB_Pass.Text, TB_PassVerify.Text))
            {
                MessageBox.Show("Vui lòng nhập lại mật khẩu xác minh khớp với mật khẩu đã nhập");
                TB_PassVerify.Focus();
                return;
            }
            if (CheckEmailAlreadyExists(TB_NhapEmail.Text))
            {
                MessageBox.Show("Email đã tồn tại trong hệ thống");
                return;
            }

            timer1.Stop();  
            string to, from, pass;
            to = TB_NhapEmail.Text;
            from = "duyenman19@gmail.com";
            pass = "xglr vuyt mzre mmlp";
            MailMessage message = new MailMessage();
            message.To.Add(to);
            message.From = new MailAddress(from);
            message.Subject = "Mã xác nhận của bạn là: " + num.ToString();
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.UseDefaultCredentials = false;
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, pass);
            try
            {
                smtp.Send(message);
                MessageBox.Show("Đã gửi thành công mã xác nhận, vui lòng kiểm tra Email của bạn", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btn_Register.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi khi gửi mã xác nhận: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
            allInformationFilled = true;
        }

        // Lấy trạng thái đăng ký thành công để refresh lại trang đăng nhập
        private static bool registerBtnClicked = false;
        public static bool GetRegisterBtnClicked()
        {
            return registerBtnClicked;
        }
        private string Encrypt(string pwd)
        {
            using (Aes aesAlg = Aes.Create())
            {
                byte[] fixedKey = new byte[] {
                    0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08,
                    0x09, 0x0A, 0x0B, 0x0C, 0x0D, 0x0E, 0x0F, 0x10
                };
                aesAlg.Key = Encoding.UTF8.GetBytes(Convert.ToBase64String(fixedKey));
                aesAlg.IV = new byte[16];

                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            swEncrypt.Write(pwd);
                        }
                        return Convert.ToBase64String(msEncrypt.ToArray());
                    }
                }
            }
        }
        private void btn_Register_Click(object sender, EventArgs e)
        {
            if (!allInformationFilled) 
            {
                MessageBox.Show("Vui lòng nhập thông tin để đăng ký tài khoản");
                return;
            }
            SqlCommand cmd;
            SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=QL_CongViec;Integrated Security=True;TrustServerCertificate=True");
            conn.Open();
            MailAddress addr = new MailAddress(TB_NhapEmail.Text);
            string tenDangNhap = addr.User;

            if (TB_Code.Text.Equals(num.ToString()))
            {
                cmd = new SqlCommand("insert into TaiKhoan values('" + tenDangNhap + "','" + TB_NhapEmail.Text + "', '" + Encrypt(TB_Pass.Text) + "')", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Đã đăng ký thành công tài khoản, vui lòng quay trở lại trang đăng nhập");
                registerBtnClicked = true;
                this.Close();
            }
            conn.Close();
        }

        private void TB_NhapEmail_Enter(object sender, EventArgs e)
        {
            if (TB_NhapEmail.Text == "Email")
            {
                TB_NhapEmail.Text = "";
                TB_NhapEmail.ForeColor = Color.Black;
            }
        }

        private void TB_NhapEmail_Leave(object sender, EventArgs e)
        {
            if (TB_NhapEmail.Text == "")
            {
                TB_NhapEmail.Text = "Email";
                TB_NhapEmail.ForeColor = Color.Silver;
            }
        }

        private void TB_Pass_Enter(object sender, EventArgs e)
        {
            if (TB_Pass.Text == "Mật khẩu")
            {
                TB_Pass.Text = "";
                TB_Pass.ForeColor = Color.Black;
            }
        }

        private void TB_Pass_Leave(object sender, EventArgs e)
        {
            if (TB_Pass.Text == "")
            {
                TB_Pass.Text = "Mật khẩu";
                TB_Pass.ForeColor = Color.Silver;
            }
        }

        private void TB_PassVerify_Enter(object sender, EventArgs e)
        {
            if (TB_PassVerify.Text == "Nhập lại mật khẩu")
            {
                TB_PassVerify.Text = "";
                TB_PassVerify.ForeColor = Color.Black;
            }
        }

        private void TB_PassVerify_Leave(object sender, EventArgs e)
        {
            if (TB_PassVerify.Text == "")
            {
                TB_PassVerify.Text = "Nhập lại mật khẩu";
                TB_PassVerify.ForeColor = Color.Silver;
            }
        }

        private void TB_Code_Enter(object sender, EventArgs e)
        {
            if (TB_Code.Text == "CODE")
            {
                TB_Code.Text = "";
                TB_Code.ForeColor = Color.Black;
            }
        }

        private void TB_Code_Leave(object sender, EventArgs e)
        {
            if (TB_Code.Text == "")
            {
                TB_Code.Text = "CODE";
                TB_Code.ForeColor = Color.Silver;
            }
        }
    }
}
