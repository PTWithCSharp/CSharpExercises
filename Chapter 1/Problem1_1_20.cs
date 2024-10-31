namespace Chapter1Exercises
{
    internal class Problem1_1_20
    {
        public int k = 0;
        public double Solve(int N)
        {
            if (N == 1) { return 0; }
            else
            {
                return Math.Log(N) + Solve(N - 1);
            }

        }
    }
}
