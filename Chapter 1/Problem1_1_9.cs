using System.Text;

namespace Chapter1Exercises
{

    internal class Problem1_1_9
    //Write a code fragment that puts the binary representation of a positive integer N
    //into a String s.
    {
        public int N;
        public string S = "hh";



        public void Solve()
        {
            StringBuilder sb = new StringBuilder();
            if (N >= 1)
            {
                do
                {
                    sb.Append(N % 2);
                    N = N / 2;
                } while (N > 1);
            }
            else { Console.WriteLine("N must be larger than 1"); }

        }
    }
}
