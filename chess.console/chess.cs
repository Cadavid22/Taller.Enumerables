namespace chess.console
{
    public class chess
    {
        public class HarvestField
        {
            private Dictionary<string, string> field;

            public HarvestField()
            {
                field = new Dictionary<string, string>();
            }

            public void AddFruit(string position, string fruit)
            {
                field[position] = fruit;
            }

            public string GetFruit(string position)
            {
                return field.ContainsKey(position) ? field[position] : "";
            }

            public List<string> GetCollectedFruits(string horsePosition, List<string> horseMoves)
            {
                List<string> collectedFruits = new List<string>();

                foreach (string move in horseMoves)
                {
                    string newPosition = GetNewPosition(horsePosition, move);

                    if (IsValidPosition(newPosition))
                    {
                        string fruit = GetFruit(newPosition);

                        if (!string.IsNullOrEmpty(fruit) && !collectedFruits.Contains(fruit))
                        {
                            collectedFruits.Add(fruit);
                        }

                        horsePosition = newPosition;
                    }
                }

                return collectedFruits;
            }
            private string GetNewPosition(string currentPosition, string move)
            {
                int currentRow = currentPosition[0] - 'A';
                int currentColumn = currentPosition[1] - '1';

                int newRow = currentRow;
                int newColumn = currentColumn;

                switch (move)
                {
                    case "UL":
                        newRow -= 2;
                        newColumn -= 1;
                        break;
                    case "UR":
                        newRow -= 2;
                        newColumn += 1;
                        break;
                    case "LU":
                        newRow -= 1;
                        newColumn -= 2;
                        break;
                    case "LD":
                        newRow += 1;
                        newColumn -= 2;
                        break;
                    case "RU":
                        newRow -= 1;
                        newColumn += 2;
                        break;
                    case "RD":
                        newRow += 1;
                        newColumn += 2;
                        break;
                    case "DL":
                        newRow += 2;
                        newColumn -= 1;
                        break;
                    case "DR":
                        newRow += 2;
                        newColumn += 1;
                        break;
                    default:
                        break;
                }

                char newRowIndex = (char)(newRow + 'A');
                char newColumnIndex = (char)(newColumn + '1');

                return $"{newRowIndex}{newColumnIndex}";
            }
            private bool IsValidPosition(string position)
            {
                int row = position[0] - 'A';
                int column = position[1] - '1';

                return row >= 0 && row < 8 && column >= 0 && column < 8;
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
}