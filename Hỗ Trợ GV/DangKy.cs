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
                MessageBox.Show("Invalid Email");
                TB_NhapEmail.Focus();
                return false;
            }
            return true;
        }
        int vCode = 1000;
        int num = RandomCode();
        private void btn_SendVerify_Click(object sender, EventArgs e)
        {
            timer1.Stop();  
            string to, from, pass;
            to = TB_NhapEmail.Text;
            from = "duyenman19@gmail.com";
            pass = "xglr vuyt mzre mmlp";
            MailMessage message = new MailMessage();
            message.To.Add(to);
            message.From = new MailAddress(from);
            message.Subject = "Your Verification Code:" + num.ToString();
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.UseDefaultCredentials = false;
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, pass);
            try
            {
                smtp.Send(message);
                MessageBox.Show("Verification Code successful", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btn_Register.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error sending verification code: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 

        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=QL_CongViec;Integrated Security=True;TrustServerCertificate=True");
            conn.Open();
            if (CheckValidEmail(TB_NhapEmail.Text))
            {
                MailAddress addr = new MailAddress(TB_NhapEmail.Text);
                string tenDangNhap = addr.User;
                if (TB_Code.Text.Equals(num.ToString()))
                {
                    cmd = new SqlCommand("insert into TaiKhoan values('" + tenDangNhap + "','" + TB_Pass.Text + "')", conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully Register");
                    DangNhap login = new DangNhap();
                    login.ShowDialog();
                }
            }

            conn.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            vCode += 10;
            if (vCode == 9999)
            {
                vCode = 1000;
            }
        }

        
    }
}
