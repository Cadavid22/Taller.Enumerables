﻿using Matriz.logic;


Console.WriteLine("****************************");
Console.WriteLine(" DESCOMPOSICION EN FACTORES ");
Console.WriteLine("****************************");


Console.WriteLine("Enter a number: ");
int number = int.Parse(Console.ReadLine());

List<int> Factors = PrimeFactors.GetPrimeFactors(number);

Console.Write("Prime Factors of " + number + ":");

foreach(int f in Factors) 
{
    Console.WriteLine(Factors + " ");
}
Console.WriteLine();