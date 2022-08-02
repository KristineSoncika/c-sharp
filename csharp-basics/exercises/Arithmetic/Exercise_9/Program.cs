using System;

namespace Exercise_9
{
    class Program
    {
        static void Main()
        {
            BMICalculator(60, 173);
        }

        static void BMICalculator(double weight, double height)
        {
            double weightInPounds = weight * 2.2;
            double heightInInches = height / 2.54;

            double bmi = Math.Round(weightInPounds * 703 / Math.Pow(heightInInches, 2), 1);

            if(bmi < 18.5)
            {
                Console.WriteLine($"Your BMI is {bmi}. You are underweight.");
            }
            else if (bmi > 25)
            {
                Console.WriteLine($"Your BMI is {bmi}. You are overweight.");
            }
            else
            {
                Console.WriteLine($"Your BMI is {bmi}. You have optimal weight.");
            }
        }
    }
}