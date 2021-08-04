using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
	//Homework ex 1 -> 5
            Console.WriteLine("I'm Iron Man");
            Console.WriteLine("Enter n: ");
            int n = System.Int32.Parse(Console.ReadLine());
            if (n%2 == 0){
                Console.WriteLine("n is even");
            }else
            {
                Console.WriteLine("n is odd");
            }
           if(n%3 == 0)
            {
                Console.WriteLine("n is divisible by 3");
            }
            else
            {
                Console.WriteLine("n is not divisible by 3");
            }
            try
            {
                Console.WriteLine("Enter a:" );
                int a = System.Int32.Parse(Console.ReadLine());
                Console.WriteLine("Enter b:");
                int b = System.Int32.Parse(Console.ReadLine());
                Console.WriteLine($"{a}+{b}={sum(a, b)}");
                Console.WriteLine($"{a}-{b}={sub(a, b)}");
                Console.WriteLine($"{a}*{b}={mul(a, b)}");
                Console.WriteLine($"{a}/{b}={div(a, b)}");
                Console.WriteLine($"{b}/{a}={div(b, a)}");
                if (a < b)
                {
                    Console.WriteLine("a<b");
                }else if (a > b)
                {
                    Console.WriteLine("a>b");
                }
                else
                {
                    Console.WriteLine("a=b");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
           
            
        }
        static int sum(int a, int b)
        {
            return a + b;
        }
        static int mul(int a, int b)
        {
            return a * b;
        }
        static int sub(int a, int b)
        {
            return a - b;
        }
        static double div(int a, int b)
        {
          
            return (double) a / b;
        }
    }
}
