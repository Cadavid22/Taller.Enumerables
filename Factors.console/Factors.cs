namespace Matriz.logic
{
    public static class PrimeFactors
    {
        public static List<int> GetPrimeFactors(int number)
         {

            List<int> Factors = new List<int>();
            int divisor = 2;

            while (number > 1)
            {
                if (number % divisor == 0)
                {
                    Factors.Add(number / divisor);
                    number /= divisor;
                }
                else
                {
                    divisor++;
                }
            }
            return Factors;
        }

        public static override string ToString(int, Factors)
        {
            var output = string.Empty;
            foreach (int Factor in Factors)
            {
                Console.WriteLine($"Los numeros primos son: {Factor}");
            }

            return output;
        }

    }
}