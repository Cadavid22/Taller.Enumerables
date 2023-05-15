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

        public  override String ToString()
        {
            string output = string.Empty;
            foreach (int Matriz in Matriz) 
            { 
                Console.WriteLine($"La matriz es{});
            }
           
            return output;
        }
    }
}