using System;

namespace Firm
{
    public class Employee : StaffMember
    {
        private string _socialSecurityNumber;
        protected double PayRate;

        public Employee(string name, string address, string phone, string socSecNumber, double rate) : base(name, address, phone)
        {
            _socialSecurityNumber = socSecNumber;
            PayRate = rate;
        }

        public override string ToString()
        {
            return  $"{base.ToString()} | " +
                    $"Social Security Number: {_socialSecurityNumber}";
        }

        public override double Pay()
        {
            return PayRate;
        }
    }
}