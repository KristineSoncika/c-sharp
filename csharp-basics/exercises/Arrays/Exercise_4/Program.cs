using System;

namespace Exercise_4
{
    class Program
    {
        private static void Main()
        {
            int[] numberArray =
            {
                1789, 2035, 1899, 1456, 2013,
                1458, 2458, 1254, 1472, 2365,
                1456, 2265, 1457, 2456
            };

            Console.WriteLine(Contains(numberArray, 2457));
        }

        static string Contains(int[] arr, int item)
        {
            if (Array.IndexOf(arr, item) == -1)
            {
                return "Does not contain!";
            }
            else
            {
                return "Contains!";
            }
        }
    }
}