using Hỗ_Trợ_GV.Model;
using LiveCharts.Wpf;
using LiveCharts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using System.Collections;
using System.Windows.Forms.DataVisualization.Charting;

namespace Hỗ_Trợ_GV
{
    public partial class ThongKe : Form
    {
        public ThongKe()
        {
            InitializeComponent();
        }
        List<DailyIncome> luongTheoNgay;
        private void ThongKe_Load(object sender, EventArgs e)
        {
        }

        private void BT_LoadThongKe_Click(object sender, EventArgs e)
        {
            // Khởi tạo lại dữ liệu
            string query = @"
                    SELECT Ngay,
                           SUM(TongLuongTheoMon) AS TongLuongTrongNgay
                    FROM (
                        SELECT 
                            ch.Ngay,
                            mh.MaMon, 
                            mh.TenMon, 
                            t.TenTruong, 
                            t.Luong1CaDay, 
                            COUNT(ch.Ngay) AS SoCaHoc, 
                            (t.Luong1CaDay * COUNT(ch.Ngay)) AS TongLuongTheoMon, 
                            SUM(t.Luong1CaDay * COUNT(ch.Ngay)) OVER () AS LuongTong 
                        FROM 
                            MonHoc mh 
                        INNER JOIN 
                            Truong t ON mh.MaTruong = t.MaTruong 
                        INNER JOIN 
                            CaHoc ch ON mh.MaMon = ch.MaMon 
                        WHERE 
                            ch.TenDangNhap = @TenDangNhap 
                            AND ch.Ngay BETWEEN @TuNgay AND @DenNgay
                        GROUP BY 
                            ch.Ngay,mh.MaMon, mh.TenMon, t.TenTruong, t.Luong1CaDay
                    ) AS TongLuongTheoMon
                    GROUP BY 
                        Ngay";

            using (SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=QL_CongViec;Integrated Security=True;TrustServerCertificate=True"))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    conn.Open();
                    cmd.Parameters.AddWithValue("@TenDangNhap", DangNhap.taiKhoanHienTai.TenDangNhap);

                    // Parse the dates with error handling
                    cmd.Parameters.AddWithValue("@TuNgay", dTP_TuNgay.Text);
                    cmd.Parameters.AddWithValue("@DenNgay", dTP_DenNgay.Text);

                    luongTheoNgay = new List<DailyIncome>();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        DateTime date = reader.GetDateTime(0);
                        int income = reader.GetInt32(1);
                        luongTheoNgay.Add(new DailyIncome(date, income));
                    }

                    reader.Close();
                    cmd.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }

            // Set up the chart
            // Check if luongTheoNgay is null or empty before using it
            if (luongTheoNgay != null && luongTheoNgay.Count > 0)
            {
                chart1.Series.Clear(); // Clear previous series
                chart1.Visible = true;
                // Add a new series to the chart
                System.Windows.Forms.DataVisualization.Charting.Series series = new System.Windows.Forms.DataVisualization.Charting.Series("Tổng lương theo ngày");
                series.ChartType = SeriesChartType.Column; // Set chart type to column
                chart1.Series.Add(series);
                // Set axis titles
                chart1.ChartAreas[0].AxisX.Title = "Ngày";
                chart1.ChartAreas[0].AxisY.Title = "VNĐ";
                chart1.ChartAreas[0].AxisX.Interval = 1;
                // Add data points to the series
                foreach (var item in luongTheoNgay)
                {
                    series.Points.AddXY(item.Date.ToString("yyyy-MM-dd"), item.Income);
                }

             
            }
        }
    }
}
