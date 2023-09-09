using MovieSorterApp;

namespace TestProject2
{
    public class UnitTest1
    {
        [Fact]
        public void TestSortByYear()
        {
            // Arrange
            List<Movie> movies = new List<Movie>
            {
                new Movie("The Matrix", 1999, new List<string> { "Science Fiction" }),
                new Movie("Avatar", 2009, new List<string> { "Science Fiction", "Action" }),
                new Movie("A Beautiful Mind", 2001, new List<string> { "Drama", "Biography" }),
                new Movie("Inception", 2010, new List<string> { "Science Fiction", "Action" }),
                new Movie("The Godfather", 1972, new List<string> { "Crime", "Drama" }),
            };

            // Act
            List<Movie> sortedMovies = MovieSorter.SortByYear(movies);

            // Assert
            Assert.Equal(2010, sortedMovies[0].Year);
            Assert.Equal(1972, sortedMovies[sortedMovies.Count - 1].Year);
        }

        [Fact]
        public void TestSortByTitle()
        {
            // Arrange
            List<Movie> movies = new List<Movie>
            {
                new Movie("The Matrix", 1999, new List<string> { "Science Fiction" }),
                new Movie("Avatar", 2009, new List<string> { "Science Fiction", "Action" }),
                new Movie("A Beautiful Mind", 2001, new List<string> { "Drama", "Biography" }),
                new Movie("Inception", 2010, new List<string> { "Science Fiction", "Action" }),
                new Movie("The Godfather", 1972, new List<string> { "Crime", "Drama" }),
            };

            // Act
            List<Movie> sortedMovies = MovieSorter.SortByTitle(movies);

            // Assert
            Assert.Equal("Avatar", sortedMovies[0].Title);
            Assert.Equal("The Matrix", sortedMovies[sortedMovies.Count - 1].Title);
        }
    }
}