namespace MovieSorterApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Movie> movies = new List<Movie>
        {
            new Movie("The Matrix", 1999, new List<string> { "Science Fiction" }),
            new Movie("Avatar", 2009, new List<string> { "Science Fiction", "Action" }),
            new Movie("A Beautiful Mind", 2001, new List<string> { "Drama", "Biography" }),
            new Movie("Inception", 2010, new List<string> { "Science Fiction", "Action" }),
            new Movie("The Godfather", 1972, new List<string> { "Crime", "Drama" }),
        };

            Console.WriteLine("Movies sorted by year:");
            List<Movie> moviesByYear = MovieSorter.SortByYear(movies);
            PrintMovies(moviesByYear);

            Console.WriteLine("\nMovies sorted by title (ignoring leading articles):");
            List<Movie> moviesByTitle = MovieSorter.SortByTitle(movies);
            PrintMovies(moviesByTitle);
        }

        static void PrintMovies(List<Movie> movies)
        {
            foreach (var movie in movies)
            {
                Console.WriteLine($"{movie.Title} ({movie.Year}) - Genres: {string.Join(", ", movie.Genres)}");
            }
        }
    }
}