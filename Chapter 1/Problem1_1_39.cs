namespace Chapter1Exercises
{
    internal class Problem1_1_39
    {
        public static int rank(int key, int[] a)
        {
            int low = 0;
            int high = a.Length - 1;

            while (low <= high)
            {
                int mid = (low + high) / 2;

                if (key < a[mid])
                {
                    high = mid - 1;
                }
                else if (key > a[mid])
                {
                    low = mid + 1;
                }
                else return mid;


            }
            return -1;

        }

        public static void PrintTable(string[] columnNames, string[] rowNames, int[,] data)
        {
            int columnWidth = 10;

            Console.Write(new string(' ', columnWidth));
            foreach (string columnName in columnNames)
            {
                Console.Write(columnName.PadLeft(columnWidth));
            }
            Console.WriteLine();


            for (int i = 0; i < data.GetLength(0); i++)
            {

                Console.Write(rowNames[i].PadRight(columnWidth));

                for (int j = 0; j < data.GetLength(1); j++)
                {
                    Console.Write(data[i, j].ToString().PadLeft(columnWidth));
                }
                Console.WriteLine();
            }
        }

        public static void Solve(int T)
        {
            Random random = new Random();
            int[] NArray = { 10_000, 100000, 10_000_000 };
            int[,] finalData = new int[T, NArray.Length];
            int finalDataRowIndex = 0, finalDataColIndex = 0;
            for (int i = 0; i < T; i++)
            {
                Console.WriteLine("row");

                foreach (int N in NArray)
                {
                    Console.WriteLine("col");
                    int duplicateCount = 0;

                    int[] randomArray1 = new int[N];
                    for (int j = 0; j < randomArray1.Length; j++)
                    {
                        randomArray1[j] = random.Next(100_000, 999_999);
                    }
                    Console.WriteLine("col1");


                    int[] randomArray2 = new int[N];
                    for (int j = 0; j < randomArray2.Length; j++)
                    {
                        randomArray2[j] = random.Next(100_000, 999_999);
                    }


                    Array.Sort(randomArray2);

                    int[] appearanceArray = new int[randomArray1.Length];
                    int appearanceIndex = 0;
                    Console.WriteLine("col2");
                    Console.WriteLine(N);
                    foreach (var item in randomArray1)
                    {
                        if (N == 10_000_000)
                        {

                            Console.WriteLine(duplicateCount);

                        }

                        if (!appearanceArray.Contains(item))
                        {
                            appearanceArray[appearanceIndex] = item;
                            appearanceIndex++;
                            if (rank(item, randomArray2) != -1)
                            {
                                duplicateCount++;
                            }
                        }

                    }
                    Console.WriteLine(finalDataRowIndex + " " + finalDataColIndex);

                    finalData[finalDataRowIndex, finalDataColIndex] = duplicateCount;
                    finalDataColIndex++;
                }
                finalDataColIndex = 0;
                finalDataRowIndex++;
            }

            string[] rowNames = new string[T];
            string[] columnNames = new string[NArray.Length];
            for (int i = 0; i < T; i++)
            {
                rowNames[i] = i.ToString();
            }
            for (int i = 0; i < NArray.Length; i++)
            {
                columnNames[i] = NArray[i].ToString();
            }

            PrintTable(columnNames, rowNames, finalData);

        }



    }
}
