using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter c: ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter d: ");
            int d = Convert.ToInt32(Console.ReadLine());
            if (a == b && a == c && a == d)
            {
                Console.WriteLine("ko co so nho nhat");
            }
            else
            {
                int min = a;
                if (b < min)
                {
                    min = b;
                }
                else if (c < min)
                {
                    min = c;
                }
                else if (d < min)
                {
                    min = d;
                }
                Console.WriteLine("min: " + min);
            }
            if (a == b && a == c && a == d)
            {
                Console.WriteLine("ko co so lon nhat");
            }
            else
            {
                int max = a;
                if (b > max)
                {
                    max = b;
                }
                else if (c > max)
                {
                    max = c;
                }
                else if (d > max)
                {
                    max = d;
                }
                Console.WriteLine("max: " + max);
                int max2 = 0;
                if (a > max2 && a != max)
                {
                    max2 = a;
                }
                else if (b > max2 && b != max)
                {
                    max2 = b;
                }
                else if (c > max2 && c != max)
                {
                    max2 = c;
                }
                else if (d > max2 && d != max)
                {
                    max2 = d;
                }
                Console.WriteLine("max2: " + max2);
            }
        }

    }
    }

