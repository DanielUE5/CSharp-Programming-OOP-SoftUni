using System.Text;
using System;

namespace Person;
public class Person
{
    private string name;
    private int age;

    public Person(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }

    public string Name
    {
        get { return name; }
        private set { name = value; }
    }

    public int Age
    {
        get { return age; }
        protected set
        {
            if (value < 0)
            {
                throw new ArgumentException("Age must be positive!");
            }
            age = value;
        }
    }

    public override string ToString()
    {
        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.Append(String.Format("{0} -> ",
                             this.GetType().Name));
        stringBuilder.Append(String.Format("Name: {0}, Age: {1}",
                             this.Name,
                             this.Age));

        return stringBuilder.ToString();
    }


    public class Child : Person
    {
        public Child(string name, int age)
            : base(name, age)
        {
            if (age > 15)
            {
                throw new ArgumentException("A child's age cannot be greater than 15.");
            }
        }
    }
}