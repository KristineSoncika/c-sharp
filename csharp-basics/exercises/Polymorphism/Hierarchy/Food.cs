using System;

namespace Hierarchy
{
    public abstract class Food
    {
        protected int _quantity;

        public Food(int quantity)
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
}