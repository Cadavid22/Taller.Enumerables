using clock.logic;

namespace clock.logic
{
    public static class Clock1
    {
        public static List<int> Createclock(int N)
        {

            

            for (int i = 0; i < N; i++)
            {
                List<int> fila = new List<int>(N);

                for (int j = 0; j < N; j++)
                {
                    fila.Add(i * 2 + j);
                }
                CreateHourglass.Add(fila);

            }

            return CreateHourglass;
        }
    }

    public static void showClock(List<List<int>> matriz)
    {
    int N = matriz.Count;
    int inicio = 0;
    int fin = N - 1;

    while (inicio <= fin)
    {
        for (int j = inicio; j <= fin; j++)
        {
            Console.Write(matriz[inicio][j] + " ");
        }
        Console.WriteLine();

        for (int i = inicio + 1; i <= fin; i++)
        {
            for (int j = inicio + 1; j <= fin - 1; j++)
            {
                Console.Write(matriz[i][j] + " ");
            }
            Console.WriteLine();
        }

        for (int j = inicio; j <= fin; j++)
        {
            Console.Write(matriz[fin][j] + " ");
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
        return ShowMatrix;
        }

    public override String ToString()
    {
        string output = string.Empty;
        foreach (int Matriz in Matriz)
        {
            Console.WriteLine($"La matriz es{});
            }

        return output;
    }

}
