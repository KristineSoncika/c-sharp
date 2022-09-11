using Hierarchy.Validations;

namespace Hierarchy;

public class Vegetable : Food
{
    public Vegetable(int quantity) : base(quantity)
    {
        Validator.ValidateQuantity(quantity);
    }
}