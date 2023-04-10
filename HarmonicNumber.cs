using System;
namespace BasicCoreProblems
{
    public class HarmonicNumber
    {
        public static void PrintHarmonicNumber()
        {
            int n;

            Console.Write("Enter the number: ");
            string input = Console.ReadLine();

            if (!int.TryParse(input, out n) || n == 0)
            {
                Console.WriteLine("Invalid input. number should be a non-zero positive integer.");
                return;
            }

            double sum = 0;

            for (int i = 1; i <= n; i++)
            {
                sum += 1.0 / i;
            }

            Console.WriteLine("The {0}th harmonic number is {1}.", n, sum);
        }
    }
}

