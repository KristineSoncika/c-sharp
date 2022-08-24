using System;

namespace Hierarchy
{
    public class Mouse : Mammal
    {
        public Mouse(string type, string name, double weight, string region) : base(type, name, weight, region)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("\nPiep-piep..!!");
        }

        public override void Eat(Food food)
        {
            if(food.ToString() == "Meat")
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