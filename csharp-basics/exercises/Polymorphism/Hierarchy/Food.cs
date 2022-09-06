namespace Hierarchy;

public abstract class Food
{
    private readonly int _quantity;

    protected Food(int quantity)
    {
        _quantity = quantity;
    }

    public int GetQuantity()
    {
        return _quantity;
    }

    public override string ToString()
    {
        return GetType().Name;
    }
}