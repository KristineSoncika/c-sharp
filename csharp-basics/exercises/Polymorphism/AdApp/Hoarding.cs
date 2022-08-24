namespace AdApp
{
    public class Hoarding : Advert
    {
        private double _rate;
        private int _numDays;
        private bool _isPrimeLocation;

        public Hoarding(int fee, int days, int rate, bool isPrime) : base(fee)
        {
            _rate = rate;
            _numDays = days;
            _isPrimeLocation = isPrime;
        }

        public new double Cost()
        {
            if (_isPrimeLocation)
            {
                _rate *= 1.5;
            }

            return base.Cost() + (_rate * _numDays);
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}