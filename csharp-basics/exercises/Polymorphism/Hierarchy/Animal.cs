using System;

namespace Hierarchy
{
    public abstract class Animal
    {
        protected string _animalType;
        protected string _animalName;
        protected double _animalWeight;
        protected int _foodEaten;

        public Animal(string type, string name, double weight)
        {
            _animalType = type;
            _animalName = name;
            _animalWeight = weight;
        }

        public string GetAnimalType()
        {
            return _animalType;
        }

        public string GetAnimalName()
        {
            return _animalName;
        }

        public double GetAnimalWeight()
        {
            return _animalWeight;
        }

        public int GetFoodEaten()
        {
            return _foodEaten;
        }

        public abstract void MakeSound();

        public virtual void Eat(Food food)
        {
            _foodEaten += food.GetQuantity();
        }
    }
}