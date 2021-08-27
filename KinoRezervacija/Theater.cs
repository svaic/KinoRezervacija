using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinoRezervacija
{
    enum HallType
    {
        Large,
        Medium,
        Small
    }

    class Theater
    {
        public BindingList<Hall> Halls { get; set; }
        public BindingList<Hall> _halls { get; set; }
        public string Name { get; set; }
        public List<Movie> Movies { get; set; }

        

        //static List<Movie> movies = new List<Movie>
        //{
        //    new Movie("Marvel Avengers", "Marvel", 350, Genre.Action),
        //    new Movie("Thor the Dark World", "Marvel", 350, Genre.Action),
        //    new Movie("Thor Love and Thunder", "Marvel", 200, Genre.Action),
        //    new Movie("Captain Amerika The Winter Soldier", "Marvel", 200, Genre.Action),
        //    new Movie("Harry Potter and the Deadly Hollows Part 1", "Marvel", 200, Genre.Fantasy),
        //    new Movie("Harry Potter and the Deadly Hollows Part 2", "Marvel", 350, Genre.Fantasy),
        //    new Movie("The Hangover", "Todd Phillips", 150, Genre.Comedy)
        //};

        public static Comparison<Movie> DefaultComparator = Movie.Comparator.CompareByName;

        public Theater(string Name)
        {
            this.Name = Name;
            this.Movies = new List<Movie>();
            BuildHalls(10);
        }

        public void BuildHalls(int hallNumber)
        {
            _halls = new BindingList<Hall>();
            //List<Movie> BestMovies = movies.Take(hallNumber).ToList();
            
            HallType hallType = HallType.Large;

            //BestMovies.Sort(DefaultComparator);

            for (int i = 0; i < hallNumber; i++)
            {
                if (i < 3)
                    hallType = HallType.Small;
                else if (i < 6)
                    hallType = HallType.Medium;
                BuildHall(i+1, hallType);
                //if (BestMovies.Count > i) BuildHall(i + 1, BestMovies[i], hallType);
                //else BuildHall(i, null, hallType);
            }

        }

        private void BuildHall(int number, HallType hallType)
        {
            if (hallType == HallType.Small) _halls.Add(new Hall(number, null, 20));
            if (hallType == HallType.Medium) _halls.Add(new Hall(number, null, 35));
            if (hallType == HallType.Large) _halls.Add(new Hall(number, null, 50));
            Halls = _halls;
        }

        public void AddMovieToHall(Movie movie)
        {
            for (int i = 0; i < 10; i++)
            {
                if (i + 1 == movie.HallNumber)
                {
                    _halls.ElementAt(i).CurrentMoviePlaying = movie;
                    break;
                }
            }
        }

        //private void BuildHall(int number, Movie moviePlaying, HallType hallType)
        //{
        //    if (hallType == HallType.Small) _halls.Add(new Hall(number, moviePlaying, 20));
        //    if (hallType == HallType.Medium) _halls.Add(new Hall(number, moviePlaying, 35));
        //    if (hallType == HallType.Large) _halls.Add(new Hall(number, moviePlaying, 50));
        //    Halls = _halls;
        //}
        public void CompareBy(string Type, bool Ascending)
        {
            //Halls = new BindingList<Hall> (Halls.OrderBy(x=>x.CurrentMoviePlaying == null).ThenBy(x => x.CurrentMoviePlaying).ToList());
            if (Ascending)
                Halls = new BindingList<Hall>(Halls.OrderBy(x => x.CurrentMoviePlaying == null).ThenBy(x => x.CurrentMoviePlaying, new MovieComparator(Movie.SortType.GetValueOrDefault(Type, Movie.DefaultComparator))).ToList());
            else
                Halls = new BindingList<Hall>(Halls.OrderBy(x => x.CurrentMoviePlaying == null).ThenByDescending(x => x.CurrentMoviePlaying, new MovieComparator(Movie.SortType.GetValueOrDefault(Type, Movie.DefaultComparator))).ToList());
        }

        public void FilterBy(Genre Type)
        {
            Halls = new BindingList<Hall>(_halls.Where(x => x.CurrentMoviePlaying != null &&  x.CurrentMoviePlaying.Genre == Type).ToList());
        }

        public void ClearFilter()
        {
            Halls = new BindingList<Hall>(_halls);
        }
    }
}
