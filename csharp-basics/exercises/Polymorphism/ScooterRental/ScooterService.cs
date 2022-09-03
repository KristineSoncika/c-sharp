using ScooterRental.Exceptions;
using ScooterRental.Validations;

namespace ScooterRental;

public class ScooterService : IScooterService
{
    private readonly List<Scooter> _scooters;
    
    public ScooterService(List<Scooter> scooters)
    {
        _scooters = scooters;
    }

    public void AddScooter(string id, decimal pricePerMinute)
    {
        Validator.ValidateId(id);
        
        if (_scooters.Any(s => s.Id == id))
        {
            throw new IdMustBeUniqueException(id);
        }

        if (pricePerMinute <= 0)
        {
            throw new InvalidPriceException(pricePerMinute);
        }

        _scooters.Add(new Scooter(id, pricePerMinute));
    }

    public void RemoveScooter(string id)
    {
        var scooter = _scooters.FirstOrDefault(s => s.Id == id);
        Validator.ValidateId(id);
        Validator.ValidateIfIdExists(scooter);

        if (scooter.IsRented)
        {
            throw new ScooterIsRentedOutException(id);
        }
        
        _scooters.Remove(scooter);
    }

    public IList<Scooter> GetScooters()
    {
        var availableScooters = _scooters.FindAll(s => s.IsRented == false);
        
        if (availableScooters.Count < 1)
        {
            throw new NoAvailableScootersFoundException();
        }

        return availableScooters;
    }

    public Scooter GetScooterById(string id)
    {
        var scooter = _scooters.FirstOrDefault(s => s.Id == id);
        Validator.ValidateId(id);
        Validator.ValidateIfIdExists(scooter);
        
        return scooter;
    }
}