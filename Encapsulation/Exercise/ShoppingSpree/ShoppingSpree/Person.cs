using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingSpree;
class Person
{
    private string name;
    private decimal money;
    private List<Product> bag;

    public Person(string name, decimal money)
    {
        Name = name;
        Money = money;
        bag = new List<Product>();
    }

    public string Name
    {
        get => name;
        private set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Name cannot be empty");
            name = value;
        }
    }

    public decimal Money
    {
        get => money;
        private set
        {
            if (value < 0)
                throw new ArgumentException("Money cannot be negative");
            money = value;
        }
    }

    public IReadOnlyList<Product> Bag => bag.AsReadOnly();

    public bool BuyProduct(Product product)
    {
        if (Money >= product.Cost)
        {
            money -= product.Cost;
            bag.Add(product);
            return true;
        }
        return false;
    }
}