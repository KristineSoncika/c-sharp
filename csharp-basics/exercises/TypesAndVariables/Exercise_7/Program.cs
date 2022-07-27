using System;

namespace Exercise_7
{
    class Program
    {
        static void Main(string[] args)
        {
            CountUppercaseLetters();
        }
        static void CountUppercaseLetters()
        {
            Console.WriteLine("Enter a word or a sentence: ");
            string sentence = Console.ReadLine();
            int count = 0;
            foreach (char letter in sentence)
            {
                if (Char.IsUpper(letter))
                {
                    count++;
                }
            }
            Console.WriteLine($"The number of uppercase letters in the sentence: {count}.");
        }
    }
}

