using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hỗ_Trợ_GV
{
    public static class Helper
    {
        public static string ConnectionVal(String name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
