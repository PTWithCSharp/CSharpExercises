namespace Section1._2
{
    //    Write a Point2D client that takes an integer value N from the command line,
    //    generates N random points in the unit square, and computes the distance separating
    //    the closest pair of points.
    internal class Problem1_2_1
    {
        //calculate the distance between 2 points
        public static double Dist((double x1, double y1) tuple1, (double x2, double y2) tuple2)
        {
            return Math.Sqrt(Math.Pow(tuple2.x2 - tuple1.x1, 2) + Math.Pow(tuple2.y2 - tuple1.y1, 2));
        }


        public static double Solve(int N)
        {

            Random random = new Random();
            //create an array of tuples to hold points
            (double, double)[] Points = new (double, double)[N];

            //generate N points randomly
            for (int i = 0; i < Points.Length; i++)
            {
                Points[i] = (random.NextDouble(), random.NextDouble());
            }
            double smallestDist = Dist(Points[0], Points[1]);
            double currentDist = 0;


            //check the dist between 2 points using bruteforce
            for (int i = 0; i < Points.Length; i++)
            {
                for (int j = 0; j < Points.Length; j++)
                {
                    currentDist = Dist(Points[i], Points[j]);
                    if (currentDist > smallestDist)
                    {
                        smallestDist = currentDist;
                    }
                }
            }

            return smallestDist;

        }
    }
}
