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

        public void setCa(int ca)
        {
            this.ca = ca;
        }

        public void setCurrentDate(DateTime currentDate)
        {
            this.currentDate = currentDate;
        }
        
        public UserControlBlank()
        {
            InitializeComponent();
        }
        private void UserControlBlank_Click(object sender, EventArgs e)
        {
            timer1.Start();
            DatLich datLich = new DatLich(ca, currentDate);
            datLich.Show();
        }

        private void UserControlBlank_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.Silver;
        }

        private void UserControlBlank_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void DisplayShift()
        {
            
            string query = "SELECT * FROM CaHoc c " +
                           "INNER JOIN MonHoc m ON m.MaMon = c.MaMon " +
                           "INNER JOIN Truong t ON t.MaTruong = c.MaTruong " +
                           $"WHERE c.Ca = '{ca}' AND c.Ngay = '{currentDate}'";
            using (SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=QL_CongViec;Integrated Security=True;TrustServerCertificate=True"))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    conn.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        LB_shift.Text = String.Format("{0}\n{1}", reader["TenTruong"].ToString(), reader["TenMon"].ToString());
                    }
                    reader.Close();
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

        private void UserControlBlank_Load(object sender, EventArgs e)
        {
            DisplayShift();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DisplayShift();
        }
    }
}
