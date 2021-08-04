using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            Demo<int> test = new Demo<int>(10);
            test.write();
            Demo<string> test2 = new Demo<string>("Hello World");
            test2.write();
            int result1 = Compare(2, 2);
            int result2 = Compare("abc", "def");
            Console.WriteLine(result1);
            Console.WriteLine(result2);
            Console.ReadLine();
        }
        static int Compare<T>(T first, T second)
        {
            if (first.Equals(second))
            {
                return 0;
            }
            return 1;
        }
    }
}
