using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hỗ_Trợ_GV.UserControls
{
    
    public partial class UC_LichDay : UserControl
    {
        public UC_LichDay()
        {
            InitializeComponent();
            loadMatrix();
        }

        List<List<Button>> mat = new List<List<Button>>();
        void loadMatrix()
        {
       
            int h = 100;
            int w = 150;
            Button oldBtn = new Button() { Width = 0, Height = 0, Location = new Point(0, 0) };
            for (int i = 0; i < 4; i++)
            {
                mat.Add(new List<Button>());
                for (int j = 0; j < 7; j++) {
                    Button btn = new Button() { Width = w, Height = h };
                    btn.Location = new Point(oldBtn.Location.X + oldBtn.Width, oldBtn.Location.Y);
                    
                    PN_LapLich.Controls.Add(btn);
                    oldBtn = btn;
                    mat[i].Add(btn);
                
                }
                oldBtn = new Button() { Width = 0, Height = 0, Location = new Point(0, oldBtn.Location.Y + h) };
            }
            LenLich();
        }
        void LenLich()
        {

            //for (int i = 0; i < 4; i++)
            //{
            //    for (int j = 0; j < 7; j++)
            //    {
            //        if (mat[i][j].PerformClick())
            //        {

            //        }
            //    }
            //}
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void BTN_LapLich_Click(object sender, EventArgs e)
        {
            LenLich ll = new LenLich();
            ll.ShowDialog();
        }
    }
}
