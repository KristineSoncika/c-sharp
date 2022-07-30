using System;

namespace Exercise_5
{
    class Program
    {
        static void Main()
        {
            GuessNumber();
        }

        static void GuessNumber()
        {
            Random rand = new Random();
            int randNum = rand.Next(1, 101);

            Console.WriteLine("I'm thinking of a number between 1-100. Try to guess it.");
            int guess = Convert.ToInt32(Console.ReadLine());

            if (guess < randNum)
            {
                Console.WriteLine($"Sorry, too low. I was thinking of {randNum}.");
            }
            else if (guess > randNum)
            {
                Console.WriteLine($"Sorry, too high. I was thinking of {randNum}.");
            }
            else
            {
                Console.WriteLine($"You guessed it! What are the odds?!?");
            }
        }
    }
}



