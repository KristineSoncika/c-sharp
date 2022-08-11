using System;

namespace Exercise_4
{
    public class Movie
    {
        public string Title;
        public string Studio;
        public string Rating;

        public Movie(string title, string studio, string rating)
        {
            Title = title;
            Studio = studio;
            Rating = rating;
        }

        public Movie(string title, string studio)
        {
            Title = title;
            Studio = studio;
            Rating = "PG";
        }

        public Movie[] GetPG(Movie[] movieArray)
        {
            Movie[] ratingPG = Array.FindAll(movieArray, movie => movie.Rating == "PG");
            return ratingPG;
        }
    }
}