
Console.WriteLine("**********************");
Console.WriteLine(" COSECHANDO A CABALLO ");
Console.WriteLine("**********************");

HarvestField field = new HarvestField();

Console.WriteLine("Ingrese ubicación de los frutos: (ejemplo: C4+,C7*,E3-,E1=,H4*)");
string fruitsInput = Console.ReadLine();

string[] fruits = fruitsInput.Split(',');

foreach (string fruit in fruits)
{
    string position = fruit.Substring(0, 2);
    string type = fruit.Substring(2);

    field.AddFruit(position, type);
}

Console.WriteLine("Ingrese posición inicial del caballo:");
string horsePosition = Console.ReadLine();

Console.WriteLine("Ingrese los movimientos del caballo: (ejemplo: DR,RD,RD,LD,RU,UR,UL)");
string movesInput = Console.ReadLine();

string[] moves = movesInput.Split