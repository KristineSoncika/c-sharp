using System;

namespace Account
{
    class Account
    {
        private string _name;
        private decimal _balance;

        public Account(string name, decimal balance)
        {
            _name = name;
            _balance = balance;
        }

        public void Withdrawal(decimal withdrawn)
        {
            _balance -= withdrawn;
        }

        public void Deposit(decimal deposited)
        {
            _balance += deposited;
        }

        public decimal Balance()
        {
            return _balance;
        }

        public string Name => _name;

        public override string ToString()
        {
            return $"{Name}: {_balance:F2}";
        }
    }
}