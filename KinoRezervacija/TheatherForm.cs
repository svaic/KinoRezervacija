using System;
using System.Linq;
using System.Windows.Forms;

namespace KinoRezervacija
{
    public partial class TheatherForm : Form
    {
        Theater theater = new Theater("Cineplexx");
        Bill bill;
        public TheatherForm()
        {
            InitializeComponent();

            CinemaNameLB.Text = theater.Name;

            MovieLB.DataSource = theater.Halls;
            SortCB.DataSource = Movie.SortType.Keys.ToList();

            var GenreEnums = Enum.GetNames(typeof(Genre)).ToList();
            GenreEnums.Insert(0, "None");
            FilterCB.DataSource = GenreEnums;

            bill = new Bill();

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
            if (!selectedHall.HasMoviePlaying()) return;
            
            //selectedHall.BookSeat();
            //RefreshDetails();
            
            HallForm hallForm = new HallForm(selectedHall);
            hallForm.FormClosed += HallForm_Closed;
            hallForm.Show();
        }

        private void HallForm_Closed(object sender, FormClosedEventArgs e)
        {
            HallForm hallForm = (HallForm)sender;
            bill.Tickets.AddRange(hallForm.SeatsBought);
            RefreshListBox();
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
            string type = (string)SortCB.SelectedItem;
            //int selectedIndex = MovieLB.SelectedIndex;

            theater.CompareBy(type,AscendCheckB.Checked);
            //theater.Halls.ResetBindings();
            MovieLB.DataSource = theater.Halls;

            //MovieLB.SelectedIndex = selectedIndex;
        }

        private void AscendCheckB_CheckStateChanged(object sender, EventArgs e)
        {
            RefreshListBox();
        }

        private void FilterChanged(object sender, EventArgs e)
        {
            string filter = (string)FilterCB.SelectedItem;
            if (filter == "None")
            {
                theater.ClearFilter();
                RefreshListBox();
                return;
            }

            theater.FilterBy((Genre)Enum.Parse(typeof(Genre), filter));
            RefreshListBox();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuForm menuForm = new MenuForm();
            menuForm.FormClosed += MenuForm_FormClosed;
            menuForm.Show();
        }

        private void MenuForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MenuForm MenuForm = (MenuForm)sender;
            bill.Menus = MenuForm.Menus;
        }

        private void ShowBillBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(bill.ToString());
        }
    }
}
