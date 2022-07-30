using System;

namespace MoreVariablesAndPrinting
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Zed A. Shaw";
            int age = 35;
            double heightInInches = 74;
            double inchToCm = 2.54;
            double heightInCm = Math.Round(heightInInches * inchToCm, 2);
            double weightInPounds = 180;
            double poundToKg = 0.453592;
            double weightInKg = Math.Round(weightInPounds * poundToKg, 2);
            string eyes = "Blue";
            string teeth = "White";
            string hair = "Brown";

            Console.WriteLine("Let's talk about " + name + ".");
            Console.WriteLine("He's " + heightInCm + " cm tall.");
            Console.WriteLine("He's " + weightInKg + " kg heavy.");
            Console.WriteLine("Actually, that's not too heavy.");
            Console.WriteLine("He's got " + eyes + " eyes and " + hair + " hair.");
            Console.WriteLine("His teeth are usually " + teeth + " depending on the coffee.");
            Console.WriteLine("If I add " + age + ", " + heightInCm + ", and " + weightInKg + " I get " + (age + heightInCm + weightInKg) + ".");
            Console.ReadKey();
        }
    }
}