using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace paramModifiers
{
    class Program
    {

        // out param ref đc gọi là kiểu tham biến
        //ref giúp tham số trong method đc hiểu là kiểu tham biến
        static void swap(ref int a,ref int b)
        {
            int tmp;
            tmp = a;
            a = b;
            b = tmp;

        }
        //out 
        static void Sum(int a, int b, out int sum)
        {
            Console.WriteLine($"x = {a}");
            Console.WriteLine($"y = {b}");
            /*Console.WriteLine($"sum = {a+b}");*/
            sum = a + b;
        }

        //param
        static double AVG(params double[] marks) 
        {
            double sum = 0.0;
            for (int i = 0; i < marks.Length; i++)
            {
                sum += marks[i];
            }
            return sum / marks.Length;
        }
        static void Main(string[] args)
        {
            int x = 5;
            int y = 10;
            Console.WriteLine($"Trước hoán vị x ={x} , y ={y}");
            swap(ref x,ref y);
            Console.WriteLine($"Sau hoán vị x ={x} , y ={y}");
            int rs;
            Sum(x, y, out rs);
            Console.WriteLine(rs);
            Console.WriteLine(AVG(5.5,7,8.5));
            Console.ReadLine();
        }
    }
}
