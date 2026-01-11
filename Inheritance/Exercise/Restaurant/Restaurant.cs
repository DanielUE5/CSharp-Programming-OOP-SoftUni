using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class Product
    {
        public Product(string name, decimal price)
        {
            this.Name = name;
            this.Price = price;
        }

        public string Name { get; private set; }
        public decimal Price { get; private set; }
    }

    public class Beverage : Product
    {
        public Beverage(string name, decimal price, double milliliters) : base(name, price)
        {
            this.Name = name;
            this.Price = price;
            this.Milliliters = milliliters;
        }
        public new string Name { get; private set; }
        public new decimal Price { get; private set; }

        public double Milliliters { get; private set; }
    }

    public class HotBeverage : Beverage
    {
        public HotBeverage(string name, decimal price, double milliliters) : base(name, price, milliliters)
        {
        }
    }

    public class Coffee : HotBeverage
    {
        private const double CoffeeMilliliters = 50;
        private const decimal CoffeePrice = 3.50m;

        public Coffee(string name, double caffeine) : base(name, CoffeePrice, CoffeeMilliliters)
        {
            this.Caffeine = caffeine;
        }

        public double Caffeine { get; private set; }
    }

    public class Tea : HotBeverage
    {
        public Tea(string name, decimal price, double milliliters) : base(name, price, milliliters)
        {
        }
    }

    public class ColdBeverage : Beverage
    {
        public ColdBeverage(string name, decimal price, double milliliters) : base(name, price, milliliters)
        {
        }
    }

    public class Food : Product
    {
        public Food(string name, decimal price, double grams) : base(name, price)
        {
            this.Name = name;
            this.Price = price;
            this.Grams = grams;
        }

        public new string Name { get; private set; }
        public new decimal Price { get; private set; }
        public double Grams { get; private set; }
    }

    public class MainDish : Food
    {
        public MainDish(string name, decimal price, double grams) : base(name, price, grams) 
        { 
        }
    }
    public class Dessert : Food
    {
        public Dessert(string name, decimal price, double grams, double calories) : base(name, price, grams)
        { 
        }
        public double Calories { get; private set; }
    }

    public class Starter : Food
    {
        public Starter(string name, decimal price, double grams) : base(name, price, grams)
        {
        }
    }

    public class Fish : MainDish 
    {
        private const double FishGrams = 22;
        public Fish(string name, decimal price) : base(name, price, FishGrams)
        {
        }
    }

    public class Soup : Starter
    {
        public Soup(string name, decimal price, double grams) : base(name, price, grams)
        {
        }
    }

    public class Cake : Dessert
    {
        private const double CakeGrams = 250;
        private const double CakeCalories = 1000;
        private const decimal CakePrice = 5;
        public Cake(string name) : base(name, CakePrice, CakeGrams, CakeCalories)
        {
        }
    }
}

