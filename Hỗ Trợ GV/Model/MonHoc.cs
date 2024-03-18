using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hỗ_Trợ_GV.Model
{
    public class MonHoc
    {
        private string maMon;
        private string tenMon;
        public MonHoc(string maMon, string tenMon)
        {
            this.maMon = maMon;
            this.tenMon = tenMon;
        }

        public string MaMon
        {
            get { return maMon; }
            set { maMon = value; }
        }

        public string TenMon
        {
            get { return tenMon; }
            set { tenMon = value; }
        }

        public override string ToString()
        {
            return String.Format("{0} - {1}", maMon, tenMon);
        }
    }
}
