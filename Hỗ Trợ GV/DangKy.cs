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
        public static bool getRegisterBtnClicked()
        {
            return registerBtnClicked;
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
                cmd = new SqlCommand("insert into TaiKhoan values('" + tenDangNhap + "','" + TB_Pass.Text + "')", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Đã đăng ký thành công tài khoản, vui lòng quay trở lại trang đăng nhập");
                registerBtnClicked = true;
            }
            conn.Close();
        }
    }
}
