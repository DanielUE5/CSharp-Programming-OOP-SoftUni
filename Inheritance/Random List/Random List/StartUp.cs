namespace CustomRandomList
{
    public class StartUp
    {
        public static void Main()
        {
            RandomList randomList = new RandomList();
            randomList.Add("Apple");
            randomList.Add("Banana");
            randomList.Add("Cherry");
            randomList.Add("Date");
            randomList.Add("Elderberry");

            Console.WriteLine("Random element removed: " + randomList.RandomString());
            Console.WriteLine("Remaining elements: " + string.Join(", ", randomList));
        }
    }
}
