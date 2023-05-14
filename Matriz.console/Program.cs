
Console.WriteLine("**********************");
Console.WriteLine("        MATRIZ        ");
Console.WriteLine("**********************");


Console.Write("Enter the value of m: ");
int m = int.Parse(Console.ReadLine());

Console.Write("Enter the value of n: ");
int n = int.Parse(Console.ReadLine());

Console.Write("Enter the value of p: ");
int p = int.Parse(Console.ReadLine());

int[,] A = new int[m, n];
int[,] B = new int[n, p];
int[,] C = new int[m, p];
