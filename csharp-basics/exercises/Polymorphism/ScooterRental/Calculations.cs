using ScooterRental.Exceptions;
using ScooterRental.Interfaces;

namespace ScooterRental;

public class Calculations : ICalculations
{
    public decimal CalculateRentalPrice(DateTime start, DateTime end, decimal pricePerMinute)
    {
        const decimal maxPricePerDay = 20.0m;

        if (start.Day == end.Day)
        {
            if ((decimal)(end - start).TotalMinutes * pricePerMinute > maxPricePerDay)
            {
                return maxPricePerDay;
            }

            return Math.Round((decimal)(end - start).TotalMinutes * pricePerMinute, 2, MidpointRounding.AwayFromZero);
        }

        decimal rentalPrice = 0;
        const int minutesInDay = 1440;
        decimal rentalDays = (end.Date - start.Date).Days - 1;

        var firstDayPrice = (minutesInDay - (decimal)start.TimeOfDay.TotalMinutes) * pricePerMinute;
        rentalPrice += firstDayPrice > maxPricePerDay ? maxPricePerDay : firstDayPrice;

        var lastDayPrice = (decimal)end.TimeOfDay.TotalMinutes * pricePerMinute;
        rentalPrice += lastDayPrice > maxPricePerDay ? maxPricePerDay : lastDayPrice;
        
        var restOfDaysPrice = maxPricePerDay * rentalDays;
        rentalPrice += restOfDaysPrice;

        return Math.Round(rentalPrice, 2, MidpointRounding.AwayFromZero);
    }

    public decimal CalculateRentalIncome(List<RentedScooter> rentals, bool includeNotCompletedRentals)
    {
        decimal sum = 0;
        
        if (includeNotCompletedRentals == false)
        {
            sum = rentals
                .Where(rental => rental.RentalEnd != null)
                .Sum(rental => CalculateRentalPrice(rental.RentalStart, (DateTime)rental.RentalEnd, rental.PricePerMinute));

            return Math.Round(sum, 2, MidpointRounding.AwayFromZero);
        }
        
        foreach (var rental in rentals)
        {
            if (rental.RentalEnd == null)
            {
                rental.RentalEnd = DateTime.Now;
            }

            sum += CalculateRentalPrice(rental.RentalStart, (DateTime)rental.RentalEnd, rental.PricePerMinute);
        }

        return Math.Round(sum, 2, MidpointRounding.AwayFromZero);
    }

    public decimal CalculateYearlyRentalIncome(List<RentedScooter> rentals, bool includeNotCompletedRentals, int year)
    {
        var rentalsInGivenYear = rentals.FindAll(rental => rental.RentalStart.Year == year);
        
        if (rentalsInGivenYear.Count < 1)
        {
            throw new NoRentalsInGivenYearException(year);
        }
        
        return CalculateRentalIncome(rentalsInGivenYear, includeNotCompletedRentals);
    }
}