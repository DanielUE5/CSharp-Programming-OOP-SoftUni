using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildFarm
{
    public abstract class Animal
    {
        public string Name { get; }
        public double Weight { get; protected set; }
        public int FoodEaten { get; protected set; }

        protected Animal(string name, double weight)
        {
            Name = name;
            Weight = weight;
            FoodEaten = 0;
        }

        public abstract void MakeSound();
        public abstract void EatFood(Food food);

        public override string ToString()
        {
            return $"{GetType().Name} [{Name}, {Weight}, {FoodEaten}]";
        }
    }
}
