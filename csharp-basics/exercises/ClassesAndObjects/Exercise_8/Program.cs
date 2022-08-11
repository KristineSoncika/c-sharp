using System;
using System.Drawing;

namespace Exercise_8
{
    class Program
    {
        private static void Main()
        {
            Point p1 = new(5, 2);
            Point p2 = new(-3, 6);

            SwapPoints(p1, p2);
            Console.WriteLine($"({p1.X}, {p1.Y})");
            Console.WriteLine($"({p2.X}, {p2.Y})");
        }

        static void SwapPoints(Point point1, Point point2)
        {
            int temporaryX = point1.X;
            int temporaryY = point1.Y;
            point1.X = point2.X;
            point1.Y = point2.Y;
            point2.X = temporaryX;
            point2.Y = temporaryY;
        }
    }
}