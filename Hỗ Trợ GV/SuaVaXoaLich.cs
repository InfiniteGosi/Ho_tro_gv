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
    public partial class SuaVaXoaLich : Form
    {
        private readonly int ca;
        private readonly DateTime currentDate;
        private string maMon;
        private string maTruong;
        private string mau;
        private readonly List<Truong> schoolList = new List<Truong>();
        private readonly List<MonHoc> subjList = new List<MonHoc>();
        public static bool shiftDeleted = false;
        public SuaVaXoaLich()
        {
            InitializeComponent();
        }
        public SuaVaXoaLich(int ca, DateTime currentDate)
        {
            InitializeComponent();
            this.ca = ca;
            this.currentDate = currentDate;

            AddColorToCBColor();
            CB_color.MaxDropDownItems = 10;
            CB_color.IntegralHeight = false;
            CB_color.DrawMode = DrawMode.OwnerDrawFixed;
            CB_color.DropDownStyle = ComboBoxStyle.DropDownList;
            CB_color.DrawItem += CB_color_DrawItem;
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

        private void SuaVaXoaLich_Load(object sender, EventArgs e)
        {
            // Hiển thị ngày và ca hiện tại của ô đó khi được chọn.
            LB_shiftinfo.Text = $"Ca {ca}  {currentDate:dd/MM/yyyy}";
            ReadSchools();
            // Load tên trường lên CB_truong
            foreach (Truong t in schoolList)
            {
                CB_truong.Items.Add(t);
            }
        }
        // Thêm môn học tương ứng với mỗi trường vào CB_monhoc
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
        // Hàm thay đổi ca dạy
        private bool UpdateShift()
        {
            string query = $"update CaHoc set MaMon = '{maMon}', MaTruong = '{maTruong}', Mau = '{mau}' where TenDangNhap = '{DangNhap.taiKhoanHienTai.TenDangNhap}' and Ca = '{ca}' and Ngay = '{currentDate}'";

            using (SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=QL_CongViec;Integrated Security=True;TrustServerCertificate=True"))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
                catch
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
        // Cập nhật màu
        private bool UpdateColor()
        {
            string query = $"update CaHoc set Mau = '{mau}' where TenDangNhap = '{DangNhap.taiKhoanHienTai.TenDangNhap}' and Ca = '{ca}' and Ngay = '{currentDate}'";

            using (SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=QL_CongViec;Integrated Security=True;TrustServerCertificate=True"))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
                catch
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
        // Gọi hàm sửa lịch
        private void BTN_sua_Click(object sender, EventArgs e)
        {
            if (CB_color.SelectedIndex != -1 && CB_truong.SelectedIndex == -1 && CB_monhoc.SelectedIndex == -1)
            {
                if (UpdateColor())
                {
                    MessageBox.Show("Đã thay đổi màu ca dạy");
                }
                else
                {
                    MessageBox.Show("Thay đổi thất bại");
                }
                return;
            }
            if (CB_truong.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn trường");
                return;
            }
            if (CB_monhoc.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn môn học");
                return;
            }
            maMon = CB_monhoc.SelectedItem.ToString().Split('-')[0];
            maTruong = CB_truong.SelectedItem.ToString().Split('-')[0];
            if (UpdateShift())
            {
                MessageBox.Show("Đã thay đổi ca dạy");
                this.Close();
            }
            else
            {
                MessageBox.Show("Thay đổi thất bại");
            }
        }

        // Hàm xóa ca dạy
        private bool DeleteShift()
        {
            string query = $"delete from CaHoc where TenDangNhap = '{DangNhap.taiKhoanHienTai.TenDangNhap}' and Ca = {ca} and Ngay = '{currentDate}'";

            using (SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=QL_CongViec;Integrated Security=True;TrustServerCertificate=True"))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
                catch
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
        // Gọi hàm xóa lịch
        private void BT_delete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa ca học này?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (DeleteShift())
                {
                    MessageBox.Show("Đã xóa ca dạy");
                    shiftDeleted = true;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại");
                }
            }
            
        }
        // Chọn màu của CB_color
        private void CB_color_SelectedIndexChanged(object sender, EventArgs e)
        {
            Color color = (Color)CB_color.SelectedItem;
            mau = color.Name;
        }
        // Thêm màu vào CB_color, đã thêm 4 màu
        private void AddColorToCBColor()
        {
            string[] specificColors = { "Cyan", "SpringGreen", "LightCoral", "LightYellow" };

            var selectedColors = typeof(Color).GetProperties()
                .Where(x => x.PropertyType == typeof(Color) && specificColors.Contains(x.Name))
                .Select(x => (Color)x.GetValue(null))
                .ToList();

            CB_color.DataSource = selectedColors;

            CB_color.SelectedIndex = 0;
        }
        // Vẽ các ô màu của CB_color
        private void CB_color_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            if (e.Index >= 0)
            {
                var txt = CB_color.GetItemText(CB_color.Items[e.Index]);
                var color = (Color)CB_color.Items[e.Index];
                var r1 = new Rectangle(e.Bounds.Left + 1, e.Bounds.Top + 1,
                    2 * (e.Bounds.Height - 2), e.Bounds.Height - 2);
                var r2 = Rectangle.FromLTRB(r1.Right + 2, e.Bounds.Top,
                    e.Bounds.Right, e.Bounds.Bottom);
                using (var b = new SolidBrush(color))
                    e.Graphics.FillRectangle(b, r1);
                e.Graphics.DrawRectangle(Pens.Black, r1);
                TextRenderer.DrawText(e.Graphics, txt, CB_color.Font, r2,
                    CB_color.ForeColor, TextFormatFlags.Left | TextFormatFlags.VerticalCenter);
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
