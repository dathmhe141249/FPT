using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexTryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            string roll;
            while (true)
            {
                Console.WriteLine("Enter Roll Number");
                roll = Console.ReadLine();
                // @ là bỏ ký tự đặc biệt
                Regex g = new Regex(@"^[0-9]+$");

                // đằng trc phải có HE với SE, /d là chỉ là số
                // +: nhập nhiều lần
                // 6: phải có 6 kí tự số
                Regex r = new Regex(@"^(HE|SE)\d+(6)$");
                // hoặc Regex g = new Regex(@"^/d+$"); 
                if (r.IsMatch(roll))
                {
                    Console.WriteLine("Hop le!");
                    s.Roll = Convert.ToInt32(roll);
                    break;
                }
                else
                {
                    Console.WriteLine("Not valid iput");
                }
            }
            Console.WriteLine(s.Roll.ToString());
            Console.ReadLine();
        }
    }
}
