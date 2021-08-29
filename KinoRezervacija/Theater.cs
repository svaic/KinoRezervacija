using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinoRezervacija
{
    [Serializable]
    enum HallType
    {
        Large,
        Medium,
        Small
    }
    [Serializable]
    class Theater
    {
        public BindingList<Hall> Halls { get; set; }
        public BindingList<Hall> _halls { get; set; }
        public string Name { get; set; }
        public List<Movie> Movies { get; set; }

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
            
            for (int i = 0; i < hallNumber; i++)
            {
                HallType hallType;
                if (i < 3)
                    hallType = HallType.Small;
                else if (i < 6)
                    hallType = HallType.Medium;
                else hallType = HallType.Large;

                BuildHall(hallType);
            }

        }

        public void BuildHall(HallType hallType)
        {
            if (hallType == HallType.Small) _halls.Add(new Hall(_halls.Count +1, null, 20));
            if (hallType == HallType.Medium) _halls.Add(new Hall(_halls.Count +1, null, 30));
            if (hallType == HallType.Large) _halls.Add(new Hall(_halls.Count +1, null, 50));
            Halls = _halls;
        }

        public void AddMovieToHall(Movie movie,int HallNumber)
        {
            _halls[HallNumber-1].CurrentMoviePlaying = movie;
        }

        public void RemoveMovie(int hallNumber)
        {
            _halls.ElementAt(hallNumber - 1).CurrentMoviePlaying = null;
        }
        public void CompareBy(string Type, bool Ascending)
        {
            if (Ascending)
                Halls = new BindingList<Hall>(Halls
                    .OrderBy(x => x.CurrentMoviePlaying == null)
                    .ThenBy(x => x.CurrentMoviePlaying, new MovieComparator(Movie.SortType.GetValueOrDefault(Type, Movie.DefaultComparator)))
                    .ThenBy(x => x.HallNumber).ToList());
            else
                Halls = new BindingList<Hall>(Halls.OrderBy(x => x.CurrentMoviePlaying == null).ThenByDescending(x => x.CurrentMoviePlaying, new MovieComparator(Movie.SortType.GetValueOrDefault(Type, Movie.DefaultComparator))).ThenBy(x => x.HallNumber).ToList());
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
