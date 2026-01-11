using System;
using System.Collections.Generic;
using WildFarm;

public class StartUp
{
    public static void Main()
    {
        List<Animal> animals = new List<Animal>();
        string input;

        while ((input = Console.ReadLine()) != "End")
        {
            string[] animalData = input.Split();
            Animal animal = CreateAnimal(animalData);

            string[] foodData = Console.ReadLine().Split();
            Food food = CreateFood(foodData);

            animal.MakeSound();

            try
            {
                animal.EatFood(food);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

            animals.Add(animal);
        }

        foreach (var animal in animals)
        {
            Console.WriteLine(animal);
        }
    }

    private static Animal CreateAnimal(string[] data)
    {
        string type = data[0];
        string name = data[1];
        double weight = double.Parse(data[2]);

        return type switch
        {
            "Cat" => new Cat(name, weight, data[3], data[4]),
            "Tiger" => new Tiger(name, weight, data[3], data[4]),
            "Owl" => new Owl(name, weight, double.Parse(data[3])),
            "Hen" => new Hen(name, weight, double.Parse(data[3])),
            "Mouse" => new Mouse(name, weight, data[3]),
            "Dog" => new Dog(name, weight, data[3]),
            _ => throw new ArgumentException("Invalid animal type!")
        };
    }

    private static Food CreateFood(string[] data)
    {
        string type = data[0];
        int quantity = int.Parse(data[1]);

        return type switch
        {
            "Vegetable" => new Vegetable(quantity),
            "Fruit" => new Fruit(quantity),
            "Meat" => new Meat(quantity),
            "Seeds" => new Seeds(quantity),
            _ => throw new ArgumentException("Invalid food type!")
        };
    }
}
