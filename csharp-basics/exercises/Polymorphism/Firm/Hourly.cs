using System;

namespace Firm
{
    public class Hourly : Employee
    {
        private int _hoursWorked;

        public Hourly(string name, string address, string phone, string socSecNumber, double rate) : base(name, address, phone, socSecNumber, rate)
        {
            _hoursWorked = 0;
        }

        public void AddHours(int moreHours)
        {
            _hoursWorked += moreHours;
        }

        public override string ToString()
        {
            return  $"{base.ToString()} | " +
                    $"Current hours: {_hoursWorked}";
        }

        public override double Pay()
        {
            var payment = PayRate * _hoursWorked;
            _hoursWorked = 0;
            return payment;
        }
    }
}