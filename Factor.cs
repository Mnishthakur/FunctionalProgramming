using System;
namespace BasicCoreProblems
{
	public class Factor
	{
		public static void Factors()
        {
            int n;

            Console.Write("Please enter a number to find its prime factors: ");
            string input = Console.ReadLine();

            if (!int.TryParse(input, out n) || n <= 1)
            {
                Console.WriteLine("Invalid input. N should be a positive integer greater than 1.");
                return;
            }

            Console.Write("The prime factors of {0} are: ", n);

            for (int i = 2; i * i <= n; i++)
            {
                while (n % i == 0)
                {
                    Console.Write("{0} ", i);
                    n /= i;
                }
            }

            if (n > 1)
            {
                Console.Write("{0}", n);
            }

            Console.WriteLine();
        }
    }
}

