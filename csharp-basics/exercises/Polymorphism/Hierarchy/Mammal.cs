using System.Globalization;
using Hierarchy.Validations;

namespace Hierarchy;

public abstract class Mammal : Animal
{
    private readonly string _region;

    protected Mammal(string type, string name, double weight, string region) : base(type, name, weight)
    {
        Validator.ValidateRegion(region);
        _region = region;
    }

    public string GetRegion()
    {
        return _region;
    }

    public override string ToString()
    {
        return $"{GetAnimalType()}[{GetAnimalName()}, {GetAnimalWeight().ToString("0.0", CultureInfo.InvariantCulture)}, {GetRegion()}, {GetFoodEaten()}]";
    }
}