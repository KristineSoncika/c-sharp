using System;

namespace Exercise_2
{
    class Program
    {
        private static void Main()
        {
            NumSum();
        }

        static void NumSum()
        {
            Console.WriteLine("Please enter min number:");
            int minNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter max number:");
            int maxNumber = Convert.ToInt32(Console.ReadLine());

            int[] numbers = new int[maxNumber - 1];

            for (int i = 0; i < maxNumber - 1; i++)
            {
                numbers[i] = minNumber;
                minNumber++;
            }

            int sum = numbers.Sum();
            Console.WriteLine($"The sum is {sum}");
        }
    }
}