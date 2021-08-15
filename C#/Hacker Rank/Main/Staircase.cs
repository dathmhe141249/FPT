using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Main
{
    class Staircase
    {
        public static void staircase(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(new string('#',i+1).PadLeft(n,' '));
            }
        }
    }
}
