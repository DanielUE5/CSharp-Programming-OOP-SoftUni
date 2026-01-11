using Shapes;

public class StartUp
{
    public static void Main()
    {
        Shape rectangle = new Rectangle(5, 10);
        Console.WriteLine(rectangle.Draw());
        Console.WriteLine($"Perimeter: {rectangle.CalculatePerimeter():F2}");
        Console.WriteLine($"Area: {rectangle.CalculateArea():F2}");

        Shape circle = new Circle(7);
        Console.WriteLine(circle.Draw());
        Console.WriteLine($"Perimeter: {circle.CalculatePerimeter():F2}");
        Console.WriteLine($"Area: {circle.CalculateArea():F2}");
    }
}
