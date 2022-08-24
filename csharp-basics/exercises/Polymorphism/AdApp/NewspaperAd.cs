namespace AdApp
{
    public class NewspaperAd : Advert
    {
        private int _column;
        private int _rate;

        public NewspaperAd(int fee, int col, int rate) : base(fee)
        {
            _column = col;
            _rate = rate;
        }

        private new double Cost()
        {
            return base.Cost() + (_column * _rate);
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}