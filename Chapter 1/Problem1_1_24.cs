namespace Chapter1Exercises
{
    //    Give the sequence of values of p and q that are computed when Euclid’s algorithm is used to compute the greatest common divisor of 105 and 24. Extend the code
    //    given on page 4 to develop a program Euclid that takes two integers from the command
    //    line and computes their greatest common divisor, printing out the two arguments for 
    //    each call on the recursive method.Use your program to compute the greatest common
    //    divisor of 1111111 and 1234567.
    internal class Problem1_1_24
    {
        public static int result;

        public static int Solve(int p, int q)
        {
            int temp;


            //swap to ensure p larger than q
            if (p < q)
            {
                temp = p;
                p = q;
                q = temp;
            }

            //calculate the GCD of p and q using Euclid algorithm
            if (p % q == 0)
            {
                return q;
            }
            else
            {
                return Solve(p % q, q);
            }

        }
    }
}
