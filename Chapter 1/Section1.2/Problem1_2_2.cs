namespace Section1._2
{
    internal class Problem1_2_2
    {
        //        Write an Interval1D client that takes an int value N as command-line argument, reads N intervals(each defined by a pair of double values) from standard input, 
        //        and prints all pairs that intersect.

        public static (double, double) FindEquation((double x1, double y1) point1, (double x2, double y2) point2)
        {
            double a = (point1.y1 - point2.y2) / (point1.x1 - point2.x2);
            double b = point1.y1 - a * point1.x1;

            return (a, b);
        }

        public static (double, double) FindCrossedPoint((double a1, double b1) line1, (double a2, double b2) line2)
        {
            if (line1.a1 == line2.a2) return (double.NaN, double.NaN);

            double x = (line2.b2 - line1.b1) / (line1.a1 - line2.a2);
            double y = line1.a1 * x + line1.b1;

            return (x, y);

        }

        public static bool TestPointOnLine((double x, double y) point, (double a, double b) line)
        {
            if (line.a * point.x + line.b - point.y == 0) return true;
            return false;

        }

        public static void Solve(int N)
        {
            ((double, double), (double, double))[] pairOfPoints = new ((double, double), (double, double))[N];

            Random random = new Random();
            for (int i = 0; i < N; i++)
            {
                pairOfPoints[i] = ((random.NextDouble(), random.NextDouble()), (random.NextDouble(), random.NextDouble()));
            }

            (double, double)[] equationParams = new (double, double)[N];

            for (int i = 0; i < N; i++)
            {
                equationParams[i] = FindEquation(pairOfPoints[i].Item1, pairOfPoints[i].Item2);
            }

            (double, double)[,] CrossedPoints = new (double, double)[N, N];

            for (int i = 0; i < equationParams.Length; i++)
            {
                for (int j = 0; j < equationParams.Length; j++)
                {
                    CrossedPoints[i, j] = FindCrossedPoint(equationParams[i], equationParams[j]);
                }
            }


            HashSet<(double, double)> values = new HashSet<(double, double)>();

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    values.Add(CrossedPoints[i, j]);
                }
            }

            (double, double)[] FinalCrossedPoints = values.ToArray();


            for (int i = 0; i < FinalCrossedPoints.Length; i++)
            {
                Console.Write($"Points:{FinalCrossedPoints[i]} ");
                Console.Write("Line Crossed");

                for (int j = 0; j < equationParams.Length; j++)
                {
                    if (TestPointOnLine(FinalCrossedPoints[i], equationParams[j]))
                    {
                        Console.Write($"{equationParams[i].Item1}x+{equationParams[i].Item2}, ");
                    }
                }
                Console.WriteLine();

            }

        }
    }
}
