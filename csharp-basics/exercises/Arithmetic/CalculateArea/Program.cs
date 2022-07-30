using System;

namespace CalculateArea
{
    class Program
    {
        static void Main()
        {
            GetMenu();
        }

        public static int GetMenu()
        {
            Console.WriteLine("Geometry Calculator\n");
            Console.WriteLine("1. Calculate the Area of a Circle");
            Console.WriteLine("2. Calculate the Area of a Rectangle");
            Console.WriteLine("3. Calculate the Area of a Triangle");
            Console.WriteLine("4. Quit\n");
            Console.WriteLine("Enter your choice (1-4): ");
            int userChoice = Convert.ToInt32(Console.ReadLine());

            while (userChoice < 1 || userChoice > 4)
            {
                Console.WriteLine("Enter a number between 1 and 4:");
                userChoice = Convert.ToInt32(Console.ReadLine());
            }

            if (userChoice == 1)
            {
                CalculateCircleArea();
            }
            else if (userChoice == 2)
            {
                CalculateRectangleArea();
            }
            else if (userChoice == 3)
            {
                CalculateTriangleArea();
            }
            else
            {
                Console.WriteLine("You exited the Geometry Calculator!");
            }

            return userChoice;
        }

        public static void CalculateCircleArea()
        {
            Console.WriteLine("What is the circle's radius?");
            double radius = Convert.ToDouble(Console.ReadLine());

            while(radius <= 0)
            {
                Console.WriteLine("Enter a number greater than 0");
                radius = Convert.ToDouble(Console.ReadLine());
            }

            Console.WriteLine($"The circle's area is {Geometry.AreaOfCircle(radius)}.");
        }

        public static void CalculateRectangleArea()
        {
            Console.WriteLine("Enter length?");
            double length = Convert.ToDouble(Console.ReadLine());

            while (length <= 0)
            {
                Console.WriteLine("Enter a number greater than 0");
                length = Convert.ToDouble(Console.ReadLine());
            }

            Console.WriteLine("Enter width?");
            double width = Convert.ToDouble(Console.ReadLine());

            while (width <= 0)
            {
                Console.WriteLine("Enter a number greater than 0");
                width = Convert.ToDouble(Console.ReadLine());
            }

            Console.WriteLine($"The rectangle's area is {Geometry.AreaOfRectangle(length, width)}.");
        }

        public static void CalculateTriangleArea()
        {
            Console.WriteLine("Enter length of the triangle's base?");
            double ground = Convert.ToDouble(Console.ReadLine());

            while (ground <= 0)
            {
                Console.WriteLine("Enter a number greater than 0");
                ground = Convert.ToDouble(Console.ReadLine());
            }

            Console.WriteLine("Enter triangle's height?");
            double height = Convert.ToDouble(Console.ReadLine());

            while (height <= 0)
            {
                Console.WriteLine("Enter a number greater than 0");
                height = Convert.ToDouble(Console.ReadLine());
            }

            Console.WriteLine($"The triangle's area is {Geometry.AreaOfTriangle(ground, height)}.");
        }
    }
}
