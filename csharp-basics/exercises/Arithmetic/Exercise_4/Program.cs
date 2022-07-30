using System;

namespace Exercise_4
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(Product1ToN(4));
        }

        static string Product1ToN(int num)
        {
            int result = 1;
            for (int i = 1; i <= num; i++)
            {
                result *= i;
            }

            return $"The factorial of {num} is {result}.";
        }
    }
}

