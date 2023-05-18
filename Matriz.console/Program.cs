

Console.WriteLine("****************************");
Console.WriteLine(" MULTIPLICACION DE MATRICES ");
Console.WriteLine("****************************");




 Console.Write("Ingrese el valor de m: ");
    int m = int.Parse(Console.ReadLine());

Console.Write("Ingrese el valor de n: ");
    int n = int.Parse(Console.ReadLine());

 Console.Write("Ingrese el valor de p: ");
    int p = int.Parse(Console.ReadLine());

int[,] A = new int[m, n];
int[,] B = new int[n, p];
int[,] C = new int[m, p];

Console.WriteLine("*** MATRIZ A Y MATRIZ B ***");
Console.WriteLine(FillMyMatriz);
Console.WriteLine(MultiplyMatriz);








