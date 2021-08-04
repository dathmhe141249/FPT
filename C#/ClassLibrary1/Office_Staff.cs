using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary1
{
   public class Office_Staff : Staff
    {
        private int Number_NonWorkingDay;
        private decimal Money_Decrease;

        public Office_Staff()
        {
        }

        public Office_Staff(int number_NonWorkingDay, decimal money_Decrease)
        {
            Number_NonWorkingDay1 = number_NonWorkingDay;
            Money_Decrease1 = money_Decrease;
        }

        public int Number_NonWorkingDay1 { get => Number_NonWorkingDay; set => Number_NonWorkingDay = value; }
        public decimal Money_Decrease1 { get => Money_Decrease; set => Money_Decrease = value; }

        public override decimal Caculate_Salary()
        {
            return base.Caculate_Salary() - Number_NonWorkingDay * Money_Decrease;
        }

        public override decimal Caculate_Salary(int allowance)
        {
            return base.Caculate_Salary(allowance) - Number_NonWorkingDay * Money_Decrease;
        }

        public override void ShowInfor()
        {
            base.ShowInfor();
        }
    }
}
