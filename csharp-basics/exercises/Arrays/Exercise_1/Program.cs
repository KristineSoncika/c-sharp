using System;

namespace Exercise_1
{
    class Program
    {
        private static void Main()
        {
            int[] numberArray =
            {
                1789, 2035, 1899, 1456, 2013,
                1458, 2458, 1254, 1472, 2365,
                1456, 2165, 1457, 2456
            };

            string[] stringArray =
            {
                "Java",
                "Python",
                "PHP",
                "C#",
                "C Programming",
                "C++"
            };

            Console.WriteLine("Original numeric array : " + string.Join("; ", numberArray));
            Array.Sort(numberArray);
            Console.WriteLine("Sorted numeric array : " + string.Join("; ", numberArray));

            Console.WriteLine("Original string array : " + string.Join("; ", stringArray));
            Array.Sort(stringArray);
            Console.WriteLine("Sorted string array : " + string.Join("; ", stringArray));
        }
    }
}