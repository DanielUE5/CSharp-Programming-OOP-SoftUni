namespace Vehicles;

public class Bus : Vehicle
{
    private const double AirConditionConsumption = 1.4;

    public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity)
        : base(fuelQuantity, fuelConsumption, tankCapacity)
    {
    }

    public string DriveWithPassengers(double distance)
    {
        FuelConsumption += AirConditionConsumption;
        string result = Drive(distance);
        FuelConsumption -= AirConditionConsumption;
        return result;
    }
}
