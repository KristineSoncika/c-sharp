using System;

namespace FuelConsumptionCalculator
{
    public class Car
    {
        private double _firstReading;
        private double _currentReading;
        private double _litersFilled;

        public Car(double firstReading)
        {
            _firstReading = firstReading;
        }

        public double ConsumptionPerKm()
        {
            return _litersFilled / (_currentReading - _firstReading);
        }

        public double ConsumptionPer100Km()
        {
            return ConsumptionPerKm() * 100;
        }

        public bool IsGasHog()
        {
            if (ConsumptionPer100Km() > 15)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsEconomyCar()
        {
            if (ConsumptionPer100Km() < 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void FillUp(double km, double liters)
        {
            _currentReading = km;
            _litersFilled += liters;
        }
    }
}