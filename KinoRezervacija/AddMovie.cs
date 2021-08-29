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
        public Movie movie { get; set; }
        public Hall SelectedHall { get; set; }
        public AddMovie(BindingList<Hall> halls)
        {
            InitializeComponent();
            listHalls.DataSource = halls.Where(x => x.CurrentMoviePlaying == null).ToArray();
            var GenreEnums = Enum.GetNames(typeof(Genre)).ToList();
            listGenre.DataSource = GenreEnums;
            listHalls.DisplayMember = "HallName";
        }

        private void btnAddMovie_Click(object sender, EventArgs e)
        {
            //Genre genre;
            //if (Convert.ToInt32(listGenre.SelectedIndex) == 0)
            //    genre = Genre.Action;
            //else if (Convert.ToInt32(listGenre.SelectedIndex) == 1)
            //    genre = Genre.Comedy;
            //else if (Convert.ToInt32(listGenre.SelectedIndex) == 2)
            //    genre = Genre.Drama;
            //else if (Convert.ToInt32(listGenre.SelectedIndex) == 3)
            //    genre = Genre.Documentary;
            //else
            //    genre = Genre.Fantasy;
            string filter = (string)listGenre.SelectedItem;
            Genre genre = (Genre)Enum.Parse(typeof(Genre), filter);
            movie = new Movie(tbName.Text, tbRegisseur.Text, Convert.ToInt32(numPrice.Value), genre, Convert.ToInt32(listHalls.SelectedValue.ToString().Split(" ")[1]));
            SelectedHall = (Hall)listHalls.SelectedItem;
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
