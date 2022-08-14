using System;

namespace FuelConsumptionCalculator
{
    class Car
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
            return (ConsumptionPer100Km() > 15);
        }

        public bool IsEconomyCar()
        {
            return (ConsumptionPer100Km() < 5) ;
        }

        public void FillUp(double km, double liters)
        {
            _currentReading = km;
            _litersFilled += liters;
        }
    }
}