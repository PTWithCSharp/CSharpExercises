namespace Chapter1Exercises
{
    internal class Problem1_1_14
    {
        //Write a static method lg() that takes an int value N as argument and returns 
        //the largest int not larger than the base-2 logarithm of N.Do not use Math


        public int Solve(int N)
        {
            int product = 1;
            int counter = 0;
            while (product < N)
            {
                product *= 2;
                if (product >= N) break;
                counter++;

            }
            Console.WriteLine(counter);
            return counter;
        }


    }
}
