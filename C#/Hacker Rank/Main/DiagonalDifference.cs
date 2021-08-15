using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Main
{
    class DiagonalDifference
    {
        public static int diagonalDifference(List<List<int>> arr)
        {
            int primarySum = 0;
            int sndarySum = 0;
            int m = arr.Count;
            for (int i = 0; i < arr.Count; i++)
            {
                m = m - 1;
                for (int j = 0; j < arr.Count; j++)
                {
                    if (i == j)
                    {
                        primarySum += arr[i][j];
                    }
                    if(j==m)
                    {
                        sndarySum += arr[i][j];
                    }
                }
            }

            int sum = Math.Abs(primarySum - sndarySum);
            return sum;
        }
    }
}
