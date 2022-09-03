using ScooterRental.Exceptions;

namespace ScooterRental.Validations;

public static class Validator
{
    public static void ValidateId(string id)
    {
        if (string.IsNullOrEmpty(id))
        {
            throw new InvalidIdException();
        }
    }

    public static void ValidateIfIdExists(Scooter scooter)
    {
        if (scooter == null)
        {
            throw new ScooterDoesNotExistException();
        }
    }
}