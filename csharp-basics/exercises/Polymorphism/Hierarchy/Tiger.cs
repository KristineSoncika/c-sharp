using System;

namespace Hierarchy
{
    public class Tiger : Feline
    {
        public Tiger(string type, string name, double weight, string region) : base(type, type, weight, region)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("\nGrrrrr..!");
        }

        public override void Eat(Food food)
        {
            if (food.ToString() == "Vegetable")
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