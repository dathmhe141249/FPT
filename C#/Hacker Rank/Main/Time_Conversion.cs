using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Main
{
    class Time_Conversion
    {
        public static string timeConversion(string s)
        {
            DateTime dateTime = DateTime.ParseExact(s, "hh:mm:sstt",
   System.Globalization.CultureInfo.InvariantCulture);
            return dateTime.ToString("HH:mm:ss");
        }
    }
}
