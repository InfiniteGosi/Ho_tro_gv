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
        private string email;
        public TaiKhoan(string tenDangNhap, string matKhau, string email)
        {
            this.tenDangNhap = tenDangNhap ;
            this.matKhau = matKhau ;
            this.email = email ;
        }

        public string TenDangNhap
        {
            get { return tenDangNhap; }
            set { tenDangNhap = value; }
        }
        public string MatKhau
        {
            get { return matKhau; }
            set { matKhau = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
    }
}
