using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPEx
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Bai 1
            /*Person1[] arrPer = new Person1[3];
            
            for (int i = 0; i < arrPer.Length; i++)
            {
                arrPer[i] = new Person1(Console.ReadLine());
                
            }
            for (int i = 0; i < arrPer.Length; i++)
            {
                Console.WriteLine("Hello! My name is " + arrPer[i].ToString());
            }
            Console.ReadLine();*/
            #endregion

            #region Bai 2
            /* Person p = new Person();
             p.Greet();
             Student s = new Student();
             s.setAge(21);
             s.Greet();
             s.ShowAge();
             Professor pro = new Professor();
             pro.Greet();
             pro.Explain();
             Console.ReadLine();*/
            #endregion
            #region Bai 3
            /* Car c = new Car(0);
             int fuel = Convert.ToInt32(Console.ReadLine());
             if (c.Fuel(fuel))
             {
                 c.Drive();
             }*/
            #endregion

            #region bai 4
            Dog dog = new Dog();
            dog.setName(Console.ReadLine());
            Console.WriteLine(dog.getName());
            dog.Eat();

            Console.ReadLine();
            #endregion
        }
    }
}
