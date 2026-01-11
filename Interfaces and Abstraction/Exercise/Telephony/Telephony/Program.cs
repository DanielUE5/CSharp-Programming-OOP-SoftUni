namespace Telephony
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] phoneNumbers = Console.ReadLine().Split();
            string[] websites = Console.ReadLine().Split();

            Smartphone smartphone = new Smartphone();
            StationaryPhone stationaryPhone = new StationaryPhone();

            foreach (var number in phoneNumbers)
            {
                if (number.Length == 10)
                {
                    Console.WriteLine(smartphone.Call(number));
                }
                else if (number.Length == 7)
                {
                    Console.WriteLine(stationaryPhone.Call(number));
                }
                else
                {
                    Console.WriteLine("Invalid number!");
                }
            }

            foreach (var website in websites)
            {
                Console.WriteLine(smartphone.Browse(website));
            }
        }
    }
}
