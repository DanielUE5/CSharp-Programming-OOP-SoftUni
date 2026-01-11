namespace PizzaCalories
{
    public class Program
    {
        static void Main()
        {
            try
            {
                Pizza pizza = ReadPizza();
                AddIngredients(pizza);
                PrintOutput(pizza);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private static Pizza ReadPizza()
        {
            string[] data = Console.ReadLine().Split();

            return new Pizza(data[1]);
        }

        private static void AddIngredients(Pizza pizza)
        {
            string input = Console.ReadLine();
            while (input != "END")
            {
                string[] data = input.Split();

                if (data[0] == "Dough")
                {
                    Dough dough = new Dough(data[1], data[2], double.Parse(data[3]));
                    pizza.Dough = dough;
                }
                else if (data[0] == "Topping")
                {
                    Topping topping = new Topping(data[1], double.Parse(data[2]));
                    pizza.AddTopping(topping);
                }

                input = Console.ReadLine();
            }
        }

        private static void PrintOutput(Pizza pizza)
        {
            Console.WriteLine($"{pizza.Name} - {pizza.Calories:f2} Calories.");
        }
    }
}
