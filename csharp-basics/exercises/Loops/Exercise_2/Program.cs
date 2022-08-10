using System;

namespace Exercise_2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine($"The result is: {Exponentiation(3, 8)}");   
        }

        static int Exponentiation(int baseNum, int exponent)
        {
            int result = 1;

            for (int i = 0; i < exponent; i++)
            {
                result *= baseNum;
            }

            return result;
        }
    }
}