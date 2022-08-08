using System;

namespace Exercise_5
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the first word:");
            string firstWord = Console.ReadLine();
            Console.WriteLine("Enter the second word:");
            string secondWord = Console.ReadLine();

            int lineLength = 30;
            int dotCount = lineLength - firstWord.Length - secondWord.Length;

            Console.Write(firstWord);

            for (int i = 0; i < dotCount; i++)
            {
                Console.Write(".");
            }

            Console.Write(secondWord);
        }
    }
}