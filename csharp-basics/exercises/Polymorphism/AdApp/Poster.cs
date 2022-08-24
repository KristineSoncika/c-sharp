using System;

namespace AdApp
{
    public class Poster : Advert
    {
        private int _copies;
        private double _rate;
        private bool _isExtraLarge;

        public Poster(int fee, int rate, int copies, bool isExtralarge) : base(fee)
        {
            _copies = copies;
            _rate = rate;
            _isExtraLarge = isExtralarge;
        }

        public new double Cost()
        {
            if (_isExtraLarge)
            {
                _rate *= 1.6;
            }

            return base.Cost() + (_rate * _copies);
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}