using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPEx
{
    abstract class Animal
    {
        private string name;

        public string getName()
        {
            return name;
        }
        public void setName(string name)
        {
            this.name = name;
        }
        public abstract void Eat();
        
    }
}
