using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildFarm
{
    public class Hen : Bird
    {
        public Hen(string name, double weight, double wingSize)
            : base(name, weight, wingSize) { }

        public override void MakeSound()
        {
            Console.WriteLine("Cluck");
        }

        public override void EatFood(Food food)
        {
            Weight += food.Quantity * 0.35;
            FoodEaten += food.Quantity;
        }
    }
}
