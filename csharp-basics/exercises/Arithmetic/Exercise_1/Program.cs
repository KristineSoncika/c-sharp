using System;

namespace Exercise_1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(Is15(45, 30));
        }

        static bool Is15(int num1, int num2)
        {
            return num1 == 15 ||
                   num2 == 15 ||
                   num1 + num2 == 15 ||
                   Math.Abs(num1 - num2) == 15;
        }
    }
}

