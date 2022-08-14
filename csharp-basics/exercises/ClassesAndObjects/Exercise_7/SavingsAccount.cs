using System;

namespace Exercise_7
{
    class SavingsAccount
    {
        private decimal _balance;
        private decimal _withdrawn;
        private decimal _deposited;
        private decimal _interestEarned;

        public SavingsAccount(decimal balance)
        {
            _balance = balance;
        }

        public decimal GetBalance()
        {
            return _balance;
        }

        public decimal GetTotalWithdrawn()
        {
            return _withdrawn;
        }

        public decimal GetTotalDeposited()
        {
            return _deposited;
        }

        public decimal GetInterestEarned()
        {
            return _interestEarned;
        }

        public void AddWithdrawal(decimal withdrawal)
        {
            _balance -= withdrawal;
            _withdrawn += withdrawal;
        }

        public void AddDeposit(decimal deposit)
        {
            _balance += deposit;
            _deposited += deposit;
        }

        public void AddMonthlyInterest(decimal annualInterest)
        {
            decimal monthlyInterest = annualInterest / 12;
            decimal monthlyInterestEarned = _balance * monthlyInterest;
            _interestEarned += monthlyInterestEarned;
            _balance += monthlyInterestEarned;
        }
    }
}