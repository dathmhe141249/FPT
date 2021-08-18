using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Main
{
    class Sales_By_Match
    {
        public static int sockMerchant(int n, List<int> ar)
        {
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                if (ar[i] != 0)
                {
                    for (int j = i + 1; j < n; j++)
                    {

                        if (ar[i] == ar[j])
                        {
                            count++;
                            ar[j] = 0; // ~ a[i+1] = 0 vì nếu xét rồi, sẽ k xét nữa vì k tính
                            break;
                        }
                    }
                }

            }
            return count;
        }
    }
}
