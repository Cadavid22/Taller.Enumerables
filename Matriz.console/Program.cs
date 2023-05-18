
using System.Threading.Tasks.Sources;

Console.WriteLine("****************************");
Console.WriteLine(" MULTIPLICACION DE MATRICES ");
Console.WriteLine("****************************");

Console.Write("Ingrese el valor de m: ");
    int m = int.Parse(Console.ReadLine());

Console.Write("Ingrese el valor de n: ");
    int n = int.Parse(Console.ReadLine());

 Console.Write("Ingrese el valor de p: ");
    int p = int.Parse(Console.ReadLine());

var mat = new operation.mat ();

mat.GetFillMyMatriz(m, n, p);
mat.MultiplyMatriz(m, n, p);

Console.WriteLine(mat);






