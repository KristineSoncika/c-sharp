using System;

namespace Exercise_8
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a number which will determine the size of the figure: ");
            int lineNumbers = int.Parse(Console.ReadLine());

            AsciiFigure asciiFigure = new();
            asciiFigure.DrawFigure(lineNumbers);
        }
    }
}