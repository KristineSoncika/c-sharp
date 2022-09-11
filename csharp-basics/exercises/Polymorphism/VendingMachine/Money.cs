using System.Globalization;
using VendingMachine.Validations;

namespace VendingMachine;

public readonly struct Money
{
    public int Euros { get; }
    public int Cents { get; }

    public Money(int euros, int cents)
    {
        Validator.ValidateEuros(euros);
        Validator.ValidateCents(cents);
        
        Euros = euros;
        Cents = cents;
    }

    public double GetValue()
    {
        return Euros + Cents * 0.01;
    }

    public override string ToString()
    {
        return string.Format(CultureInfo.InvariantCulture, "{0:F2}", GetValue());
    }
}