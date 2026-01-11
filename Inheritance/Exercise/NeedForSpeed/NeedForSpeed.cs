using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeedForSpeed
{
    public class Vehicle
    {
        private const double DefaultFuelConsumption = 1.25;
        public Vehicle(int horsePower, double fuel)
        {
            this.Fuel = fuel;
            this.HorsePower = horsePower;
            this.FuelConsumption = DefaultFuelConsumption;
        }

        public int HorsePower { get; set; }
        public double Fuel { get; set; }
        public virtual double FuelConsumption { get; set; }

        public virtual void Drive(double kilometers)
        {
            double fuelNeeded = kilometers * this.FuelConsumption;
            if (fuelNeeded <= this.Fuel)
            {
                this.Fuel -= fuelNeeded;
            }
            else
            {
                Console.WriteLine("Not enough fuel to drive the specified distance.");
            }
        }
    }

    public class Motorcycle : Vehicle
    {
        public Motorcycle(int horsePower, double fuel) : base(horsePower, fuel)
        {
        }
    }

    public class RaceMotorcycle : Motorcycle
    {
        private const double RaceMotorcycleFuelConsumption = 8;
        public RaceMotorcycle(int horsePower, double fuel) : base(horsePower, fuel)
        {
            this.FuelConsumption = RaceMotorcycleFuelConsumption;
        }
    }

    public class CrossMotorcycle : Motorcycle
    {
        public CrossMotorcycle(int horsePower, double fuel) : base(horsePower, fuel)
        {
        }
    }

    public class Car : Vehicle
    {
        private const double CarFuelConsumption = 3;
        public Car(int horsePower, double fuel) : base(horsePower, fuel)
        {
            this.FuelConsumption = CarFuelConsumption;
        }
    }

    public class FamilyCar : Car
    {
        public FamilyCar(int horsePower, double fuel) : base(horsePower, fuel)
        {
        }
    }

    public class SportCar : Car
    {
        private const double SportCarFuelConsumption = 10;
        public SportCar(int horsePower, double fuel) : base(horsePower, fuel)
        {
            this.FuelConsumption = SportCarFuelConsumption;
        }
    }
}
