using System;
using System.Text;

namespace Animals;

public class Animal
{
    public Animal(string name, int age, string gender)
    {
        if (age <= 0) throw new ArgumentException("Invalid input!");

        this.Name = name;
        this.Age = age;
        this.Gender = gender;
    }

    public string Name { get; set; }
    public int Age { get; set; }
    public string Gender { get; set; }

    public virtual string ProduceSound() => string.Empty;

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine(this.GetType().Name);
        sb.AppendLine($"{this.Name} {this.Age} {this.Gender}");
        sb.Append(this.ProduceSound());

        return base.ToString();
    }
}