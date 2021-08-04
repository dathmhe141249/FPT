using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPEx
{
    class Person1
    {
        private string name;

        public string Name { get => name; set => name = value; }

        public Person1(string name)
        {
            this.Name = name;
        }

        public Person1()
        {
        }

        public override string ToString()
        {
            return name;
        }
    }
}
