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
    public partial class UserControlBlank : UserControl
    {
        private int ca;
        private DateTime currentDate;
        private Color tmpColor;

        public void SetCa(int ca)
        {
            this.ca = ca;
        }

        public void SetCurrentDate(DateTime currentDate)
        {
            this.currentDate = currentDate;
        }
        
        public UserControlBlank()
        {
            InitializeComponent();
        }
        private void UserControlBlank_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(LB_shift.Text))
            {
                TM_datlich.Start();
                DatLich datLich = new DatLich(ca, currentDate);
                datLich.Show();
            }
            else
            {
                TM_suaxoalich.Start();
                SuaVaXoaLich suaVaXoa = new SuaVaXoaLich(ca, currentDate);
                suaVaXoa.Show();
            }
            
        }
        // Hover các ô sẽ có hiệu ứng đổi màu
        private void UserControlBlank_MouseEnter(object sender, EventArgs e)
        {
            tmpColor = this.BackColor;
            if (this.BackColor == Color.White)
            {
                this.BackColor = Color.Silver;
            }
        }

        private void UserControlBlank_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = tmpColor;
        }
        // Hàm đọc thông tin ca học từ csdl và hiện thông tin ca học của một ô
        private void DisplayShift()
        {
            string query = "SELECT * FROM CaHoc c " +
                           "INNER JOIN MonHoc m ON m.MaMon = c.MaMon " +
                           "INNER JOIN Truong t ON t.MaTruong = c.MaTruong " +
                           $"WHERE c.Ca = '{ca}' AND c.Ngay = '{currentDate}' AND c.TenDangNhap = '{DangNhap.taiKhoanHienTai.TenDangNhap}'";
            using (SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=QL_CongViec;Integrated Security=True;TrustServerCertificate=True"))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    conn.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        LB_shift.MaximumSize = new Size(100, 0);
                        LB_shift.AutoSize = true;
                        LB_shift.Text = String.Format("Trường: {0}\nMôn: {1}", reader["TenTruong"].ToString(), reader["TenMon"].ToString());
                        Color selectedColor = Color.FromName(reader["Mau"].ToString());
                        this.BackColor = selectedColor;
                    }
                    else
                    {
                        LB_shift.Text = "";
                        this.BackColor= Color.White;
                    }
                    reader.Close();
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
        // Gọi hàm hiện thông tin ca học mỗi khi các ô được load lên
        private void UserControlBlank_Load(object sender, EventArgs e)
        {
            DisplayShift();
        }

        // Gọi hàm hiện thông tin ca học trên ô đã chọn mỗi khi lưu ca học mới
        private void TM_datlich_Tick(object sender, EventArgs e)
        {
            DisplayShift();
        }

        private void TM_suaxoalich_Tick(object sender, EventArgs e)
        {
            DisplayShift();
        }

        private void LB_shift_Click(object sender, EventArgs e)
        {
            TM_suaxoalich.Start();
            SuaVaXoaLich suaVaXoa = new SuaVaXoaLich(ca, currentDate);
            suaVaXoa.Show();
        }
    }
}
