using System;

namespace Exercise_9
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a sum (between 2 and 12): ");
            int sum = int.Parse(Console.ReadLine());

            RollTwoDice rollTwoDice = new();
            rollTwoDice.Game(sum);
        }
    }
}