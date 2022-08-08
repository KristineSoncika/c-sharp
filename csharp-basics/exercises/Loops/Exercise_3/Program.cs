using System;

namespace Exercise_3
{
    class Program
    {
        static void Main()
        {
            Random randomNumber = new();
            List<int> numbers = new();

            for (int i = 0; i < 20; i++)
            {
                numbers.Add(randomNumber.Next(1, 101));
            }

            Console.WriteLine("There are 20 random numbers, which one do you want to know? Enter a position:");
            int position = int.Parse(Console.ReadLine());
            Console.WriteLine($"The number at the position {position} is {numbers[position-1]}");
        }
    }
}