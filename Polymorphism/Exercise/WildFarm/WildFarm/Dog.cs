using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildFarm
{
    public class Dog : Mammal
    {
        public Dog(string name, double weight, string livingRegion)
            : base(name, weight, livingRegion) { }

        public override void MakeSound()
        {
            Console.WriteLine("Woof!");
        }

        public override void EatFood(Food food)
        {
            if (food is Meat)
            {
                Weight += food.Quantity * 0.40;
                FoodEaten += food.Quantity;
            }
            else
            {
                Console.WriteLine("Dog does not eat " + food.GetType().Name + "!");
            }
        }
    }
}
