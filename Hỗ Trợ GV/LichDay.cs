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
        private DateTime currentDate;
        private const int SOCA = 4;
        private const int SONGAY = 7;
        public LichDay()
        {
            InitializeComponent();
            currentDate = DateTime.Today;
            DisplayWeekInterval();
            GetCell();
        }
    
        private void GetCell()
        {
            for (int i = 1; i <= SOCA; i++)
            {
                for (int j = 1; j <= SONGAY; j++)
                {
                    UserControlBlank ucblank = new UserControlBlank();
                    ucblank.setCa(i);
                    ucblank.setCurrentDate(currentDate.AddDays(j - 1));
                    FLP_shiftcontainer.Controls.Add(ucblank);
                }
            }
        }

        private void DisplayWeekInterval()
        {
            DayOfWeek currentDayOfWeek = currentDate.DayOfWeek;
            int daysToAdd = currentDayOfWeek == DayOfWeek.Sunday ? 6 : (int)currentDayOfWeek - 1;
            DateTime startOfWeek = currentDate.AddDays(-daysToAdd);
            DateTime endOfWeek = startOfWeek.AddDays(6);
            LB_weekinterval.Text = $"{startOfWeek.ToString("dd/MM/yyyy")} - {endOfWeek.ToString("dd/MM/yyyy")}";
           
            LB_d1.Text = $"({startOfWeek.Day.ToString()}/{startOfWeek.Month.ToString()})";
            LB_d2.Text = $"({(startOfWeek.Day + 1).ToString()}/{startOfWeek.Month.ToString()})";
            LB_d3.Text = $"({(startOfWeek.Day + 2).ToString()}/{startOfWeek.Month.ToString()})";
            LB_d4.Text = $"({(startOfWeek.Day + 3).ToString()}/{startOfWeek.Month.ToString()})";
            LB_d5.Text = $"({(startOfWeek.Day + 4).ToString()}/{startOfWeek.Month.ToString()})";
            LB_d6.Text = $"({(startOfWeek.Day + 5).ToString()}/{startOfWeek.Month.ToString()})";
            LB_d7.Text = $"({endOfWeek.Day.ToString()}/{endOfWeek.Month.ToString()})";
        }

        private void Btn_tuantruoc_Click(object sender, EventArgs e)
        {
            currentDate = currentDate.AddDays(-7);
            DisplayWeekInterval();

            FLP_shiftcontainer.Controls.Clear();
            GetCell();
        }

        private void Btn_tuansau_Click(object sender, EventArgs e)
        {
            currentDate = currentDate.AddDays(7);
            DisplayWeekInterval();
            FLP_shiftcontainer.Controls.Clear();
            GetCell();
        }
    }
}
