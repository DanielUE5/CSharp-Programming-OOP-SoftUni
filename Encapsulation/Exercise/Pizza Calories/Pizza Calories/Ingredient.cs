using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaCalories
{
    public class Ingredient
    {
        public Ingredient(double weightInGrams)
        {
            WeightInGrams = weightInGrams;
        }

        public double WeightInGrams { get; }

        public virtual double Calories => 2 * WeightInGrams;
    }
}
