using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSorterApp
{
    public class Movie
    {
        public string Title { get; set; }
        public int Year { get; set; }
        public List<string> Genres { get; set; }

        public Movie(string title, int year, List<string> genres)
        {
            Title = title;
            Year = year;
            Genres = genres;
        }
    }
}