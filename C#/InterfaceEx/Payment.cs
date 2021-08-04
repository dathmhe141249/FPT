using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterfaceEx
{
    class Payment : ITax
    {
        public delegate void notifyAmountChanged(float amount, float amount2);
        private float Amount;
        public event notifyAmountChanged AmountChanged;

        public float Amount1 { get { return Amount; }
            set {
                if (value != Amount)
                {
                    if (AmountChanged != null)
                    {
                        AmountChanged(Amount, value);
                    }
                    Amount = value;
                }
            }
                }

        

        public Payment(float amount)
        {
            Amount1 = amount;
        }


        public float ComputeTax()
        {
            return Amount1 * 0.1f;
        }

       

    }
}
