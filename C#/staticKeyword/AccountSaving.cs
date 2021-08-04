using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace staticKeyword
{
    class AccountSaving
    {
        public double balance;
        public static double interestRate;

       

        public AccountSaving(double balance)
        {
            this.balance = balance;
        }

        // sẽ đc gọi tự động khi có 1 đối tượng kiểu AccountSaving đc tạo ra
        // chỉ đc gọi 1 lần duy nhất
        static AccountSaving()
        {
            Console.WriteLine("Static constructor called when");
            interestRate = 0.04;
        }

        public static void setInterestRate(double newRate)
        {
            interestRate = newRate;
        }
        public static double getInterestRate()
        {
            return interestRate;
        }
        public void setInterestRateObj(double newRate)
        {
            interestRate = newRate;
        }
        public  double getInterestRateObj()
        {
            return interestRate;
        }
    }
}
