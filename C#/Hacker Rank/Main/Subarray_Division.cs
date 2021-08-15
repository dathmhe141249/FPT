using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Main
{
    class Subarray_Division
    {
        public static int birthday(List<int> s, int d, int m)
        {
            int ways = 0;
            for (int i = 0; i < s.Count - (m - 1); i++)
                if (s.Skip(i).Take(m).Sum() == d) ways++;
            return ways;
        }
    }
}
