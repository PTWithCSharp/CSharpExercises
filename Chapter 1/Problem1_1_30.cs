namespace Chapter1Exercises
{
    //Write a code fragment that creates an N-by-N boolean array
    //a[][] such that a[i][j] is true if i and j are relatively prime(have no common factors), 
    //and false otherwise
    internal class Problem1_1_30
    {
        public static int GCD(int p, int q)
        {
            int temp;
            if (p == 0 || q == 0)
            {
                return -1;
            }
            //swap p and q to ensure p larger than q
            if (p < q)
            {
                temp = p;
                p = q;
                q = temp;
            }

            if (p % q == 1)
            {
                return 1;
            }
            if (p % q == 0)
            {
                return q;
            }
            else
            {
                return GCD(p % q, q);
            }

        }
        public static bool[,] RelativePrimeBoolArrays(int rows, int cols)
        {
            bool[,] bools = new bool[rows, cols];
            for (int i = 0; i < bools.GetLength(0); i++)
            {
                for (int j = 0; j < bools.GetLength(1); j++)
                {
                    if (GCD(i, j) == 1)
                    {
                        bools[i, j] = true;
                    }
                    else bools[i, j] = false;
                }

            }
            for (int i = 0; i < bools.GetLength(0); i++)
            {
                Console.WriteLine();
                for (int j = 0; j < bools.GetLength(1); j++)
                {
                    Console.Write("  " + $"bools[{i},{j}]: " + bools[i, j]);
                }

            }
            return bools;
        }



    }
}
