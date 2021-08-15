using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Main
{
    class CompareTheTriplets
    {
        public static List<int> compareTriplets(List<int> a, List<int> b)
        {
            int aScore = 0;
            int bScore = 0;
            List<int> rs = new List<int>();
            for (int i = 0; i < a.Count; i++)
            {
                if(a[i] > b[i])
                {
                    aScore++;
                }
                else if(a[i] < b[i])
                {
                    bScore++;
                }
                else
                {

                }
            }
            rs.Add(aScore);
            rs.Add(bScore);
            return rs;
        }
    }
}
