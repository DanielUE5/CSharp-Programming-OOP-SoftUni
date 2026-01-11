using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaCalories
{
    public class Pizza
    {
        private readonly List<Topping> _toppings;

        public Pizza(string name) 
        {
            if(string.IsNullOrEmpty(name) || name.Length > 15)
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
            Name = name;
            

            _toppings = new List<Topping>();
            Toppings = _toppings.AsReadOnly();
        }

        public string Name { get; }
        public Dough Dough { get; set; } = null!;
        public IReadOnlyCollection<Topping> Toppings { get; }

        public double Calories => Dough.Calories + Toppings.Sum(t => t.Calories);

        public void AddTopping(Topping topping)
        {
            if (topping is null) throw new ArgumentNullException(nameof(topping));
            _toppings.Add(topping);

            if (Toppings.Count == 10)
                throw new InvalidOperationException("Number of toppings should be in range [0..10].");
        }
    }
}
