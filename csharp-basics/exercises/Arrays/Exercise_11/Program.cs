using System;

namespace Exercise_11
{
    class Program
    {
        private static void Main()
        {
            FindNemo("I am finding Nemo !");
            FindNemo("Nemo is me");
            FindNemo("I Nemo am");
            FindNemo("Nemo's cat is black");
        }

        static void FindNemo(string sentence)
        {
            string[] wordArr = sentence.Split(" ");
            int wordIndex = Array.IndexOf(wordArr, "Nemo");
            int wordOrder = wordIndex + 1;

            if (wordIndex == -1)
            {
                Console.WriteLine("I can't find Nemo :(");
            }
            else
            {
                Console.WriteLine($"I found Nemo at {wordOrder}!");
            }
        }
    }
}