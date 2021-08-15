using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Main
{
    class Between_Two_Sets
    {
        public static int getTotalX(List<int> a, List<int> b)
        {
            int maxA = a.Max();
            int minB = b.Min();
            int multiOfA = maxA;
            int rs = 0;
            while(multiOfA < minB)
            {
                bool isFator = true;
                foreach (var item in a)
                {
                    if(multiOfA % item != 0)
                    {
                        isFator = false;
                        break;
                    }
                }
                if (isFator)
                {
                    foreach (var item in b)
                    {
                        if(item % multiOfA != 0)
                        {
                            isFator = false;
                            break;
                        }
                    }
                }

                if (isFator)
                {
                    rs++;
                }
                multiOfA = multiOfA + 1;
            }

            return rs;
        }
    }
}
