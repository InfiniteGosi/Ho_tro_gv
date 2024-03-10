using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hỗ_Trợ_GV.Model
{
    public class TaiKhoan
    {
        private string tenDangNhap;
        private string matKhau;
        public String TenDangNhap { 
            get { return tenDangNhap; } 
            set {  tenDangNhap = value; }
        }
        public String MatKhau 
        { 
            get { return matKhau; }
            set { matKhau = value; }
        }
    }
}
