using System;
using System.Collections.Generic;
using Vehicles;

public class StartUp
{
    public static void Main()
    {
        var vehicles = new Dictionary<string, Vehicle>
        {
            { "Car", CreateVehicle(Console.ReadLine()) },
            { "Truck", CreateVehicle(Console.ReadLine()) },
            { "Bus", CreateVehicle(Console.ReadLine()) }
        };

        int commandsCount = int.Parse(Console.ReadLine());

        for (int i = 0; i < commandsCount; i++)
        {
            string[] commandParts = Console.ReadLine().Split();
            string action = commandParts[0];
            string vehicleType = commandParts[1];

            try
            {
                switch (action)
                {
                    case "Drive":
                        double distance = double.Parse(commandParts[2]);
                        Console.WriteLine(vehicleType == "Bus"
                            ? ((Bus)vehicles[vehicleType]).DriveWithPassengers(distance)
                            : vehicles[vehicleType].Drive(distance));
                        break;
                    case "DriveEmpty":
                        distance = double.Parse(commandParts[2]);
                        Console.WriteLine(vehicles[vehicleType].Drive(distance));
                        break;
                    case "Refuel":
                        double liters = double.Parse(commandParts[2]);
                        vehicles[vehicleType].Refuel(liters);
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        foreach (var vehicle in vehicles)
        {
            Console.WriteLine(vehicle.Value);
        }
    }

    private static Vehicle CreateVehicle(string input)
    {
        string[] parts = input.Split();
        string type = parts[0];
        double fuelQuantity = double.Parse(parts[1]);
        double fuelConsumption = double.Parse(parts[2]);
        double tankCapacity = double.Parse(parts[3]);

        return type switch
        {
            "Car" => new Car(fuelQuantity, fuelConsumption, tankCapacity),
            "Truck" => new Truck(fuelQuantity, fuelConsumption, tankCapacity),
            "Bus" => new Bus(fuelQuantity, fuelConsumption, tankCapacity),
            _ => throw new InvalidOperationException("Invalid vehicle type")
        };
    }
}
