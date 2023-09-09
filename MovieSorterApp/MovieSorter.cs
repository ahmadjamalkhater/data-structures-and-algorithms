using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSorterApp
{
    public class MovieSorter
    {
        public static List<Movie> SortByYear(List<Movie> movies)
        {
            return movies.OrderByDescending(movie => movie.Year).ToList();
        }

        public static List<Movie> SortByTitle(List<Movie> movies)
        {
            return movies.OrderBy(movie => RemoveLeadingArticles(movie.Title)).ToList();
        }

        private static string RemoveLeadingArticles(string title)
        {
            string[] articles = { "A", "An", "The" };
            foreach (string article in articles)
            {
                if (title.StartsWith(article + " ", StringComparison.OrdinalIgnoreCase))
                {
                    return title.Substring(article.Length + 1).Trim();
                }
            }
            return title;
        }
    }
}