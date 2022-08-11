using System;
using System.Globalization;

namespace Exercise_7
{
    class Program
    {
        private static void Main()
        {
            Console.Write("What is the current balance of your account: ");
            decimal startingBalance = decimal.Parse(Console.ReadLine());
            SavingsAccount savingsAccount1 = new(startingBalance);

            Console.Write("Enter the annual interest rate: ");
            decimal annualInterest = decimal.Parse(Console.ReadLine());

            Console.Write("How long has the account been opened (in months): ");
            int months = int.Parse(Console.ReadLine());

            for (int i = 1; i <= months; i++)
            {
                Console.Write($"Enter the amount deposited in month {i}: ");
                decimal deposit = decimal.Parse(Console.ReadLine());
                savingsAccount1.AddDeposit(deposit);

                Console.Write($"Enter the amount withdrawn in month {i}: ");
                decimal withdrawal = decimal.Parse(Console.ReadLine());
                savingsAccount1.AddWithdrawal(withdrawal);

                savingsAccount1.AddMonthlyInterest(annualInterest);
            }

            CultureInfo culture = CultureInfo.CreateSpecificCulture("en-US");

            string totalDeposited = savingsAccount1.GetTotalDeposited().ToString("C2", culture);
            string totalWithdrawn = savingsAccount1.GetTotalWithdrawn().ToString("C2", culture);
            string interestEarned = savingsAccount1.GetInterestEarned().ToString("C2", culture);
            string balance = savingsAccount1.GetBalance().ToString("C2", culture);

            Console.WriteLine($"Total deposited: {totalDeposited}");
            Console.WriteLine($"Total withdrawn: {totalWithdrawn}");
            Console.WriteLine($"Interest earned: {interestEarned}");
            Console.WriteLine($"Ending balance: {balance}");
        }
    }
}