﻿using System;
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
    public partial class ThemTruong : Form
    {
        public ThemTruong()
        {
            InitializeComponent();
        }
        private bool SaveSchool()
        {

            if (TB_MaTruong.TextLength > 10)
            {
                MessageBox.Show("Mã trường không hợp lệ (ít hơn 11 kí tự)");
                return false;
            }
            string query = "INSERT INTO Truong VALUES(@MaTruong, @TenTruong, @Luong1CaDay)";
            if (string.IsNullOrEmpty(TB_Luong1Ca.Text)) 
            {
                return false;  
            }
            int luong1CaDay = Convert.ToInt32(TB_Luong1Ca.Text);
            using (SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=QL_CongViec;Integrated Security=True;TrustServerCertificate=True"))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaTruong", TB_MaTruong.Text);
                        cmd.Parameters.AddWithValue("@TenTruong", TB_TenTruong.Text);
                        cmd.Parameters.AddWithValue("@Luong1CaDay", luong1CaDay);
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
        private void BT_Save_Click(object sender, EventArgs e)
        {
            if (TB_MaTruong.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng điền vào mã trường");
            }
            else if (TB_TenTruong.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng điền vào tên trường");
            }
            else if (TB_Luong1Ca.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng điền vào lương 1 ca dạy");
            }
            else if (SaveSchool())
            {
                MessageBox.Show("Lưu thành công");
                this.Close();
            }
            else
            {
                MessageBox.Show("Lưu thất bại");
            }
        }
    }
}
