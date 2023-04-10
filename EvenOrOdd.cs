using System;
namespace BasicCoreProblems
{
	public class EvenOrOdd
	{
		public static void EvenOdd()
		{
            int num;

            Console.Write("Enter a number: ");
            string numInput = Console.ReadLine();

            if (!int.TryParse(numInput, out num))
            {
                Console.WriteLine("Invalid input. The input should be an integer.");
                return;
            }

            if (num % 2 == 0)
            {
                Console.WriteLine("{0} is an even number.", num);
            }
            else
            {
                Console.WriteLine("{0} is an odd number.", num);
            }
        }
    }
}

