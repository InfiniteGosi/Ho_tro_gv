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

namespace Hỗ_Trợ_GV
{
    public partial class TinhLuong : Form
    {
        string connectString = @"Data Source=.\SQLEXPRESS;Initial Catalog=QL_CongViec;Integrated Security=True;TrustServerCertificate=True";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adt;
        DataTable dt;
        public TinhLuong()
        {
            InitializeComponent();
        }

        private void TinhLuong_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(connectString);
            
        }

        private void BT_LoadData_Click(object sender, EventArgs e)
        {
            try
            {
                dt = new DataTable();
                con.Open();
                cmd = new SqlCommand("SELECT MH.MaMon, MH.TenMon, T.TenTruong, T.Luong1CaDay, MH.SoCaDay, T.Luong1CaDay * MH.SoCaDay AS LuongTongTheoCa,\r\n    (SELECT SUM(T.Luong1CaDay * MH.SoCaDay) FROM Truong T, MonHoc MH WHERE T.MaTruong = MH.MaTruong) AS LuongTong\r\nFROM Truong T\r\nJOIN MonHoc MH ON T.MaTruong = MH.MaTruong", con);
                adt = new SqlDataAdapter(cmd);
                adt.Fill(dt);
                // cmd = new SqlCommand("SELECT SUM(T.Luong1CaDay * MH.SoCaDay) AS TotalSalary FROM Truong T JOIN MonHoc MH ON T.MaTruong = MH.MaTruong",con);
                // adt = new SqlDataAdapter(cmd);
                // adt.Fill(dt);
                dataGV_TinhLuong.DataSource = dt;
                con.Close();
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void BT_ExportExcel_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();

            DataColumn col1 = new DataColumn("MaMon");
            DataColumn col2 = new DataColumn("TenMon");
            DataColumn col3 = new DataColumn("TenTruong");
            DataColumn col4 = new DataColumn("Luong1CaDay");
            DataColumn col5 = new DataColumn("SoCaDay");
            DataColumn col6 = new DataColumn("LuongTongTheoCa");
            DataColumn col7 = new DataColumn("LuongTong");

            dataTable.Columns.Add(col1);
            dataTable.Columns.Add(col2);
            dataTable.Columns.Add(col3);
            dataTable.Columns.Add(col4);
            dataTable.Columns.Add(col5);
            dataTable.Columns.Add(col6);
            dataTable.Columns.Add(col7);

            int temp = 0;
            foreach (DataGridViewRow dtgvRow in dataGV_TinhLuong.Rows)
            {
                DataRow dtRow = dataTable.NewRow();

                dtRow[0] = dtgvRow.Cells[0].Value;
                dtRow[1] = dtgvRow.Cells[1].Value;
                dtRow[2] = dtgvRow.Cells[2].Value;
                dtRow[3] = dtgvRow.Cells[3].Value;
                dtRow[4] = dtgvRow.Cells[4].Value;
                dtRow[5] = dtgvRow.Cells[5].Value;
                if (temp == 0)
                {
                    dtRow[6] = dtgvRow.Cells[6].Value;
                    temp += 1;
                }
                dataTable.Rows.Add(dtRow);
            }
            Export export = new Export();
            export.ExportFile(dataTable, "Luong", "BẢN TÍNH LƯƠNG");
        }
    }
}
