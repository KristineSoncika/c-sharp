using System;

namespace CalculateArea
{
    public class Geometry
    {
        public static double AreaOfCircle(double radius)
        {
            return Math.Round(Math.PI * Math.Pow(radius, 2), 2);
        }

        public static double AreaOfRectangle(double length, double width)
        {
            return Math.Round(length * width, 2);
        }

        public static double AreaOfTriangle(double ground, double height)
        {
            return Math.Round(ground * height * 0.5, 2);
        }
    }
}
