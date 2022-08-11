using System;

namespace Exercise_3
{
    public class FuelGauge
    {
        private int _fuel;
        public const int TankSize = 70;

        public FuelGauge(int liters)
        {
            _fuel = liters;
        }

        public int ShowLitersLeft()
        {
            return _fuel;
        }

        public void IncrementFuel()
        {
            if (ShowLitersLeft() < TankSize)
            {
                _fuel++;
            }
        }

        public void DecrementFuel()
        {
            if (ShowLitersLeft() > 0)
            {
                _fuel--;
            }
        }
    }
}