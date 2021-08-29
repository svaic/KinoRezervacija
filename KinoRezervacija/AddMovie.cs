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
    
    public partial class AddMovie : Form
    {
        public Movie NewMovie { get; set; }
        public Hall SelectedHall { get; set; }
        public List<Movie> AlreadyCreatedMovies { get; set; }
        public AddMovie(BindingList<Hall> halls, List<Movie>movies)
        {
            InitializeComponent();
            listHalls.DataSource = halls.Where(x => x.CurrentMoviePlaying == null).ToArray();
            
            var GenreEnums = Enum.GetNames(typeof(Genre)).ToList();
            listGenre.DataSource = GenreEnums;
            listHalls.DisplayMember = "HallName";

            AlreadyCreatedMovies = movies;
            CreatedMoviesBeforeCB.DataSource = AlreadyCreatedMovies;
            CreatedMoviesBeforeCB.DisplayMember = "FullTitle";
            CreatedMoviesBeforeCB.SelectedIndex = -1;

            CreatedMoviesBeforeCB.Focus();
        }

        private void btnAddMovie_Click(object sender, EventArgs e)
        {
            SelectedHall = (Hall)listHalls.SelectedItem;

            if (CreatedMoviesBeforeCB.SelectedItem == null)
            {
                Genre selectedGenre = (Genre)Enum.Parse(typeof(Genre), (string)listGenre.SelectedItem);
                NewMovie = new Movie(tbName.Text, tbRegisseur.Text, Convert.ToInt32(numPrice.Value), selectedGenre);
                AlreadyCreatedMovies.Add(NewMovie);
            }
            else
            {
                NewMovie = (Movie)CreatedMoviesBeforeCB.SelectedItem;
            }
            
            SelectedHall.ChangeMoviePlaying(NewMovie);

            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void tbName_Validating(object sender, CancelEventArgs e)
        {
            if (tbName.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(tbName, "You must enter a movie title");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(tbName, null);
                e.Cancel = false;
            }
        }

        private void tbRegisseur_Validating(object sender, CancelEventArgs e)
        {
            if (tbRegisseur.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(tbRegisseur, "You must enter a regisseur");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(tbRegisseur, null);
                e.Cancel = false;
            }
        }

        private void numPrice_Validating(object sender, CancelEventArgs e)
        {
            if (Convert.ToInt32(numPrice.Value) == 0)
            {
                errorProvider1.SetError(numPrice, "Movie price is not valid");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(numPrice, null);
                e.Cancel = false;
            }
        }

        private void listGenre_Validating(object sender, CancelEventArgs e)
        {
            if(listGenre.SelectedIndex == -1)
            {
                errorProvider1.SetError(listGenre, "Select a genre");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(listGenre, null);
                e.Cancel = false;
            }
        }

        private void listHalls_Validating(object sender, CancelEventArgs e)
        {
            if (listHalls.SelectedIndex == -1)
            {
                errorProvider1.SetError(listHalls, "Select a hall");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(listHalls, null);
                e.Cancel = false;
            }
        }
    }
}
