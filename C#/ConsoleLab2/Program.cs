using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClassLibrary1;
namespace ConsoleLab2
{
    class Program
    {
        public static List<Office_Staff> office_Staffs = new List<Office_Staff>();
        public static List<Manager> managers = new List<Manager>();
        static void Main(string[] args)
        {
            


        }

        public static void inputStaff()
        {
            for (int i = 0; i < 2; i++)
            {
                //declare o_staff
                Office_Staff officeStaff = new Office_Staff();
                Console.WriteLine("Input Office staff: #" + (i + 1));

                Console.Write("ID: ");
                officeStaff.Id = int.Parse(Console.ReadLine());

                Console.Write("Name: ");
                officeStaff.Name = Console.ReadLine();

                Console.Write("Age: ");
                officeStaff.Age = int.Parse(Console.ReadLine());

                Console.Write("Rate salary: ");
                officeStaff.Rate_Salary1 = decimal.Parse(Console.ReadLine());

                Console.Write("Basic salary: ");
                officeStaff.Basic_Salary1 = int.Parse(Console.ReadLine());

                Console.Write("Allowance: ");
                //officeStaff = int.Parse(Console.ReadLine());

                Console.Write("Number non-working day: ");
                officeStaff.Number_NonWorkingDay1 = int.Parse(Console.ReadLine());

                Console.Write("Money decrease: ");
                officeStaff.Money_Decrease1 = int.Parse(Console.ReadLine());
                office_Staffs.Add(officeStaff);
                Console.WriteLine("------------");
            }
        }
    }
}
