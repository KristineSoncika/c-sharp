using System;

namespace Exercise_6
{
    public class FizzBuzz
    {
        public void Game()
        {
            Console.WriteLine("Enter a number between 1 and 100:");
            int number = int.Parse(Console.ReadLine());

            string fizzbuzz = "";

            for (int i = 1; i <= number; i++)
            {
                if (!(i % 3 == 0) && !(i % 5 == 0))
                {
                    Console.Write($"{i} ");
                }
                if (i % 3 == 0)
                {
                    fizzbuzz += "Fizz";
                }
                if (i % 5 == 0)
                {
                    fizzbuzz += "Bazz";
                }

                Console.Write($"{fizzbuzz} ");
                fizzbuzz = "";

                if (i % 20 == 0)
                {
                    Console.Write(Environment.NewLine);
                }
            }
        }
    }
}

