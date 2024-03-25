using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hỗ_Trợ_GV.Model
{
    internal class DailyIncome
    {
        public DateTime Date { get; set; }
        public int Income { get; set; }

        // Constructor to initialize Date and Income
        public DailyIncome(DateTime date, int income)
        {
            Date = date;
            Income = income;
        }
    }
}
