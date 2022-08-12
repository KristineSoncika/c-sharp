using System;

namespace Account
{
    class Program
    {
        private static void Main()
        {
            Account a = new("A", 100);
            Account b = new("B", 0);
            Account c = new("C", 0);

            Transfer(a, b, 50);
            Transfer(b, c, 25);

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }

        public static void Transfer(Account from, Account to, decimal amount)
        {
            from.Withdrawal(amount);
            to.Deposit(amount);
        }
    }
}