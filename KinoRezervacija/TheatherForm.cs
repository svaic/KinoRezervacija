using System;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using System.Xml.Serialization;

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
            RefreshListBox();
            RefreshDetails();
        }

        private void MovieLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshDetails();
            if (MovieLB.SelectedIndex != -1)
                btnRemove.Enabled = true;
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
            AddMovie form = new AddMovie(theater._halls);
            DialogResult result = form.ShowDialog();
            if(result == DialogResult.OK)
            {
                theater.Movies.Add(form.movie);
                theater.AddMovieToHall(form.movie);
                RefreshListBox();
            }
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

        private void btnRemove_Click(object sender, EventArgs e)
        {
            string text = "Are you sure you want to remove the movie in " + MovieLB.SelectedItem.ToString().Split()[0] + MovieLB.SelectedItem.ToString().Split()[1] + "?";
            DialogResult result = MessageBox.Show(text, "Remove Movie?", MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                theater.RemoveMovie(Convert.ToInt32(MovieLB.SelectedItem.ToString().Split()[1]));
            }
            RefreshListBox();
            RefreshDetails();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string fileName = null;
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                fileName = sfd.FileName;
                save(fileName);
            }
        }

        private void save(string path)
        {
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                IFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fs, theater);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                open(ofd.FileName);
            }
        }

        private void open(string path)
        {
            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                IFormatter formatter = new BinaryFormatter();
                theater = (Theater)formatter.Deserialize(fs);
            }
            RefreshListBox();
        }
    }
}
