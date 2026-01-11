namespace CustomStack
{
    public class StartUp
    {
        public static void Main()
        {
            StackOfStrings stack = new StackOfStrings();
            Console.WriteLine(stack.IsEmpty()); 

            stack.Push("Easy");
            Console.WriteLine(stack.IsEmpty()); 

            stack.AddRange(new List<string> { "Fight", "Club", "Hard" });

            while (stack.Count > 0)
            {
                Console.WriteLine(stack.Pop());
            }
        }
    }
}
