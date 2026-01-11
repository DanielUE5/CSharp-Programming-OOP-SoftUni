using BorderControl;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        Dictionary<string, IBuyer> people = new Dictionary<string, IBuyer>();

        for (int i = 0; i < N; i++)
        {
            string[] data = Console.ReadLine().Split();

            if (data.Length == 4) 
            {
                string fullName = data[0];
                int age = int.Parse(data[1]);
                string id = data[2];
                string birthdate = data[3];
                people[fullName] = new Citizen(fullName, age, id, birthdate);
            }
            else if (data.Length == 3) 
            {
                string fullName = data[0];
                int age = int.Parse(data[1]);
                string group = data[2];
                people[fullName] = new Rebel(fullName, age, group);
            }
        }

        int totalFood = 0;
        string name;

        while ((name = Console.ReadLine()) != "End")
        {
            if (people.ContainsKey(name))
            {
                people[name].BuyFood();
            }
        }

        foreach (var person in people.Values)
        {
            totalFood += person.Food;
        }

        Console.WriteLine(totalFood);
    }
}
