using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Main
{
    class Bill_Division
    {
        public static void bonAppetit(List<int> bill, int k, int b)
        {
            // bill[k]: món ko ăn
            //b là tiền 
            int refundMoney = 0;
            int money = 0;
            int wrongMoney = 0;
            for (int i = 0; i < bill.Count; i++)
            {
                if(i != k)
                {
                    money += bill[i];
                    wrongMoney += bill[i];
                }
                else
                {
                    refundMoney += bill[i];
                    wrongMoney += bill[i];
                }
            }
            if(money/2 == b)
            {
                Console.WriteLine("Bon Appetit");
            }
            else
            {
                refundMoney = wrongMoney/2 - money/2;
                Console.WriteLine(refundMoney);
            }

        }
    }
}
