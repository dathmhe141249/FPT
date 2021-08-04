using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BT
{
    class Program
    {
        static double[] arr = new double[1000];
        static int count = 0;
        static int appearance = 0;
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
                Console.WriteLine("Enter a option:");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        double n = Convert.ToDouble(Console.ReadLine());
                        arr.SetValue(n, count);
                        count++;
                        break;
                    case 2:
                        for (int i = 0; i < count; i++)
                        {
                            Console.Write($"{arr[i]} ");
                        }
                        Console.WriteLine();
                        if (count == 0)
                        {
                            Console.WriteLine("Deo co gi trong mang");
                        }
                        break;
                    case 3:
                        double x = Convert.ToDouble(Console.ReadLine());
                        if (arr.Contains(x))
                        {
                            for (int i = 0; i < count; i++)
                            {
                                if (arr[i] == x)
                                {
                                    appearance++;
                                    Console.WriteLine($"Found {appearance} value of {x} at index {i}");
                                    appearance = 0;
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Not found");
                        }


                        break;
                    case 4:
                        GetStatistic();
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                }

            } while (choice >= 1 && choice <= 5);

        }

        static void GetStatistic()
        {
            Console.WriteLine($"Total store value: {count}");
            double sum = 0;
            for (int i = 0; i < count; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine($"sum: {sum}");
            Console.WriteLine($"Average: {sum / count}");
            double min = findMin();
            Console.WriteLine($"Min: {min}");
            double max = findMax();
            Console.WriteLine($"Max: {max}");
        }

        static double findMin()
        {
            double min = arr[0];
            for (int i = 0; i < count; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            return min;
        }

        static double findMax()
        {
            double max = arr[0];
            for (int i = 0; i < count; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            return max;
        }
    }
}
