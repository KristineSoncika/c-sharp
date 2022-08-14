using System;

namespace VideoStore
{
    class Video
    {
        private string _title;
        private bool _isAvailable;
        private double _averageRating;
        private List<double> _ratings = new();

        public Video(string title)
        {
            _title = title;
            _isAvailable = true;
        }

        public void BeingCheckedOut()
        {
            _isAvailable = false;
        }

        public void BeingReturned()
        {
            _isAvailable = true;
        }

        public void ReceivingRating(double rating)
        {
            _ratings.Add(rating);
        }

        public double AverageRating()
        {
            return _ratings.Sum() / _ratings.Count;
        }

        public bool Available()
        {
            return _isAvailable;
        }

        public string Title => _title;

        public override string ToString()
        {
            return $"{Title} | {AverageRating():F1} | Is available: {Available()}";
        }
    }
}