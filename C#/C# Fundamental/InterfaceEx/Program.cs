using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterfaceEx
{
    

    class Program
    {

        static void Main(string[] args)
        {
            Payment payment = new Payment(1000f);
            payment.AmountChanged += whenAmountChanged; // your handling function
            payment.Amount1 = 990;
            Console.WriteLine("Tax:" +payment.ComputeTax());
            Console.ReadLine();
        }
        public static void whenAmountChanged(float old, float New)
        {
            Console.WriteLine("Amount changed – old value: " + old + ", new value : " + New);
        }
    }
    }
