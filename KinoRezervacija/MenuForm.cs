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
   
    partial class MenuForm : Form
    {
        static IExtra[] Foods = new Food[] { new Food("Popcorn", 200), new Food("HotDog", 150), new Food("Nacho", 200) };
        static IExtra[] FoodAddition = new Food[] { new Food("Ketchup", 30), new Food("Mayo", 150), new Food("Sauce", 200) };
        static IExtra[] Drinks = new Food[] { new Food("CocaCola", 50), new Food("Sprite", 40), new Food("Schweppes", 50) };
        static IExtra[] DrinkAddition = new Food[] { new Food("Ice", 10), new Food("Extra Cold", 15) };

        
        Menu CurrentMenu;
        public List<Menu> Menus { get; set; }

        public MenuForm()
        {
            InitializeComponent();

            this.Menus = new List<Menu>();

            MenuCB.DataSource = new Menu[] { new DefaultMenu(), new LoveMenu() , new NoMenu() };
            FoodCB.DataSource = Foods;
            DrinkCB.DataSource = Drinks;

            FillCheckBoxes(FoodAddition, FoodAdditionPanel);
            FillCheckBoxes(DrinkAddition, DrinkAdditionPanel); 
        }

        private void FillCheckBoxes(IExtra[] Addition,Panel Panel)
        {
            for (int i = 0; i < Addition.Length; i++)
            {
                var DrinkCB = new CheckBox
                {
                    Text = Addition[i].ToString(),
                    Tag = Addition[i]
                };
                Panel.Controls.Add(DrinkCB);
            }
        }

        private void MenuCBSelectedItemChanged(object sender, EventArgs e)
        {
            Type objectType = MenuCB.SelectedItem.GetType();
            CurrentMenu = (Menu)Activator.CreateInstance(objectType);

            SelectedMenuTB.Text += CurrentMenu.GetType().Name + "\n";

            RefreshLabels();
        }

        private void RefreshLabels()
        {
            FoodLB.Text = "Food: " + CurrentMenu.FoodSelectionLeft().ToString();
            DrinkLB.Text = "Drink: " + CurrentMenu.DrinkSelectionLeft().ToString();

            SelectedMenuTB.Text = CurrentMenu.GetDescription();

            if (!CurrentMenu.CanBeFull || CurrentMenu.IsFull())
            {
                MoveToBillBtn.Enabled = true;
            }
            else MoveToBillBtn.Enabled = false;
        }

        private void MoveMenuToBill()
        {
            if (CurrentMenu.CanBeFull && !CurrentMenu.IsFull()) return;
            if (MessageBox.Show(CurrentMenu.GetDescription(), "add current menu to bill?", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Menus.Add(CurrentMenu);
                BillTB.Text = String.Join("\n", Menus.Select(x => x.GetDescription()).ToList()) + "\nTotal price: " + Menus.Select(x => x.GetPrice()).Aggregate((x, y) => x + y);
            }
            CreateNewMenu();
            RefreshLabels();
        }

        private void CreateNewMenu()
        {
            Type objectType = MenuCB.SelectedItem.GetType();
            CurrentMenu = (Menu)Activator.CreateInstance(objectType);
            RefreshLabels();
        }

        private void AddFoodBtn_Click(object sender, EventArgs e)
        {
            IExtra food = AddFoodDrink(FoodAdditionPanel, FoodCB);
            if (CurrentMenu.AddFood(food) == -1) return;
            RefreshLabels();
        }
        private void AddDrinkBtn_Click(object sender, EventArgs e)
        {
            IExtra drink = AddFoodDrink(DrinkAdditionPanel, DrinkCB);
            if (CurrentMenu.AddDrink(drink) == -1) return;
            RefreshLabels();
        }

        private IExtra AddFoodDrink(Control Panel,ComboBox ComboB)
        {
            IExtra SelectedFood = (IExtra)ComboB.SelectedItem;
            IExtra Food = SelectedFood;

            foreach (CheckBox CB in Panel.Controls.OfType<CheckBox>().Where(x => x.Checked == true).ToList())
            {
                IExtra addittion = (IExtra)CB.Tag;
                Food = new FoodAddition(addittion.Name, addittion.Price, Food);
            }

            return Food;
        }

        private void FoodChanged(object sender, EventArgs e)
        {
            foreach (CheckBox control in FoodAdditionPanel.Controls)
            {
                control.Checked = false;
            }
        }

        private void DrinkChanged(object sender, EventArgs e)
        {
            foreach (CheckBox control in DrinkAdditionPanel.Controls)
            {
                control.Checked = false;
            }
        }

        private void MoveToBillBtn_Click(object sender, EventArgs e)
        {
            MoveMenuToBill();
        }

        private void ClearMenuBtn_Click(object sender, EventArgs e)
        {
            CreateNewMenu();
        }
    }
}
