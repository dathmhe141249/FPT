using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPEx
{
    public class Person
    {
        protected int age;
        public void Greet()
        {
            Console.WriteLine("Hello");
        }

        public void setAge(int age)
        {
            this.age = age;
        }
    }
}
