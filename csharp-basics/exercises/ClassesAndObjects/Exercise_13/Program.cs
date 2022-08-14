using System;

namespace Exercise_13
{
    class Program
    {
        private static void Main()
        {
            Smoothie s1 = new(new string[] { "Banana" });
            s1.GetCost();
            s1.GetPrice();
            s1.GetName();

            Smoothie s2 = new(new string[] { "Raspberries", "Strawberries", "Blueberries" });
            s2.GetCost();
            s2.GetPrice();
            s2.GetName();
        }
    }
}