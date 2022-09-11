using Hierarchy.Exceptions;

namespace Hierarchy;

public class Mouse : Mammal
{
    private const string Sound = "Piep-piep..!!";

    public Mouse(string type, string name, double weight, string region) : 
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