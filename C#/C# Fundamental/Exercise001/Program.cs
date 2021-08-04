using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise001
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the number of elements to store in the array :");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Input {n} number of elements in the array : ");
            int[] arr = new int[n];
            int i;
            for ( i = 0; i < n; i++)
            {
                Console.Write($"element - {i}: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Enter num");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter pos: ");
            int pos = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Current Array: ");
            for ( i = 0; i < n; i++)
            {
                Console.Write(arr[i]);
            }
            int[] newarr = new int[n + 1];

            for (i = 0; i < n + 1; i++)
            {
                if (i < pos - 1)
                    newarr[i] = arr[i];
                else if (i == pos - 1)
                    newarr[i] = x;
                else
                    newarr[i] = arr[i - 1];
            }
            Console.WriteLine("ARRAY after insert");
            // print the updated array
            for (i = 0; i < n + 1; i++) { 
                Console.Write(newarr[i] + " ");
        }
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
