using System;

namespace Hierarchy
{
    public abstract class Mammal : Animal
    {
        protected string _region;

        public Mammal(string type, string name, double weight, string region) : base(type, name, weight)
        {
            _region = region;
        }

        public string GetRegion()
        {
            return _region;
        }

        public override string ToString()
        {
            return $"{GetAnimalType()}[{GetAnimalName()}, {GetAnimalWeight():F1}, {GetRegion()}, {GetFoodEaten()}]";
        }
    }
}