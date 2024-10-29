namespace Chapter1Exercises
{
    internal class Problem1_1_3
    //        Write a program that takes three integer command-line arguments and prints
    //        equal if all three are equal, and not equal otherwise.
    {
        public int first_argument;
        public int second_argument;
        public int third_argument;

        public bool Solve()
        {
            Console.WriteLine("Enter first argument");
            first_argument = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second argument");
            second_argument = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter third argument");
            third_argument = int.Parse(Console.ReadLine());

            if (first_argument == second_argument && second_argument == third_argument)
            {
                Console.WriteLine("equal");
                return true;
            }
            else
            {
                Console.WriteLine("not equal");
                return false;
            }


        }

    }
}
