namespace Chapter1Exercises
{
    internal class Problem1_1_22
    {
        //        Write a version of BinarySearch that uses the recursive rank() given on page 
        //        25 and traces the method calls.Each time the recursive method is called, print the argument values lo and hi, indented by the depth of the recursion.Hint: Add an argument
        //        to the recursive method that keeps track of the depth.
        public static int rank(int key, int[] a, int high, int low = 0, int depth = 0)
        {
            if (depth == 0) high = a.Length;
            int mid = (low + high) / 2;

            if (key < a[mid])
            {
                depth++;
                rank(key, a, mid - 1, low, depth);
            }
            else if (key > a[mid])
            {
                depth++;
                rank(key, a, high, mid + 1, depth);
            }
            else return mid;

            return -1;


        }
    }
}
