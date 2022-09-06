using Hierarchy.Validations;

namespace Hierarchy;

public abstract class Animal
{
    private readonly string _animalType;
    private readonly string _animalName;
    private readonly double _animalWeight;
    private int _foodEaten;

    protected Animal(string type, string name, double weight)
    {
        Validator.ValidateType(type);
        Validator.ValidateName(name);
        Validator.ValidateWeight(weight);
        
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

    public abstract string MakeSound();

    public virtual void Eat(Food food)
    {
        _foodEaten += food.GetQuantity();
    }
}