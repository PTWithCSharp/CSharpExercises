namespace Section1._2
{
    internal class RecursiveReverseStr
    {
        public static string RecursiveReversed(string s)
        {
            if (s.Length <= 1) return s;
            string firstOfS = s.Substring(s.Length / 2);
            string secondofS = s.Substring(0, s.Length / 2);
            return RecursiveReversed(secondofS) + RecursiveReversed(firstOfS);
        }
    }
}
