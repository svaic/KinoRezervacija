using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinoRezervacija
{

    enum Genre
    {
        Action,
        Comedy,
        Drama,
        Documentary,
        Fantasy
    }
    class Movie : IComparable<Movie>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public int Price { get; set; }
        public string FullTitle
        {
            get { return Name + " | " + Genre; }
        }
        public Genre Genre { get; set; }
        public static SortType SortBy { get; set; }
        public static bool Asc { get; set; }
        public Movie(string name, string author, int price, Genre genre)
        {
            Name = name;
            Author = author;
            Price = price;
            Genre = genre;
            SortBy = SortType.Title;
            Asc = true;
        }

        public override string ToString()
        {
            return Name + "\n" + Author + "\n" + Price + "\n" + Genre;
        }

        public static Comparison<Movie> CompareByPrice = (Movie m1,Movie m2) => m1.Price.CompareTo(m2.Price);

        public static Comparison<Movie> CompareByName = delegate (Movie object1, Movie object2)
        {
            return object1.Name.CompareTo(object2.Name);
        };

        public static Comparison<Movie> CompareByGenre = delegate (Movie object1, Movie object2)
        {
            return object1.Genre.CompareTo(object2.Genre);
        };

        public int CompareTo(Movie obj)
        {
            var first = this;
            var second = obj;
            if (!Asc)
            {
                first = obj;
                second = this;
            }
            if (SortBy == SortType.Price) return CompareByPrice.Invoke(first, second);
            if (SortBy == SortType.Genre) return CompareByGenre.Invoke(first, second);
            if (SortBy == SortType.Title) return CompareByName.Invoke(first, second);
            else return CompareByName.Invoke(first, second);
        }
    }
}