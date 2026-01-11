using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    public abstract class BaseCar : ICar
    {
        protected BaseCar(string model, string color)
        {
            Model = model;
            Color = color;
        }
        public string Model { get; } 

        public string Color { get; }

        public string Start()
        {
            return "Engine start";
        }

        public string Stop()
        {
            return "Breaaak";
        }

        protected virtual string Describe() => $"{Color} {GetType().Name} {Model}";

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(Describe());
            sb.AppendLine(Start());
            sb.Append(Stop());

            return sb.ToString();
        }
    }
}
