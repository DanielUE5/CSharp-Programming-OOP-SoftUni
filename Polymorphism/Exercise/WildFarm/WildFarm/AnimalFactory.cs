using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildFarm
{
    public static class AnimalFactory
    {
        public static Animal CreateAnimal(string type, string name, double weight, params string[] additionalParameters)
        {
            return type switch
            {
                "Owl" => new Owl(name, weight, double.Parse(additionalParameters[0])),
                "Hen" => new Hen(name, weight, double.Parse(additionalParameters[0])),
                "Mouse" => new Mouse(name, weight, additionalParameters[0]),
                "Dog" => new Dog(name, weight, additionalParameters[0]),
                "Cat" => new Cat(name, weight, additionalParameters[0], additionalParameters[1]),
                "Tiger" => new Tiger(name, weight, additionalParameters[0], additionalParameters[1]),
                _ => throw new InvalidOperationException("Invalid animal type!")
            };
        }
    }
}
