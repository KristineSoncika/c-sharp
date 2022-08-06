using System;

namespace Exercise_6
{
    class Program
    {
        private static void Main()
        {
            CreateNumberArray();
        }

        static void CreateNumberArray()
        {
            Random randomNum = new();
            int[] numberArray = new int[10];

            for (int i = 0; i < numberArray.Length; i++)
            {
                numberArray[i] = randomNum.Next(1, 101);
            }

            int[] numberArrayCopy = new int[10];
            numberArray.CopyTo(numberArrayCopy, 0);
            numberArray[numberArray.Length - 1] = -7;

            Console.WriteLine($"Array 1: {String.Join(" ", numberArray)}");
            Console.WriteLine($"Array 2: {String.Join(" ", numberArrayCopy)}");
        }
    }
}