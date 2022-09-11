namespace Hierarchy.Exceptions;

public class InvalidFoodException : Exception
{
    public InvalidFoodException(string animalType) : 
        base($"{animalType} does not eat that type of food!") { }
}