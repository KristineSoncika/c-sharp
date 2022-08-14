using System;

namespace Exercise_4
{
    class Movie
    {
        private string _title;
        private string _studio;
        private string _rating;

        public Movie(string title, string studio, string rating)
        {
            _title = title;
            _studio = studio;
            _rating = rating;
        }

        public Movie(string title, string studio)
        {
            _title = title;
            _studio = studio;
            _rating = "PG";
        }

        public string GetTitle()
        {
            return _title;
        }

        public Movie[] GetPG(Movie[] movieArray)
        {
            Movie[] ratingPG = Array.FindAll(movieArray, movie => movie._rating == "PG");
            return ratingPG;
        }
    }
}