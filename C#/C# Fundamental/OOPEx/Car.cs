using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPEx
{
    class Car : IVehicle
    {
        private int fuel;

        public Car()
        {
        }

        public Car(int fuel)
        {
            this.Fuel1 = fuel;
        }

        public int Fuel1 { get => fuel; set => fuel = value; }

        public void Drive()
        {
            if (fuel > 0)
            {
                Console.WriteLine("Driving");
            }
            else
            {
                Console.WriteLine("Not Fuel");
            }
        }

        public bool Fuel(int amount)
        {
            fuel += amount;
            return true;
        }
    }
}
