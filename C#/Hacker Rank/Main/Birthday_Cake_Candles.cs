using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Main
{
    class Birthday_Cake_Candles
    {
        public static int birthdayCakeCandles(List<int> candles)
        {
            int max = candles.Max();
            int count = 0;
            foreach (var item in candles)
            {
                if(item == max)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
