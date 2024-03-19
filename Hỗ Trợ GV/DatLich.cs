using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hỗ_Trợ_GV.Model;

namespace Hỗ_Trợ_GV
{
    public partial class DatLich : Form
    {
        private int ca;
        private DateTime currentDate;
        private string maMon;
        private string maTruong;
        private List<Truong> schoolList = new List<Truong>();
        private List<MonHoc> subjList = new List<MonHoc>();
        public DatLich()
        {
            InitializeComponent();
        }

        public DatLich(int ca, DateTime currentDate)
        {
            InitializeComponent();
            this.ca = ca;
            this.currentDate = currentDate;
        }
        // Đọc thông tin trường từ csdl và tạo object mới từ lớp trường
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
        private void DatLich_Load(object sender, EventArgs e)
        {
            // Hiển thị ngày và ca hiện tại của ô đó khi được chọn.
            LB_shiftinfo.Text = $"Ca {ca}  {currentDate.ToString("dd/MM/yyyy")}";
            ReadSchools();
            // Load tên trường lên CB_truong
            foreach(Truong t in schoolList)
            {
                CB_truong.Items.Add(t);
            }
        }

        // Đọc thông tin môn học thông qua mã trường và tạo object môn học
        private void ReadSubjects(string maTruong)
        {
            string query = "select * from MonHoc where MaTruong = '" + maTruong + "'";
            using (SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=QL_CongViec;Integrated Security=True;TrustServerCertificate=True"))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    conn.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        string maMon = reader["MaMon"].ToString();
                        string tenMon = reader["TenMon"].ToString();
                        MonHoc monhoc = new MonHoc(maMon, tenMon);
                        // Thêm vào list object
                        subjList.Add(monhoc);
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
        // Khi CB_truong thay đổi thì các môn sẽ thay đổi tương ứng với trường đó
        private void CB_truong_SelectedIndexChanged(object sender, EventArgs e)
        {
            subjList.Clear();
            CB_monhoc.Items.Clear();
            CB_monhoc.ResetText();
            string maTruong = CB_truong.SelectedItem.ToString().Split('-')[0];
            ReadSubjects(maTruong);
            foreach (MonHoc m in subjList)
            {
                CB_monhoc.Items.Add(m);
            }
        }
        // Lưu ca học đã đăng ký vào csdl
        private bool SaveShift()
        {
            string query = "INSERT INTO CaHoc VALUES(@CurrentDate, @Ca, @MaMon, @MaTruong, @TenTaiKhoan)";

            using (SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=QL_CongViec;Integrated Security=True;TrustServerCertificate=True"))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@CurrentDate", currentDate);
                        cmd.Parameters.AddWithValue("@Ca", ca);
                        cmd.Parameters.AddWithValue("@MaMon", maMon);
                        cmd.Parameters.AddWithValue("@MaTruong", maTruong);
                        cmd.Parameters.AddWithValue("@TenTaiKhoan", DangNhap.taiKhoanHienTai.TenDangNhap);
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
        // Gọi hàm lưu ca học
        private void BT_save_Click(object sender, EventArgs e)
        {
            maMon = CB_monhoc.SelectedItem.ToString().Split('-')[0];
            maTruong = CB_truong.SelectedItem.ToString().Split('-')[0];
            if (SaveShift())
            { 
                MessageBox.Show("Đã lưu ca dạy");
            }
            else
            {
                MessageBox.Show("Lưu thất bại");
            }
        }
    }
}
