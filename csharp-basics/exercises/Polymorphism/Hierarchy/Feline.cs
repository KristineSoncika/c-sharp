using System;

namespace Hierarchy
{
    public abstract class Feline : Mammal
    {
        public Feline(string type, string name, double weight, string region) : base(type, name, weight, region)
        {
        }
    }
}