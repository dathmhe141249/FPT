using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace staticKeyword
{
    //mục tiêu class static: Class này chứa các thành phần đc sd chung trong nhiều class khác
    class Ultility
    {
        // trong class static chỉ đc chứa: constant, properties, static methods
        public static string name;
        public const bool truth = true;

        public static void PrintTime()
        {
            Console.WriteLine(DateTime.Now.ToShortTimeString());
        }

        public static void PrintDate()
        {
            Console.WriteLine(DateTime.Now.ToShortDateString());
        }


    }
}
