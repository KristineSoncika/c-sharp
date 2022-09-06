using Hierarchy.Exceptions;

namespace Hierarchy;

public class Tiger : Feline
{
    private const string Sound = "Grrrrr..!";
        
    public Tiger(string type, string name, double weight, string region) : 
        base(type, name, weight, region) { }

    public override string MakeSound()
    {
        return Sound;
    }

    public override void Eat(Food food)
    {
        if (food.ToString() == "Vegetable")
        {
            throw new InvalidFoodException(GetAnimalType());
        }

        base.Eat(food);
    }
}