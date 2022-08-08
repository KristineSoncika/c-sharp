using System;

namespace Exercise_7
{
    public class Piglet
    {
        public void Game()
        {
            Random randomNum = new();
            int dice = randomNum.Next(1, 7);
            int total = 0;
            string reply = "yes";

            Console.WriteLine("Welcome to Piglet!");

            while (reply == "yes")
            {
                if (dice == 1)
                {
                    total = 0;
                    Console.WriteLine($"You rolled {dice}");
                    Console.WriteLine($"Game over!. You got {total} points.");
                    Environment.Exit(0);
                }

                Console.WriteLine($"You rolled {dice}");
                total += dice;
                Console.WriteLine($"Roll again? Type YES or NO");
                reply = Console.ReadLine().ToLower();
                dice = randomNum.Next(1, 7);  
            }

            Console.WriteLine($"Game over!. You got {total} points.");
        }
    }
}