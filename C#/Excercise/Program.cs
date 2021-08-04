using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excercise
{
    class Program
    {
        static void Main(string[] args)
        {
            double rs = (double)(24.0 / 5);
            /*
            Console.WriteLine($"ex1: {rs}");
            Console.WriteLine("ex2:");
            Console.WriteLine($"{-1 + 4 * 6 }");
            Console.WriteLine($"{ (35+ 5 ) % 7 }");
            Console.WriteLine($"{14 + -4 * 6 / 11 }");
            Console.WriteLine($"{(2 + 15 / 6 * 1 - 7 % 2 )}");
            Console.WriteLine("ex3:");
            Console.WriteLine("1stNum: ");
            int f1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2ndNum: ");
            int f2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{f1} + {f2} = {f1+f2}");
            Console.WriteLine($"{f1} - {f2} = {f1 - f2}");
            Console.WriteLine($"{f1} x {f2} = {f1 * f2}");
            Console.WriteLine($"{f1} / {f2} = {f1 / f2}");
            Console.WriteLine($"{f1} mod {f2} = {f1 % f2}");
            Console.WriteLine("ex4:");
            int n1 = Convert.ToInt32(Console.ReadLine());
            int n2 = Convert.ToInt32(Console.ReadLine());
            int n3 = Convert.ToInt32(Console.ReadLine());
            int n4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"avg of {n1},{n2},{n3},{n4} is {(n1+n2+n3+n4)/4}");
            Console.WriteLine("ex5:");
            */
            /*
            int n = Convert.ToInt32(Console.ReadLine());
            int newN = 0;
            int r;
            for (int i = n; i !=0; i=i/10)
            {
               r = i % 10;
                newN = newN * 10 + r;
            }
            Console.WriteLine($"The number in reverse order is : {newN}");
            */
            Console.WriteLine("Input the number of elements to store in the array :");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Input {N} number of elements in the array : ");
            int[] arr = new int[N];
            for (int i = 0; i < N; i++)
            {
                Console.Write($"element - {i}: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            /*
             * ex6:
            Console.WriteLine("The values store into the array are:");
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine($" {arr[i]}");
            }
            Console.WriteLine("The values store into the array in reverse are:");
            for (int i = N-1; i >= 0; i--)
            {
                Console.WriteLine($" {arr[i]}");
            }
            */
            /*
            Console.WriteLine("Even element are: ");
            for (int i = 0; i < N; i++)
            {
                if(arr[i] % 2 == 0)
                {
                    Console.WriteLine(arr[i]);
                }
            }
            Console.WriteLine("Odd element are: ");
            for (int i = 0; i < N; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    Console.WriteLine(arr[i]);
                }
            }
            */
            Console.WriteLine("Enter num");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter pos: ");
            int pos = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Current Array: ");
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine(arr[i]);
            }

            /* Move all data at right side of the array */
            for (int i = N; i >= pos; i--)
                arr[i] = arr[i - 1];
            /* insert value at given position */
            arr[pos - 1] = num;


            Console.Write("\n\nAfter Insert the element the new list is :\n");
            for (int i = 0; i <= N; i++)
                Console.Write("{0} ", arr[i]);
           
            Console.ReadLine();
        }
    }
}
