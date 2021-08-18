using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Main
{
    class Drawing_Book
    {
        public static int pageCount(int n, int p)
        {
            int TargetPageCountFromFront = p / 2;
            int totalFlipFromFrontToBack = n / 2;
            int TargetPageCountFromBack = totalFlipFromFrontToBack - TargetPageCountFromFront;
            return Math.Min(TargetPageCountFromFront, TargetPageCountFromBack);
        }
    }
}
