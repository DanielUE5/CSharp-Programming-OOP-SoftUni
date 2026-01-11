using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    public class Tesla : BaseCar, ICar, IElectricCar
    {
        public int Battery { get; }
        
        public Tesla (string model, string color, int battery)
            : base (model, color)
        {
            Battery = battery;
        }

        protected override string Describe() => $"{base.Describe()} with {Battery} Batteries";
    }
}


