using System.Globalization;
using Hierarchy.Validations;

namespace Hierarchy;

public class Cat : Feline
{
    private readonly string _breed;
    private const string Sound = "Meooow!";

    public Cat(string type, string name, double weight, string region, string breed) : base(type, name, weight, region)
    {
        Validator.ValidateBreed(breed);
        _breed = breed;
    }

    public string GetBreed()
    {
        return _breed;
    }

    public override string MakeSound()
    {
        return Sound;
    }

    public override string ToString()
    {
        return $"{GetAnimalType()}[{GetAnimalName()}, {GetAnimalWeight().ToString("0.0", CultureInfo.InvariantCulture)}, {GetRegion()}, {GetBreed()}, {GetFoodEaten()}]";
    }
}