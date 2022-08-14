using System;
using System.Globalization;

namespace BankAccount
{
    class BankAccount
    {
        private decimal _balance;
        private string _name;

        public BankAccount(decimal balance, string name)
        {
            _balance = balance;
            _name = name;
        }

        public string ShowUserNameAndBalance()
        {
            return $"{_name}, {_balance.ToString("C2", CultureInfo.CreateSpecificCulture("en-US"))}";
        }
    }
}