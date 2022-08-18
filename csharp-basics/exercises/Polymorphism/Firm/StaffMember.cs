using System;

namespace Firm
{
    public abstract class StaffMember
    {
        private string _name;
        private string _address;
        private string _phone;

        protected StaffMember(string name, string address, string phone)
        {
            _name = name;
            _address = address;
            _phone = phone;
        }

        public override string ToString()
        {
            return  $"Name: {_name} | " +
                    $"Address: { _address} | " +
                    $"Phone: {_phone}";
        }

        public abstract double Pay();
    }
}