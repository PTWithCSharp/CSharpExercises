namespace Chapter1Exercises
{
    internal class Problem_1_1_13
    {
        //Calculate the transpose of an matrix
        public int[,] matrix = new[,] { {1,2,3,4 },
                                 {5,6,7,8 },
                                 {9,10,11,12 },
                                 {13,14,15,16 } };



        public void Solve()
        {
            //save the last element before loops cause it will be used as temp when swapping
            int matrixLastElement = matrix[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = i; j < matrix.GetLength(1); j++)

                {
                    //if i not equal to j swap 2 elements with last element as temp
                    if (i != j)
                    {
                        matrix[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1] = matrix[i, j];
                        matrix[i, j] = matrix[j, i];
                        matrix[j, i] = matrix[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
                    }
                }

            }

            //retrieve the last element 
            matrix[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1] = matrixLastElement;
            Console.WriteLine("Transposed Matrix: ");

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }



        }


    }
}
