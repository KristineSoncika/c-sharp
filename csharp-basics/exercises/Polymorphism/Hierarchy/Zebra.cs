using Hierarchy.Exceptions;

namespace Hierarchy;

public class Zebra : Mammal
{
    private const string Sound = "Neigh..!";
    
    public Zebra(string type, string name, double weight, string region) : 
        base(type, name, weight, region) { }

    public override string MakeSound()
    {
        return Sound;
    }

    public override void Eat(Food food)
    {
        if (food.ToString() == "Meat")
        {
            throw new InvalidFoodException(GetAnimalType());
        }

        base.Eat(food);
    }
}