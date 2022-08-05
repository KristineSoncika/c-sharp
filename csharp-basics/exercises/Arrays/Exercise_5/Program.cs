using System;

namespace Exercise_5
{
    class Program
    {
        private static void Main()
        {
            int[] numberArray = { 25, 14, 56, 15, 36, 56, 77, 18, 29, 49 };
            FindIndex(numberArray, 36);
            FindIndex(numberArray, 29);
        }

        static void FindIndex(int[] numArr, int num)
        {
            int index = Array.IndexOf(numArr, num);
            Console.WriteLine($"Index position of {num} is: {index}");
        }
    }
}