using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test2_001
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int user, pass;
            int attempts = 0;

            do
            {
                user = Convert.ToInt32(Console.ReadLine());
                pass = Convert.ToInt32(Console.ReadLine());

                if ((user != 12) || (pass != 1234))
                {
                    Console.WriteLine("Login failed");
                    attempts++;
                }
            }
            while (((user != 12) || (pass != 1234)) && (attempts != 3));

            if ((user == 12) || (pass == 1234))
                Console.WriteLine("Login successful");
            */
            // ex4:
            /*int n1, n2;
           
            do
            {
                 n1 = Convert.ToInt32(Console.ReadLine()) ;
                if (n1 == 0)
                {
                    Console.WriteLine("Goodbye");
                    Environment.Exit(0);
                }
                else
                {
                    n2 = Convert.ToInt32(Console.ReadLine());

                    if (n2 == 0)
                    {
                        Console.WriteLine("You can not divide by 0");
                    }
                    else
                    {
                        Console.WriteLine($"The division is {n1 / n2}");
                        Console.WriteLine($"The rest is {n1 % n2}");
                    }
                }
            } while (n1 != 0);*/
            //ex5:
            /*int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("FOR");
            for (int i = x; i <= y; i++)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine();
            Console.WriteLine("While");
            int k = x;
            while(k>=x && k <= y)
            {
                Console.Write(k+" ");
                k++;
            }
            int z = x;
            Console.WriteLine();
            Console.WriteLine("Do While");
            do
            {
                Console.Write(z + " ");
                z++;
            } while (z >= x && z <= y);
            Console.ReadLine();
            */
            //ex6
           /* int[] num = new int[5];
            for (int i = 0; i < num.Length; i++)
            {
                num[i] = Convert.ToInt32(Console.ReadLine());
            }
            int sum = 0;
            int avg = 0;
            int min = num[0];
            int max = num[0];
            for (int i = 0; i < num.Length; i++)
            {
                sum += num[i];
                if(num[i] < min)
                {
                    min = num[i];
                }
                if(num[i] > max)
                {
                    max = num[i];
                }
            }
            Console.WriteLine("sum: "+sum);
            Console.WriteLine("Media: " + sum/5);
            Console.WriteLine("min: " + min);
            Console.WriteLine("max: " + max);*/
           //ex7

            Console.ReadLine();
        }

    }
    }

