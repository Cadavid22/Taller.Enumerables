
Console.WriteLine("***********************");
Console.WriteLine(" CABALLOS EN CONFLICTO ");
Console.WriteLine("***********************");

HorseBoard board = new HorseBoard();

Console.WriteLine("Ingrese ubicación de los caballos: (ejemplo: B7,C5,E2,H7,G5,F6)");
string input = Console.ReadLine();

string[] horses = input.Split(',');

foreach (string horse in horses)
{
    board.AddHorse(horse);
}

board.AnalyzeConflicts();
board.PrintConflicts();
        }