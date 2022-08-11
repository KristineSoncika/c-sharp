using System;

namespace EnergyDrinks
{
    class Program
    {
        private const int customersSurveyed = 12467;
        private const double purchasedEnergyDrinks = 0.14;
        private const double preferCitrusDrinks = 0.64;

        private static void Main()
        {
            Console.WriteLine($"Total number of people surveyed: {customersSurveyed}");
            Console.WriteLine($"Approximately {CustomersBuyingEnergyDrinks(customersSurveyed)} customers bought at least one energy drink");
            Console.WriteLine($"Around {CustomersPreferingCitrusDrinks(customersSurveyed)} of them prefer citrus-flavored energy drinks");
        }

        private static double CustomersBuyingEnergyDrinks(int customersSurvayed)
        {
            return Math.Floor(purchasedEnergyDrinks * customersSurvayed);
        }

        private static double CustomersPreferingCitrusDrinks(int customersSurvayed)
        {
            return Math.Floor(preferCitrusDrinks * CustomersBuyingEnergyDrinks(customersSurvayed));
        }
    }
}