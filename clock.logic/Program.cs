
Console.WriteLine("***********************");
Console.WriteLine("     RELOJ DE ARENA    ");
Console.WriteLine("***********************");

Console.WriteLine("RELOJ DE ARENA");
Console.WriteLine("Ingrese la orden de la matriz: ");
int N = int.Parse(Console.ReadLine());
int N = 11;

Dictionary<(int, int), int> clock = CreateClock(N);

Console.WriteLine("MATRIZ COMPLETA");
ShowMatrix(clock);

Console.WriteLine("RELOJ DE ARENA");
ShowClock(clock);
        }