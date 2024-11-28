namespace Section1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedListStack<string> StringStack = new LinkedListStack<string>("first");
            StringStack.Push("second");
            StringStack.Push("third");
            Console.WriteLine(StringStack.Count);


            foreach (string str in StringStack)
            {
                Console.WriteLine(str);
            }
        }
    }
}
