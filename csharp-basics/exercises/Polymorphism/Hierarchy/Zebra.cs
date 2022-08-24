using System;

namespace Hierarchy
{
    public class Zebra : Mammal
    {
        public Zebra(string type, string name, double weight, string region) : base(type, name, weight, region)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("\nNeigh..!");
        }

        public override void Eat(Food food)
        {
            if (food.ToString() == "Meat")
            {
                Console.WriteLine($"\n{GetAnimalType()} does not eat that type of food!");
            }
            else
            {
                base.Eat(food);
            }
        }
    }
}