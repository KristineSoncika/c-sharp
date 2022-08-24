using System;

namespace AdApp
{
    public class TVAd : Advert
    {
        private int _seconds;
        private int _rate;
        private bool _isPeak;

        public TVAd(int fee, int rate, int seconds, bool isPeak) : base(fee)
        {
            _seconds = seconds;
            _rate = rate;
            _isPeak = isPeak;
        }

        public new double Cost()
        {
            if(_isPeak)
            {
                _rate *= 2;
            }

            return base.Cost() + (_rate * _seconds);
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}