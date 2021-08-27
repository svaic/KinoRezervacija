using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinoRezervacija
{

    public enum Genre
    {
        Action,
        Comedy,
        Drama,
        Documentary,
        Fantasy
    }

    public class Movie : IComparable<Movie>
    {
        public string Name { get; set; }
        public string Regisseur { get; set; }
        public int Price { get; set; }
        public string FullTitle
        {
            get { return Name + " | " + Genre; }
        }
        public Genre Genre { get; set; }
        public class Comparator
        {
            public static Comparison<Movie> CompareByPrice = (Movie m1, Movie m2) => m1.Price.CompareTo(m2.Price);

            public static Comparison<Movie> CompareByName = delegate (Movie object1, Movie object2)
            {
                return object1.Name.CompareTo(object2.Name);
            };

            public static Comparison<Movie> CompareByGenre = delegate (Movie object1, Movie object2)
            {
                return object1.Genre.CompareTo(object2.Genre);
            };

            public static Comparison<Movie> CompareByRegisseur = (Movie m1, Movie m2) => m1.Regisseur.CompareTo(m2.Regisseur);
        }

        public static Dictionary<string, Comparison<Movie>> SortType = new Dictionary<string, Comparison<Movie>>()
        {
            { "Title", Comparator.CompareByName },
            { "Genre", Comparator.CompareByGenre },
            { "Price", Comparator.CompareByPrice },
            { "Regisseur", Comparator.CompareByRegisseur }
        };

        public static Comparison<Movie> DefaultComparator = Comparator.CompareByName;
        public Movie(string name, string regisseur, int price, Genre genre)
        {
            Name = name;
            Regisseur = regisseur;
            Price = price;
            Genre = genre;
        }

        public override string ToString()
        {
            return Name + "\n" + Regisseur + "\n" + Price + "\n" + Genre;
        }

        public int CompareTo(Movie movie)
        {
            return DefaultComparator.Invoke(this, movie);
        }

    }

    class MovieComparator : IComparer<Movie>
    {
        Comparison<Movie> CompareBy = Movie.DefaultComparator;
        public MovieComparator(Comparison<Movie>CompareBy)
        {
            this.CompareBy = CompareBy;
        }
        public int Compare(Movie x, Movie y)
        {
            if (x == null && y == null) return 0;
            if (x == null) return 1;
            if (y == null) return -1;

            return CompareBy.Invoke(x, y);
        }
    }
}