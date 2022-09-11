using Hierarchy.Validations;

namespace Hierarchy;

public class Meat : Food
{
    public Meat(int quantity) : base(quantity)
    {
        Validator.ValidateQuantity(quantity);
    }
}