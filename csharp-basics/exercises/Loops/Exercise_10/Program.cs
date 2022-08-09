using System;

namespace Exercise_10
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter min: ");
            int min = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter max: ");
            int max = int.Parse(Console.ReadLine());

            NumberSquare numberSquare = new();
            numberSquare.GenerateSquare(min, max);
        }
    }
}