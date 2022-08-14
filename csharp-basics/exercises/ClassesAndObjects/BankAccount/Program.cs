using System;
using System.Globalization;

namespace BankAccount
{
    class Program
    {
        private static void Main()
        {
            BankAccount benben = new(-17.25m, "Benson");

            Console.WriteLine(benben.ShowUserNameAndBalance());
        }
    }
}