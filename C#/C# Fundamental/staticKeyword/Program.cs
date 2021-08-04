using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace staticKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. sử dụng các thành phần trong class static
           /* Console.WriteLine("Name = " + (Ultility.name = "DatHM"));
            Console.WriteLine("Truth = " + Ultility.truth);
            Console.WriteLine("CurrentDate: ");
            Ultility.PrintDate();*/
            // 2 sd accountsaving
            AccountSaving s1 = new AccountSaving(500);
            AccountSaving s2 = new AccountSaving(1000);
            Console.WriteLine("Lãi suất hiện tại: " + AccountSaving.interestRate);

            s2.setInterestRateObj(0.08);
            AccountSaving s3 = new AccountSaving(2500);

            Console.WriteLine("Tong tien sau 1 nam gui tiet kiem la: " +
                (s3.balance + s3.balance*AccountSaving.interestRate));
            Console.ReadLine();
        }
    }
}
