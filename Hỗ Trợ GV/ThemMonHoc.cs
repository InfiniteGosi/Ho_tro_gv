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
    public partial class ThemMonHoc : Form
    {
        private List<Truong> schoolList = new List<Truong>();
        public ThemMonHoc()
        {
            InitializeComponent();
        }

        // Read all school from data base  
        private void ReadSchools()
        {
            string query = "select * from Truong";
            using (SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=QL_CongViec;Integrated Security=True;TrustServerCertificate=True"))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    conn.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        string maTruong = reader["MaTruong"].ToString();
                        string tenTruong = reader["TenTruong"].ToString();
                        int luongMotCaDay = Convert.ToInt32(reader["Luong1CaDay"]);
                        Truong truong = new Truong(maTruong, tenTruong, luongMotCaDay);
                        // Thêm vào list object các trường
                        schoolList.Add(truong);
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

        private void ThemMonHoc_Load(object sender, EventArgs e)
        {
            // Hiển thị ngày và ca hiện tại của ô đó khi được chọn.
            ReadSchools();
            // Load tên trường lên CB_truong
            foreach (Truong t in schoolList)
            {
                CB_Truong.Items.Add(t);
            }
        }

        private bool SaveSubject()
        {
            string query = "INSERT INTO MonHoc VALUES(@MaMon, @TenMon, @MaTruong)";
            string maTruong = CB_Truong.SelectedItem.ToString().Split('-')[0];
            using (SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=QL_CongViec;Integrated Security=True;TrustServerCertificate=True"))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaMon", TB_MaMon.Text);
                        cmd.Parameters.AddWithValue("@TenMon", TB_TenMon.Text);
                        cmd.Parameters.AddWithValue("@MaTruong", maTruong);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    return false;
                }
                finally
                {
                    conn.Close();
                }
            }
            return true;
        }

        private void BT_Save_Click(object sender, EventArgs e)
        {
            if (TB_MaMon.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng điền mã môn học");
                return;
            }

            if (TB_TenMon.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng điền tên môn học");
            }

            if (CB_Truong.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn trường");
                return;
            }

            if (SaveSubject())
            {
                MessageBox.Show("Thêm môn học thành công");
                this.Close();
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
        }

        private void BT_ThemTruong_Click(object sender, EventArgs e)
        {
            ThemTruong formTruong = new ThemTruong();
            formTruong.ShowDialog();
        }
    }
}
