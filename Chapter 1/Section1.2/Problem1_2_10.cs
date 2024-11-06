namespace Section1._2
{
    internal class Problem1_2_10
    {
        public class VisualCounter
        {
            private int _operation;
            public string Name { get; set; }
            public int Total { get; set; } = 0;

            public int N { get; }

            public int Max { get; }

            public VisualCounter() { }

            public VisualCounter(string name, int total, int n, int max)
            {
                Name = name;
                Total = total;
                N = n;
                Max = max;
            }

            public void increment()
            {
                if (_operation > N)
                {
                    Console.WriteLine("Sorry, we reached maximum operation");
                    return;
                }
                if (Total >= Max)
                {
                    Console.WriteLine("Sorry, we reached the maximum value");
                    return;
                }
                _operation++;
                Total++;
            }
            public void decrement()
            {
                if (_operation > N)
                {
                    Console.WriteLine("Sorry, we reached maximum operation");
                    return;
                }

                _operation++;
                Total--;
            }

            public override string ToString()
            {
                return "Visual Counter name:" + Name;
            }



        }
    }
}