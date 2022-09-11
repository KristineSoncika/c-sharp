namespace Hierarchy;

public abstract class Feline : Mammal
{
    protected Feline(string type, string name, double weight, string region) : 
        base(type, name, weight, region) { }
}