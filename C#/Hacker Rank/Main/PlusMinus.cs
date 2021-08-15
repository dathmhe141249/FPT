using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Main
{
    class PlusMinus
    {
        public static void plusMinus(List<int> arr)
        {
            int n = arr.Count;
            float countPositive = 0.0f;
            float countNegative = 0.0f;
            float countZeros = 0.0f;
            foreach (var i in arr)
            {
                if(i == 0)
                {
                    countZeros++;
                }else if(i > 0)
                {
                    countPositive++;
                }
                else
                {
                    countNegative++;
                }
            }
            Console.WriteLine($"{countPositive/n}");
            Console.WriteLine($"{countNegative / n}");
            Console.WriteLine($"{countZeros / n}");
        }
    }
}
