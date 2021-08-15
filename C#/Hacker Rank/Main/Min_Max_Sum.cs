using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Main
{
    class Min_Max_Sum
    {

        public static void miniMaxSum(List<int> arr)
        {
            int min = arr.Min();
            int max = arr.Max();
            long sum = 0;
            foreach (var item in arr)
            {
                sum += item;
            }

            long maxSum = sum - min;
            long minSum = sum - max;
            Console.WriteLine(minSum +" "+ maxSum);
        }
    }
}
