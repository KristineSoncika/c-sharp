using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public struct Money
    {
        public int Euros { get; set; }
        public int Cents { get; set; }

        public Money(int euros, int cents)
        {
            Euros = euros;
            Cents = cents;
        }

        public double GetValue()
        {
            return Euros + Cents * 0.01;
        }

        public override string ToString()
        {
            return String.Format("{0:F2}", Euros + Cents * 0.01);
        }
    }
}