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
        public LichDay()
        {
            InitializeComponent();
            currentDate = DateTime.Today;
            DisplayWeekInterval();
            DisplayColumns();
        }
    

        private void DisplayColumns()
        {
            for (int i = 1; i <= 28; i++) 
            { 
                UserControlBlank ucblank = new UserControlBlank();
                FLP_shiftcontainer.Controls.Add(ucblank);
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
            for (int i = 1; i <= 28; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                FLP_shiftcontainer.Controls.Add(ucblank);
            }
        }

        private void Btn_tuansau_Click(object sender, EventArgs e)
        {
            currentDate = currentDate.AddDays(7);
            DisplayWeekInterval();
            FLP_shiftcontainer.Controls.Clear();
            for (int i = 1; i <= 28; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                FLP_shiftcontainer.Controls.Add(ucblank);
            }
        }
    }
}
