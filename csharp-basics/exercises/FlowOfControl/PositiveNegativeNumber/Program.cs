using System;

namespace PositiveNegativeNumber
{
    class Program
    {
        static void Main()
        {
            PositiveOrNegative();
        }

        static void PositiveOrNegative()
        {
            Console.WriteLine("Enter a number:");
            var num = Convert.ToDouble(Console.ReadLine());

            if (num > 0)
            {
                Console.WriteLine("Number is positive");
            }
            else if (num < 0)
            {
                Console.WriteLine("Number is negative");
            }
            else
            {
                Console.WriteLine("Number is zero");
            }
        }
    }
}
