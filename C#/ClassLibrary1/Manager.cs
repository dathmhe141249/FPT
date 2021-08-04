using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary1
{
    public class Manager : Staff
    {
        private int Number_BusinessDay;
        private decimal Money_Increase;

        public Manager()
        {
        }

        public Manager(int number_BusinessDay, decimal money_Increase)
        {
            Number_BusinessDay1 = number_BusinessDay;
            Money_Increase1 = money_Increase;
        }

        public int Number_BusinessDay1 { get => Number_BusinessDay; set => Number_BusinessDay = value; }
        public decimal Money_Increase1 { get => Money_Increase; set => Money_Increase = value; }

        public override decimal Caculate_Salary()
        {
            return base.Caculate_Salary() + Number_BusinessDay* Money_Increase;
        }

        public override decimal Caculate_Salary(int Allowance)
        {
            return base.Caculate_Salary(Allowance) + Number_BusinessDay * Money_Increase;
        }
        public override void ShowInfor()
        {
            base.ShowInfor();
        }
    }
}
