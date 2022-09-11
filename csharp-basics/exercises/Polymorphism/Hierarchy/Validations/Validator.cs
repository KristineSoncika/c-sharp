using Hierarchy.Exceptions;

namespace Hierarchy.Validations;

public static class Validator
{
    public static void ValidateType(string type)
    {
        if (string.IsNullOrEmpty(type))
        {
            throw new InvalidTypeException();
        }
    }
    
    public static void ValidateName(string name)
    {
        if (string.IsNullOrEmpty(name))
        {
            throw new InvalidNameException();
        }
    }
    
    public static void ValidateWeight(double weight)
    {
        if (weight <= 0)
        {
            throw new InvalidWeightException();
        }
    }
    
    public static void ValidateRegion(string region)
    {
        if (string.IsNullOrEmpty(region))
        {
            throw new InvalidRegionException();
        }
    }
    
    public static void ValidateBreed(string breed)
    {
        if (string.IsNullOrEmpty(breed))
        {
            throw new InvalidBreedException();
        }
    }
    
    public static void ValidateQuantity(double quantity)
    {
        if (quantity <= 0)
        {
            throw new InvalidQuantityException();
        }
    }
}