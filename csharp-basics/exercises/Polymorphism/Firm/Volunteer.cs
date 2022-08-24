using System;

namespace Firm
{
    public class Volunteer : StaffMember
    {
        public Volunteer(string name, string address, string phone) : base(name, address, phone)
        {
        }

        public override double Pay()
        {
            return 0.0;
        }
    }
}