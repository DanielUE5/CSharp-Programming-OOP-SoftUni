using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildFarm
{
    public class Tiger : Feline
    {
        public Tiger(string name, double weight, string livingRegion, string breed)
            : base(name, weight, livingRegion, breed) { }

        public override void MakeSound()
        {
            Console.WriteLine("ROAR!!!");
        }

        public override void EatFood(Food food)
        {
            if (food is Meat)
            {
                Weight += food.Quantity * 1.00;
                FoodEaten += food.Quantity;
            }
            else
            {
                Console.WriteLine("Tiger does not eat " + food.GetType().Name + "!");
            }
        }
    }
}
