using System;

namespace Exercise_3
{
    class Odometer
    {
        private int _km;
        private FuelGauge _fuelGauge;

        public Odometer(int km, FuelGauge fuelGauge)
        {
            _km = km;
            _fuelGauge = fuelGauge;
        }

        public int ReportKm()
        {
            return _km;
        }

        public void IncrementKm()
        {
            if (ReportKm() == 999999)
            {
                _km = 0;
            }
            else
            {
                _km++;
            }

            if (ReportKm() % 10 == 0)
            {
                _fuelGauge.DecrementFuel();
            }
        }
    }
}