using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Main
{
    public class Number_Line_Jump
    {
        public static string kangaroo(int x1, int v1, int x2, int v2)
        {
            if (x1 < x2)
            {
                if (v1 < v2)
                {
                    return "NO";
                }
                else if (v1 == v2)
                {
                    return "NO";
                }
                else
                {
                    var mul = (double)(x2 - x1) / (v1 - v2);
                    if (mul % 1 == 0)
                    {
                        return "YES";
                    }
                    else
                    {
                        return "NO";
                    }
                }
            }
            else if (x1 > x2)
            {
                if (v1 > v2)
                {
                    return "YES";
                }
                else if (v1 == v2)
                {
                    return "NO";
                }
                else
                {
                    // x1 > x2, v2 > v1
                    var mul = (double)(x1 - x2) / (v2 - v1);
                    if (mul % 1 == 0)
                    {
                        return "YES";
                    }
                    else
                    {
                        return "NO";
                    }
                }
            }
            else
            {
                //x1 == x2
                return "YES";
            }
        }
    }
}
