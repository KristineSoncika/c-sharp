using System;

namespace Hierarchy
{
    public class Cat : Feline
    {
        protected string _breed;

        public Cat(string type, string name, double weight, string region, string breed) : base(type, name, weight, region)
        {
            _breed = breed;
        }

        public string GetBreed()
        {
            return _breed;
        }

        public override void MakeSound()
        {
            Console.WriteLine("\nMeooow!");
        }

        public override string ToString()
        {
            return $"{GetAnimalType()}[{GetAnimalName()}, {GetAnimalWeight():F1}, {GetRegion()}, {GetBreed()}, {GetFoodEaten()}]";
        }
    }
}