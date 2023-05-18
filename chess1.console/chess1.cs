namespace chess1.console
{
    public class chess1
    {
        private Dictionary<string, List<string>> conflicts;

        public HorseBoard(string)
        {
            conflicts = new Dictionary<string, List<string>>();
            return HorseBoard;
        }

        public void AddHorse(string position)
        {
            conflicts[position] = new List<string>();
        }

        public void AnalyzeConflicts()
        {
            foreach (string horse in conflicts.Keys)
            {
                List<string> horseConflicts = FindConflicts(horse);

                foreach (string conflict in horseConflicts)
                {
                    conflicts[horse].Add(conflict);
                }
            }
        }

        private List<string> FindConflicts(string horse)
        {
            List<string> horseConflicts = new List<string>();

            int horseRow = horse[1] - '1';
            int horseColumn = horse[0] - 'A';

            int[] rowOffsets = { -2, -2, -1, -1, 1, 1, 2, 2 };
            int[] columnOffsets = { -1, 1, -2, 2, -2, 2, -1, 1 };

            for (int i = 0; i < rowOffsets.Length; i++)
            {
                int newRow = horseRow + rowOffsets[i];
                int newColumn = horseColumn + columnOffsets[i];

                if (IsValidPosition(newRow, newColumn))
                {
                    string position = $"{(char)('A' + newColumn)}{(newRow + 1)}";

                    if (conflicts.ContainsKey(position))
                    {
                        horseConflicts.Add(position);
                    }
                }
            }

            return horseConflicts;
        }

        private bool IsValidPosition(int row, int column)
        {
            return row >= 0 && row < 8 && column >= 0 && column < 8;
        }

        public void PrintConflicts()
        {
            foreach (string horse in conflicts.Keys)
            {
                Console.Write($"Analizando Caballo en {horse} => ");

                if (conflicts[horse].Count == 0)
                {
                    Console.WriteLine("Conflicto con: ninguno");
                }
                else
                {
                    Console.WriteLine($"Conflicto con: {string.Join(", ", conflicts[horse])}");
                }
            }
        }

        public static String ToString(int[,] numbers)
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

