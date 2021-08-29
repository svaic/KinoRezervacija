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
    partial class CreateHallForm : Form
    {
        public Theater Theater { get; set; }
        public CreateHallForm(Theater theater)
        {
            InitializeComponent();

            var TypeEnums = Enum.GetNames(typeof(HallType)).ToList();
            HallTypeCB.DataSource = TypeEnums;

            Theater = theater;
        }

        private void CreateHallBtn_Click(object sender, EventArgs e)
        {
            HallType selectedType = (HallType)Enum.Parse(typeof(HallType), (string)HallTypeCB.SelectedItem);
            Theater.BuildHall(selectedType);

            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
