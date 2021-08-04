using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary1
{
    public class Staff
    {
        private int id;
        private string name;
        private int age;
        private decimal Rate_Salary;
        private decimal Basic_Salary;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public decimal Rate_Salary1 { get => Rate_Salary; set => Rate_Salary = value; }
        public decimal Basic_Salary1 { get => Basic_Salary; set => Basic_Salary = value; }

        public Staff(int id, string name, int age, decimal rate_Salary, decimal basic_Salary)
        {
            this.Id = id;
            this.Name = name;
            this.Age = age;
            Rate_Salary1 = rate_Salary;
            Basic_Salary1 = basic_Salary;
        }

        public Staff()
        {
        }

      

        public virtual decimal Caculate_Salary()
        {
            return Rate_Salary1 * Basic_Salary1;
        }

        public virtual decimal Caculate_Salary(int Allowance)
        {
            return Rate_Salary1 * Basic_Salary1 + (Rate_Salary1 * Basic_Salary1 * Allowance) / 100;
        }

        public virtual void ShowInfor()
        {
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Total salary: {Caculate_Salary()}");
        }
    }
}
