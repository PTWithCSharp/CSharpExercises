namespace Section1._2
{
    internal class Problem1_2_6
    {
        //        A string s is a circular rotation of a string t if it matches when the characters
        //are circularly shifted by any number of positions; e.g., "ACTGACG" is a circular shift of
        //"TGACGAC", and vice versa.Detecting this condition is important in the study of genomic
        //sequences.Write a program that checks whether two given strings s and t are circular 
        //shifts of one another
        public static bool Solve(string s, string t)
        {

            return t.Substring(t.IndexOf(s[0])) + t.Substring(0, t.IndexOf(s[0])) == s;
        }
    }
}
