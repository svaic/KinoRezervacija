using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinoRezervacija
{
    [Serializable]
    abstract class Menu
    {
        public List<IExtra> Food { get; set; }
        public List<IExtra> Drink { get; set; }

        public int FoodCapacity;
        public int DrinkCapacity;

        public bool CanBeFull;

        protected decimal FoodDiscount = 1;
        protected decimal DrinkDiscount = 1;
        public int GetPrice()
        {
            return (int)(Food.Sum(x => x.Price * FoodDiscount) + Drink.Sum(x => x.Price * DrinkDiscount));
        }
        public string GetDescription()
        {
            return string.Join(", ", Food.Select(x => x.Description).ToArray()) + " discount: " + (100 - FoodDiscount * 100) +"%\n"
                + String.Join(", ", Drink.Select(x => x.Description).ToArray()) + " discount: " + (100 - DrinkDiscount * 100) +"%\n" 
                + "Price: " + GetPrice().ToString();
        }

        public int FoodSelectionLeft()
        {
            return FoodCapacity - Food.Count;
        }

        public int DrinkSelectionLeft()
        {
            return DrinkCapacity - Drink.Count;
        }
        
        public int AddFood(IExtra food)
        {
            if (FoodSelectionLeft() == 0) return -1;
            Food.Add(food);
            return FoodSelectionLeft();
        }

        public int AddDrink(IExtra food)
        {
            if (DrinkSelectionLeft() == 0) return -1;
            Drink.Add(food);
            return DrinkSelectionLeft();
        }

        public bool IsFull()
        {
            return FoodSelectionLeft() == 0 && DrinkSelectionLeft() == 0;
        }

        public override string ToString()
        {
            return this.GetType().Name;
        }
    }

    class DefaultMenu : Menu
    {
        public DefaultMenu()
        {
            this.Food = new List<IExtra>();
            this.Drink = new List<IExtra>();
            this.CanBeFull = true;
            this.FoodCapacity = 1;
            this.DrinkCapacity = 1;
            this.FoodDiscount = (decimal)0.90;
            this.DrinkDiscount = (decimal)0.90;
        }
    }

    class LoveMenu : Menu
    {
        public LoveMenu()
        {
            this.Food = new List<IExtra>();
            this.Drink = new List<IExtra>();
            this.CanBeFull = true;
            this.FoodCapacity = 1;
            this.DrinkCapacity = 2;
            this.FoodDiscount = (decimal)0.95;
            this.DrinkDiscount = (decimal)0.85;
        }
    }

    class NoMenu : Menu
    {
        public NoMenu()
        {
            this.Food = new List<IExtra>();
            this.Drink = new List<IExtra>();
            this.CanBeFull = false;
            this.FoodCapacity = 10;
            this.DrinkCapacity = 10;
            this.FoodDiscount = (decimal)1;
            this.DrinkDiscount = (decimal)1;
        }
    }

    class Bill
    {
        public List<MovieTicket> Tickets { get; set; }
        public List<Menu> Menus { get; set; }
        public string GetTickets => string.Join("\n", Tickets.Select(x => x.ToString()).ToArray());

        public string GetMenus => string.Join("\n", Menus.Select(x => x.GetDescription()).ToList());
        public int GetTotalPrice => Tickets.Select(x => x.Movie.Price).Sum() + Menus.Select(x => x.GetPrice()).Sum();
        public override string ToString()
        {
            return "Movie tickets:\n" + GetTickets + "\nFood and Drinks\n" + GetMenus + "\nTotal Price:" + GetTotalPrice + " ден";
        }

        public Bill()
        {
            Tickets = new List<MovieTicket>();
            Menus = new List<Menu>();
        }
    }

    class MovieTicket
    {
        public MovieTicket(Hall hall, int seat)
        {
            Hall = hall;
            Seat = seat;
            Movie = Hall.CurrentMoviePlaying;
        }

        public Movie Movie { get; set; }
        public Hall Hall { get; set; }
        public int Seat { get; set; }

        public override string ToString()
        {
            return Movie.FullTitle + " | " + Hall.HallName + " Seat:" + Seat + " Price:" + Movie.Price;
        }
    }

    interface IExtra
    {
        public string Name { get; set; }
        public int Price { get; set; }

        public string Description
        {
            get { return Name + " - " + Price; }
        }

    }

    class Food : IExtra
    {
        public Food(string name, int price)
        {
            Name = name;
            Price = price;
        }

        public string Name { get; set; }
        public int Price { get; set; }

        public override string ToString()
        {
            return Name + " - " + Price;
        }
    }

    class FoodAddition : IExtra
    {
        private string _name;
        private int _price;

        public IExtra FoodDrink { get; set; }

        public FoodAddition(string name, int price, IExtra food)
        {
            Name = name;
            Price = price;
            FoodDrink = food;
        }

        public string Name
        {
            get { return FoodDrink.Name + ", " + _name; }
            set { _name = value; }
        }

        public int Price
        {
            get { return _price + FoodDrink.Price; }
            set { _price = value; }
        }
    }

}
