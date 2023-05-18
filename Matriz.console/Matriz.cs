namespace Matriz.logic
{
    public static class Matriz
    {
        public static int[,] MultiplyMatriz(int[,] A, int[,] B)
        {
            int m = A.GetLength(0);
            int n = A.GetLength(1);
            int p = B.GetLength(1);
            int[,] C = new int[m, p];

            Console.WriteLine("*** A ***");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(A[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("*** B ***");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < p; j++)
                {
                    Console.Write(B[i, j] + " ");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < p; j++)
                {
                    for (int k = 0; k < n; k++)
                    {
                        C[i, j] += A[i, k] * B[k, j];
                    }
                }
            }

            return C;
        }

        public static String ToString(int[,]numbers)
        {
            var output = string.Empty;
            foreach (int number in numbers) 
            {
                output += $"{number}\t";
            }
           
            return output + "\n";
        }
    }
}