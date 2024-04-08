using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task08._04.Extension
{
    static class Helper
    {
        public static string Capitalize(this string name)
        { return name.Substring(0, 1).ToUpper() + name.Substring(1).ToLower(); }
    }
}
