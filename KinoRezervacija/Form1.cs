using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KinoRezervacija
{
    public partial class Form1 : Form
    {
        Theater theater = new Theater("Cineplexx");
        public Form1()
        {
            InitializeComponent();

            MovieLB.DataSource = theater.Halls;
            SortCB.DataSource = Enum.GetValues(typeof(SortType));
            RefreshDetails();

        }

        private void MovieLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshDetails();

        }

        private void RefreshDetails()
        {
            Hall selectedHall = (Hall)MovieLB.SelectedItem;
            //if (selectedHall == null) return;

            MovieDetailsRTX.Text = selectedHall.getFullDetails();

            if (selectedHall.GetRemainingSeats() == 0)
            {
                theater.Halls.ResetBindings();
            }
        }

        private void BuyTicketBtn_Click(object sender, EventArgs e)
        {
            Hall selectedHall = (Hall)MovieLB.SelectedItem;
            selectedHall.BookSeat();
            RefreshDetails();
        }

        private void addMovieBtn_Click(object sender, EventArgs e)
        {
           
        }

        private void SortCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshListBox();
        }

        private void RefreshListBox()
        {
            SortType type = (SortType)SortCB.SelectedItem;
            theater.SetDefaultCompareBy(type);
            //theater.Halls.ResetBindings();
            MovieLB.DataSource = theater.Halls;
        }

        private void AscendCheckB_CheckStateChanged(object sender, EventArgs e)
        {
            Movie.Asc = !Movie.Asc;
            RefreshListBox();
        }
    }
}
