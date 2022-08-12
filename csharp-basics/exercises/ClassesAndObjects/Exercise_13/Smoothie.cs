using System;

namespace Exercise_13
{
    public class Smoothie
    {
        private string[] Ingredients;
        private List<string> _ingredients = new List<string> { "Strawberries", "Banana", "Mango", "Blueberries", "Raspberries", "Apple", "Pineapple" };
        private List<double> _prices = new List<double> {1.50, 0.50, 2.50, 1.00, 1.00, 1.75, 3.50 };
       
        public Smoothie(string[] ingredients)
        {
            Ingredients = ingredients;
        }

        private double CalculateCost()
        {
            double totalCost = 0;

            foreach (var ingredient in Ingredients)
            {
                for (int i = 0; i < _ingredients.Count; i++)
                {
                    if (ingredient == _ingredients[i])
                    {
                        totalCost += _prices[i];
                    }
                }
            }

            return totalCost;
        }

        public void GetCost()
        {
            Console.WriteLine($"£{CalculateCost()}");
        }

        private double CalculatePrice()
        {
            return Math.Round((CalculateCost() + CalculateCost() * 1.5), 2);
        }

        public void GetPrice()
        {
            Console.WriteLine($"£{CalculatePrice()}");
        }

        public void GetName()
        {
            string name = "";
            List<string> fruits = new();

            foreach (var fruit in Ingredients)
            {
                if(fruit.Contains("berries"))
                {
                    fruits.Add(fruit.Replace("berries", "berry"));
                }
                else
                {
                    fruits.Add(fruit);
                }
            }

            fruits.Sort();


            if (fruits.Count == 1)
            {
                name += $"{fruits[0]} Smoothie";
            }
            else
            {
                foreach (var fruit in fruits)
                {
                    name += $"{fruit} ";
                }

                name += "Fusion";
            }

            Console.WriteLine(name);
        }
    }
}