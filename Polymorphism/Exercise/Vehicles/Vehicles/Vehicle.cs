using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public abstract class Vehicle
    {
        protected Vehicle(double fuelQuantity, double fuelConsumption, double tankCapacity)
        {
            TankCapacity = tankCapacity;
            FuelQuantity = fuelQuantity > tankCapacity ? 0 : fuelQuantity;
            FuelConsumption = fuelConsumption;
        }

        public double FuelQuantity { get; protected set; }
        public double FuelConsumption { get; protected set; }
        public double TankCapacity { get; }

        public string Drive(double distance)
        {
            double requiredFuel = distance * FuelConsumption;
            if (requiredFuel > FuelQuantity)
            {
                return $"{GetType().Name} needs refueling";
            }

            FuelQuantity -= requiredFuel;
            return $"{GetType().Name} travelled {distance} km";
        }

        public virtual void Refuel(double liters)
        {
            if (liters <= 0)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }

            if (FuelQuantity + liters > TankCapacity)
            {
                throw new InvalidOperationException($"Cannot fit {liters} fuel in the tank");
            }

            FuelQuantity += liters;
        }

        public override string ToString() => $"{GetType().Name}: {FuelQuantity:F2}";
    }
}
