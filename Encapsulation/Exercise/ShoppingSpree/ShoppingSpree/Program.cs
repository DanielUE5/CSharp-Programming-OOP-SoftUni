namespace ShoppingSpree;

class Program
{
    static void Main()
    {
        try
        {
            var peopleInput = Console.ReadLine()
                .Split(';', StringSplitOptions.RemoveEmptyEntries);
            var productsInput = Console.ReadLine()
                .Split(';', StringSplitOptions.RemoveEmptyEntries);

            var people = new Dictionary<string, Person>();
            var products = new Dictionary<string, Product>();

            foreach (var personInfo in peopleInput)
            {
                var parts = personInfo.Split('=');
                var name = parts[0];
                var money = decimal.Parse(parts[1]);
                people[name] = new Person(name, money);
            }

            foreach (var productInfo in productsInput)
            {
                var parts = productInfo.Split('=');
                var name = parts[0];
                var cost = decimal.Parse(parts[1]);
                products[name] = new Product(name, cost);
            }

            string command;
            while ((command = Console.ReadLine()) != "END")
            {
                var parts = command.Split();
                var personName = parts[0];
                var productName = parts[1];

                var person = people[personName];
                var product = products[productName];

                if (person.BuyProduct(product))
                {
                    Console.WriteLine($"{personName} bought {productName}");
                }
                else
                {
                    Console.WriteLine($"{personName} can't afford {productName}");
                }
            }

            foreach (var person in people.Values)
            {
                var productsBought = person.Bag.Any()
                    ? string.Join(", ", person.Bag.Select(p => p.Name))
                    : "Nothing bought";
                Console.WriteLine($"{person.Name} - {productsBought}");
            }
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}