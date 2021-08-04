using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            Food f = new Food() { Amount = 1000 };
            f.AmountChanged += notifiedAmountChanged;
            f.Amount = 990;
            Console.WriteLine("Calory:" +f.ComputeCalory());
        }
        public static void notifiedAmountChanged(float old, float New)
        {
            Console.WriteLine("Amount changed – old value: " + old + ", new value : " + New);
        }
    }
}
