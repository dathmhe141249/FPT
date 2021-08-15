using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Main
{
    class Apple_and_Orange
    {
        public static void countApplesAndOranges(int s, int t, int a, int b, List<int> apples, List<int> oranges)
        {
            int countApple = 0;
            int countOrange = 0;
            for (int i = 0; i < apples.Count; i++)
            {
                int rs = a + apples[i];
                if(s <=rs && rs <= t)
                {
                    countApple++;
                }
            }

            for (int i = 0; i < oranges.Count; i++)
            {
                int rs = b + oranges[i];
                if (s <= rs && rs <= t)
                {
                    countOrange++;
                }
            }
            Console.WriteLine(countApple);
            Console.WriteLine(countOrange);
        }
    }
}
