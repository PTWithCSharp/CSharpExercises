using System.Globalization;

namespace Chapter1Exercises
{
    internal class Problem1_1_21
    {
        public static void Solve(string[] args)
        {
            Console.WriteLine($"{"Names",8} {"Number1",7} {"Number2",7} {"Result",7}");

            while (true)
            {
                string line = Console.ReadLine();
                if (string.IsNullOrEmpty(line)) break;

                string[] values = line.Split(" ");
                FormattedPrint(values);
            }
        }

        private static void FormattedPrint(string[] values)
        {
            Console.Write($"{values[0],8}");
            Console.Write($"{values[1],8}");
            Console.Write($"{values[2],8}");

            double value1 = double.Parse(values[1], CultureInfo.InvariantCulture);
            double value2 = double.Parse(values[2], CultureInfo.InvariantCulture);
            double result = value1 / value2;

            Console.WriteLine($"{result,7:F3}");
        }


    }
}
