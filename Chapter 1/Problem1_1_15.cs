namespace Chapter1Exercises
{
    internal class Problem1_1_15
    {

        public void Solve(int[] a)
        {
            Console.WriteLine("The original array: ");
            foreach (var item in a)
            {
                Console.Write(item + " ");
            }

            Array.Sort(a);
            Console.WriteLine();
            Console.WriteLine("The sorted Array: ");
            foreach (var item in a)
            {
                Console.Write(item + " ");
            }


            SortedSet<int> s = new SortedSet<int>(a);
            int[] S = s.ToArray();
            Console.WriteLine();
            Console.WriteLine("The sorted(without duplicate) array: ");
            foreach (var item in S)
            {
                Console.Write(item + " ");
            }

            int[] m = new int[S.Length];

            Console.WriteLine();
            Console.WriteLine("The result array before start ");
            foreach (var item in m)
            {
                Console.Write(item + " ");
            }


            for (int i = 0; i < a.Length; i++)
            {
                if (S.Contains(a[i]))
                {
                    m[Array.IndexOf(S, a[i])]++;
                }
                else
                {
                    Console.WriteLine("Some thing gone wrong, i can feel it");
                    break;
                }
            }

            Console.WriteLine();
            Console.WriteLine("The final result array: ");
            foreach (var item in m)
            {
                Console.Write(item + " ");
            }

        }
    }
}
