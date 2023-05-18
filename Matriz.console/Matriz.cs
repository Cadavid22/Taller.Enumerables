using System.Security.Cryptography.X509Certificates;

namespace Matriz.logic
{
    public static class Matriz
    {
        public static void FillMyMatriz(int m, int n, int p)
        {
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    A[i, j] = (i + 1) * j;

                    Console.Write(A[i, j] + " ");
                }
                Console.WriteLine();
            }

           for (int i = 0; i < n; i++)
           {
               for (int j = 0; j < p; j++)
               {
                    B[i, j] = (j + 1) * i;

                    Console.Write(B[i, j] + " ");
               }
                    Console.WriteLine();
           }
            
        }
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