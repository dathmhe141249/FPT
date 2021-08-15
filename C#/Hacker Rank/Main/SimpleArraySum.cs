using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Main
{
    class SimpleArraySum
    {
        public static int simpleArraySum(List<int> ar)
        {
            int sum = 0;
            foreach (var item in ar)
            {
                sum += item;
            }
            return sum;

        }
    }
}
