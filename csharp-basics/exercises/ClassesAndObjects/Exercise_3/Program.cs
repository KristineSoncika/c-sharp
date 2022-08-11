using System;

namespace Exercise_3
{
    class Program
    {
        private static void Main()
        {
            FuelGauge fuelGauge1 = new(35);

            while (fuelGauge1.ShowLitersLeft() != FuelGauge.TankSize)
            {
                fuelGauge1.IncrementFuel();
            }

            Odometer odometer1 = new(4550, fuelGauge1);

            while (fuelGauge1.ShowLitersLeft() > 0)
            {
                odometer1.IncrementKm();
                Console.WriteLine(odometer1.ReportKm());
                Console.WriteLine(fuelGauge1.ShowLitersLeft());
            }

            Console.WriteLine($"Odometer: {odometer1.ReportKm()} km");
            Console.WriteLine($"Fuel: {fuelGauge1.ShowLitersLeft()} liters left");
        }
    }
}