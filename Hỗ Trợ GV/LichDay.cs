using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hỗ_Trợ_GV
{
    public partial class LichDay : Form
    {
        // Ngày tại một ô
        private DateTime currentDate;
        // Số ca
        private const int SOCA = 4;
        // Số ngày trong tuần
        private const int SONGAY = 7;
        // Ngày bắt đầu trong tuần
        private DateTime startOfWeek;
        // Ngày kết thúc trong tuần
        private DateTime endOfWeek;
        public LichDay()
        {
            InitializeComponent();
            currentDate = DateTime.Today;
            DisplayWeekInterval();
            GetCell();
            MC_chonngay.FirstDayOfWeek = Day.Monday;
            BTN_homnay.Click += BTN_homnay_Click;

            LB_Ca1.Text = "   Ca1\n(6H50 - 9H30)";
            LB_Ca2.Text = "   Ca2\n(9H30 - 12H)";
            LB_Ca3.Text = "   Ca3\n(12H45 - 15H15)";
            LB_Ca4.Text = "   Ca4\n(15H15 - 18H)";
        }
        
        // Thêm các cell vào tổng có 28 cell
        private void GetCell()
        {
            for (int i = 1; i <= SOCA; i++)
            {
                for (int j = 1; j <= SONGAY; j++)
                {
                    UserControlBlank ucblank = new UserControlBlank();
                    ucblank.SetCa(i);
                    ucblank.SetCurrentDate(startOfWeek.AddDays(j - 1));
                    FLP_shiftcontainer.Controls.Add(ucblank);
                }
            }
        }
        // Hiện khoảng tuần giữa nút tuần tới và tuần rồi
        private void DisplayWeekInterval()
        {
            DayOfWeek currentDayOfWeek = currentDate.DayOfWeek;
            int daysToAdd = currentDayOfWeek == DayOfWeek.Sunday ? 6 : (int)currentDayOfWeek - 1;
            startOfWeek = currentDate.AddDays(-daysToAdd);
            endOfWeek = startOfWeek.AddDays(6);

            LB_weekinterval.Text = $"{startOfWeek:dd/MM/yyyy} - {endOfWeek:dd/MM/yyyy}";
            for (int i = 0; i < 7; i++)
            {
                DateTime currentDay = startOfWeek.AddDays(i);
                string labelText = $"({currentDay.Day}/{currentDay.Month})";

                switch (i)
                {
                    case 0:
                        LB_d1.Text = labelText;
                        break;
                    case 1:
                        LB_d2.Text = labelText;
                        break;
                    case 2:
                        LB_d3.Text = labelText;
                        break;
                    case 3:
                        LB_d4.Text = labelText;
                        break;
                    case 4:
                        LB_d5.Text = labelText;
                        break;
                    case 5:
                        LB_d6.Text = labelText;
                        break;
                    case 6:
                        LB_d7.Text = labelText;
                        break;
                }
            }
        }
        
        // Qua tuần kế tiếp
        private void Btn_tuantruoc_Click(object sender, EventArgs e)
        {
            MC_chonngay.DateChanged -= MC_chonngay_DateChanged;
            DateTime previousDate = currentDate;
            currentDate = currentDate.AddDays(-7);
            DisplayWeekInterval();
            if (currentDate != previousDate)
            {
                FLP_shiftcontainer.Controls.Clear();
                GetCell();
                MC_chonngay.SelectionStart = startOfWeek;
            }
            MC_chonngay.DateChanged += MC_chonngay_DateChanged;
        }

        // Quay lại tuần rồi
        private void Btn_tuansau_Click(object sender, EventArgs e)
        {
            MC_chonngay.DateChanged -= MC_chonngay_DateChanged;
            DateTime previousDate = currentDate;
            currentDate = currentDate.AddDays(7); 
            DisplayWeekInterval();
            if (currentDate != previousDate)
            {
                FLP_shiftcontainer.Controls.Clear();
                GetCell();
                MC_chonngay.SetSelectionRange(startOfWeek, endOfWeek);
            }
            MC_chonngay.DateChanged += MC_chonngay_DateChanged;
        }

        private void MC_chonngay_DateChanged(object sender, DateRangeEventArgs e)
        {
            currentDate = MC_chonngay.SelectionStart;
            DisplayWeekInterval();
            FLP_shiftcontainer.Controls.Clear();
            GetCell();
        }

        private void BTN_homnay_Click(object sender, EventArgs e)
        {
            MC_chonngay.DateChanged -= MC_chonngay_DateChanged;
            DateTime previousDate = currentDate; 
            currentDate = DateTime.Today;
            DayOfWeek currentDayOfWeek = currentDate.DayOfWeek;
            int daysToAdd = currentDayOfWeek == DayOfWeek.Sunday ? 0 : (int)DayOfWeek.Monday - (int)currentDayOfWeek;
            startOfWeek = currentDate.AddDays(daysToAdd);
            endOfWeek = startOfWeek.AddDays(6);

            DisplayWeekInterval();
            if (currentDate != previousDate)
            {
                FLP_shiftcontainer.Controls.Clear();
                GetCell();
                MC_chonngay.SetSelectionRange(startOfWeek, endOfWeek);
            }
            MC_chonngay.DateChanged += MC_chonngay_DateChanged;
        }
    }
}
