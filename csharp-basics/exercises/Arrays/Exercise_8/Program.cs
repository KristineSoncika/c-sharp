using System;

namespace Exercise_8
{
    class Program
    {
        private static string[] words = { "void", "sunny", "fish", "hedgehog", "lithium", "transition", "nutmeg", "earphones", "shenanigans", "pillow" };
        private static List<string> word = new();
        private static string guesses = "";
        private static string misses = "";
        private static int guessCount = 9;
        private static string pickedWord = "";

        private static void Main()
        {
            StartGame();
            Guess();
        }

        private static void GuessingBoard()
        {
            Console.WriteLine($"\n-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
            Console.WriteLine($"\nWord: {string.Join(" ", word)}");
            Console.WriteLine($"\nGuessed letters: {guesses}");
            Console.WriteLine($"\nMissed letters: {misses}");
            Console.WriteLine($"\nMisses left: {guessCount}");
            Console.WriteLine($"\n-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
        }

        private static void StartGame()
        {
            Random randomNum = new();
            pickedWord = words[randomNum.Next(10)];

            Console.WriteLine("\nWelcome to HANGMAN!");
            Console.WriteLine("Press any key to start the game.");
            Console.ReadKey(true);

            for (int i = 0; i < pickedWord.Length; i++)
            {
                word.Add("_");
            }

            GuessingBoard();
        }

        private static void Guess()
        {
            Console.WriteLine("\nType a letter and hit ENTER:");
            string guess = Console.ReadLine();

            while (guessCount > 0)
            {
                if (pickedWord.Contains(guess))
                {
                    for (int i = 0; i < pickedWord.Length; i++)
                    {
                        int letterIndex = pickedWord.IndexOf(guess, i);

                        if (letterIndex >= 0)
                        {
                            word[letterIndex] = guess;
                            i = letterIndex;
                        }
                    }
                    guesses += guess;
                }
                else
                {
                    misses += guess;
                    guessCount--;
                }

                GuessingBoard();
                GameResult();

                Console.WriteLine("\nType another letter:");
                guess = Console.ReadLine();
            }
        }

        private static void GameResult()
        {
            if (guessCount == 0)
            {
                Console.WriteLine("\nYou lost!");
                PlayAgain();
            }

            else if (String.Join("", word) == pickedWord)
            {
                Console.WriteLine("\nYOU GOT IT!");
                PlayAgain();
            }
        }

        private static void PlayAgain()
        {
            word.Clear();
            guesses = "";
            misses = "";
            guessCount = 9;

            Console.WriteLine("\nWanna continue? Type YES or NO:");
            string choice = Console.ReadLine();
            choice = choice.ToUpper();

            if (choice == "YES")
            {
                StartGame();
                Guess();
            }
            else if (choice == "NO")
            {
                Console.WriteLine("\nYou exited the game.");
                Environment.Exit(0);
            }
        }
    }
}