using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hỗ_Trợ_GV.Model
{
    public class Truong
    {
        private string maTruong;
        private string tenTruong;
        private int luongMotCaDay;

        public Truong(string maTruong, string tenTruong, int luongMotCaDay)
        {
            this.maTruong = maTruong;
            this.tenTruong = tenTruong;
            this.luongMotCaDay = luongMotCaDay;
        }

        public string MaTruong 
        {
            get { return maTruong; }
            set { maTruong = value; }
        }
        public string TenTruong
        {
            get { return tenTruong; }
            set { tenTruong = value; }
        }
        public int LuongMotCaDay
        {
            get { return luongMotCaDay; }
            set { luongMotCaDay = value; }
        }
        public override string ToString()
        {
            return String.Format("{0} - {1}", maTruong, tenTruong);
        }
    }
}
