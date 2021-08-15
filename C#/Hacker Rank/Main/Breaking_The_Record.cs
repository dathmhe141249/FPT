using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Main
{
    class Breaking_The_Record
    {
        public static List<int> breakingRecords(List<int> scores)
        {
            List<int> rs = new List<int>();
            int min = scores[0];
            int max = scores[0];
            int countMin = 0;
            int countMax = 0;
            for (int i = 0; i < scores.Count; i++)
            {
                if (scores[i] > max)
                {
                    max = scores[i];
                    countMax++;
                }
                if(scores[i] < min)
                {
                    min = scores[i];
                    countMin++;
                }
}
            rs.Add(countMax);
            rs.Add(countMin);
            return rs;
        }

    }
}

