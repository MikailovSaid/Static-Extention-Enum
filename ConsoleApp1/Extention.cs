using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Extention
{
    public static class Extention
    {
        public static int CheckString(this string str, string pattern)
        {
            return Regex.Matches(str, pattern).Count;
        }
    }
}
