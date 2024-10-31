namespace Chapter1Exercises
{

    //Write a program BruteForceSearch
    //that uses the brute-force search method given on page 48 and compare its running time
    //on your computer with that of BinarySearch for largeW.txt and largeT.txt.
    internal class Problem1_1_38
    {
        public static int Solve(int key, int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == key) return i;
            }
            return -1;

        }
    }

}
