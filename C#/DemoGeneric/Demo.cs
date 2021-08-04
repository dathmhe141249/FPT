using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoGeneric
{
    class Demo<T>
    {
        T value;
        public Demo(T t)
        {
            value = t;
        }

        public void write()
        {
            Console.WriteLine(value);
        }
    }
}
