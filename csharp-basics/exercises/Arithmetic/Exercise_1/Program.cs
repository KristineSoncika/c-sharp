﻿using System;

namespace Ex_1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(Check15(45, 30));
        }

        static bool Check15(int num1, int num2)
        {
            return num1 == 15 ||
                   num2 == 15 ||
                   num1 + num2 == 15 ||
                   Math.Abs(num1 - num2) == 15;
        }
    }
}
