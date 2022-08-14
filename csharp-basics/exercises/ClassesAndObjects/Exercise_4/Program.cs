using System;

namespace Exercise_4
{
    class Program
    {
        private static void Main()
        {
            Movie movie1 = new("Casino Royale", "Eon Productions", "PG13");
            Movie movie2 = new("Glass", "Buena Vista International", "PG­13");
            Movie movie3 = new("Spider-Man: Into the Spider-Verse", "Columbia Pictures", "PG");

            Movie[] movies = { movie1, movie2, movie3 };
            Movie[] PGMovies = movie1.GetPG(movies);

            foreach (Movie movie in PGMovies)
            {
                Console.WriteLine(movie.GetTitle());
            }
        }
    }
}