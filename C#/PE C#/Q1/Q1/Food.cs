using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Q1
{
    class Food : IFood
    {
        public delegate void whenAmountChanged(float amount1, float amount2);
        float amount;

        public Food()
        {
        }

        public Food(float amount)
        {
            this.amount = amount;
        }

        public event whenAmountChanged AmountChanged;
        public float Amount
        {
            get { return amount; }
            set
            {
                if (value != amount)
                {
                    if (AmountChanged != null)
                    {
                        AmountChanged(amount, value);
                    }
                    amount = value;
                }
            }
        }
        public float ComputeCalory()
        {
            return amount * 0.05f;
        }
    }
}
