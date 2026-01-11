using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WildFarm
{
    public class Owl : Bird
    {
        public Owl(string name, double weight, double wingSize)
            : base(name, weight, wingSize) { }

        public override void MakeSound()
        {
            Console.WriteLine("Hoot Hoot");
        }

        public override void EatFood(Food food)
        {
            if (food is Meat)
            {
                Weight += food.Quantity * 0.25;
                FoodEaten += food.Quantity;
            }
            else
            {
                Console.WriteLine("Owl does not eat " + food.GetType().Name + "!");
            }
        }

        public override string ToString()
        {
            return $"{GetType().Name} [{Name}, {WingSize}, {Weight:F2}, {FoodEaten}]";
        }
    }
}
