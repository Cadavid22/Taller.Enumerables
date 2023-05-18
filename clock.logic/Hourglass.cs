using clock.logic;


namespace clock.logic
{
    public static class Clock1
    {
        public static Dictionary<(int, int), int> CreateClock(int N)
        {
            Dictionary<(int, int), int> clock = new Dictionary<(int, int), int>();

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    int value = i * 2 + j;
                    clock.Add((i, j), value);
                }
            }

            return clock;
        }


        public static void ShowClock(Dictionary<(int, int), int> clock)
        {
            int N = (int)Math.Sqrt(clock.Count);
            int inicio = 0;
            int fin = N - 1;

            while (inicio <= fin)
            {
                for (int j = inicio; j <= fin; j++)
                {
                    Console.Write(clock[(inicio, j)] + " ");
                }
                Console.WriteLine();

                for (int i = inicio + 1; i <= fin; i++)
                {
                    for (int j = inicio + 1; j <= fin - 1; j++)
                    {
                        Console.Write(clock[(i, j)] + " ");
                    }
                    Console.WriteLine();
                }

                for (int j = inicio; j <= fin; j++)
                {
                    Console.Write(clock[(fin, j)] + " ");
                }
                Console.WriteLine();

                inicio++;
                fin--;
            }
        }
        public static void ShowMatrix(List<List<int>> matriz)
        {
            int filas = matriz.Count;
            int columnas = matriz[0].Count;

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write(matriz[i][j] + " ");
                }
                Console.WriteLine();
            }

        }

        public static String ToString(int[,] numbers)
        {
            string output = string.Empty;
            foreach (int Matriz in numbers)
            {
                output += $"{number}\t";

            }

            return output;
        }

    }
}
