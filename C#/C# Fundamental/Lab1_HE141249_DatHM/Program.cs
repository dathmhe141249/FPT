using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab1_HE141249_DatHM
{
    class Program
    {
        static decimal[] array = new decimal[1000];
        static int length = 0;
        static void Main(string[] args)
        {
            int choice;
            do
            {
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Show");
                Console.WriteLine("3. Search");
                Console.WriteLine("4. Statistics");
                Console.WriteLine("5. Exit");
                Console.Write("Enter a option (1-5): ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddNumber();
;                        break;
                    case 2:
                        ShowArray();
                        break;
                    case 3:
                        SearchValue();
                        break;
                    case 4: GetStatistics();
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;

                }
            } while (choice >= 1 && choice <= 5);
        }

        static void GetStatistics()
        {
            decimal sum = array.Sum();
            decimal avg = array.Average();
            decimal min = array[0];
            decimal max = array[0];
            if (length > 0)
            {
                for (int i = 0; i < length; i++)
                {
                    if (array[i] < min)
                    {
                        min = array[i];
                    }
                    if (array[i] > max)
                    {
                        max = array[i];
                    }
                }
                avg = sum / length;
                Console.WriteLine($"Total data: {length}");
                Console.WriteLine($"Sum: {sum}");
                Console.WriteLine($"Average: {avg}");
                Console.WriteLine($"Min value: {min}");
                Console.WriteLine($"Max value: {max}");
            }
            else
            {
                Console.WriteLine("There's nothing in array");
            }
        }

        static void AddNumber()
        {
            decimal number = Convert.ToDecimal(Console.ReadLine());
            array.SetValue(number, length);
            length++;
        }

        static void ShowArray()
        {
            if (length <= 0)
            {
                Console.WriteLine("There's nothing in the array");
            }
            else
            {
                for (int i = 0; i < length; i++)
                {
                    Console.Write(array[i] + " ");
                }
                Console.WriteLine();
            }
        }

        static void SearchValue()
        {
            if (length <= 0)
            {
                Console.WriteLine("There's nothing in the array");
            }
            else
            {
                decimal x = Convert.ToDecimal(Console.ReadLine());
                if (array.Contains(x))
                {
                    for (int i = 0; i < length; i++)
                    {
                        if(array[i] == x)
                        {
                            Console.WriteLine($"Found {x} at index {i}");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Not found");
                }
            }
        }
    }
}
