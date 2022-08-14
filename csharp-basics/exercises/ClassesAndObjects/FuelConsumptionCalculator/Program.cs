using System;

namespace FuelConsumptionCalculator
{
    class Program
    {
        private static void Main()
        {
            Car car1 = new(540);

            for (int i = 0; i < 2; i++)
            {
                Console.Write("Enter the current reading: ");
                double currentReading = double.Parse(Console.ReadLine());
                Console.Write("Enter liters reading: ");
                double litersFilled = double.Parse(Console.ReadLine());
                car1.FillUp(currentReading, litersFilled);
            }

            Console.WriteLine($"L/100km: {car1.ConsumptionPer100Km():F2}. The car is a gas hog: {car1.IsGasHog()}");
            Console.WriteLine($"L/100km: {car1.ConsumptionPer100Km():F2}. This is an economy car: {car1.IsEconomyCar()}");
        }
    }
}