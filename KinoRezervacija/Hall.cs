using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinoRezervacija
{
    public class Hall : IComparable<Hall>
    {
        public Movie CurrentMoviePlaying { get; set; }
        public int Size { get; set; }
        public bool [] BookedSeats { get;set; }
        public int HallNumber { get; set; }
        public string HallName
        {
            get { return "Hall " + HallNumber; }
        }
        
        public Hall(int HallName,Movie currentMoviePlaying , int Size)
        {
            this.HallNumber = HallName;
            this.CurrentMoviePlaying = currentMoviePlaying;
            this.BookedSeats = new bool[Size];
            this.Size = Size;
        }

        public bool BookSeat()
        {
            if (CurrentMoviePlaying == null) return false;

            for(int i=0; i < BookedSeats.Length;i++)
            {
                if(!BookedSeats[i])
                {
                    BookedSeats[i] = true;
                    return true;
                }
            }
            return false;
        }

        public void ChangeMoviePlaying(Movie movie)
        {
            CurrentMoviePlaying = movie;
        }

        public bool HasMoviePlaying()
        {
            return CurrentMoviePlaying != null;
        }

        public override string ToString()
        {
            if (!HasMoviePlaying())
                return HallName + " | No movie playing in this hall right now";

            return HallName + " | " + CurrentMoviePlaying.FullTitle + " " + (GetRemainingSeats() == 0? " | Sold Out" : "");
        }

        public int GetRemainingSeats()
        {
            return BookedSeats.Where(x => x == false).Count();
        }

        public String getFullDetails()
        {
            if (CurrentMoviePlaying == null) return HallName + "\nCurrently there is no movie playing in this hall";
            return HallName + "\n" + CurrentMoviePlaying.ToString() + "\n" + "Remaining Seats:" + GetRemainingSeats();
        }

        public int CompareTo(Hall other)
        {
            return this.CurrentMoviePlaying.CompareTo(other.CurrentMoviePlaying);
        }
    }
}
