using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildFarm
{
    public class Mouse : Mammal
    {
        public Mouse(string name, double weight, string livingRegion)
            : base(name, weight, livingRegion) { }

        public override void MakeSound()
        {
            Console.WriteLine("Squeak");
        }

        public override void EatFood(Food food)
        {
            if (food is Vegetable || food is Fruit)
            {
                Weight += food.Quantity * 0.10;
                FoodEaten += food.Quantity;
            }
            else
            {
                Console.WriteLine("Mouse does not eat " + food.GetType().Name + "!");
            }
        }
    }

}
