using System;

namespace Firm
{
    public class Executive : Employee
    {
        private double _bonus;

        public Executive(string name, string address, string phone, string socSecNumber, double rate) : base(name, address, phone, socSecNumber, rate)
        {
            _bonus = 0;
        }

        public void AwardBonus(double execBonus)
        {
            _bonus = execBonus;
        }

        public override double Pay()
        {
            var payment = base.Pay() + _bonus;
            _bonus = 0;
            return payment;
        }
    }
}