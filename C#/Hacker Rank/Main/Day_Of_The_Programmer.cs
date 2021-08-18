using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Main
{
    class Day_Of_The_Programmer
    {
        public static string dayOfProgrammer(int year)
        {

            if (year == 1918)
            {
                return "26.09.1918";
            }
            else if (year > 1918)
            {
                if ((year % 4 == 0 && year % 100 != 0))
                {
                    return "12.09." + year;
                }
                else if (year % 400 == 0)
                {
                    return "12.09." + year;
                }
                else
                {
                    return "13.09." + year;
                }
            }
            else
            {
                // nhỏ hơn 1918 theo lịch Jullious thì cứ 4 năm là 1 năm nhuận đéo quan tâm gì khác :v
                if (year % 4 == 0)
                {
                    return "12.09." + year;
                }
                else
                {
                    return "13.09." + year;
                }
            }
        }
    }
}
