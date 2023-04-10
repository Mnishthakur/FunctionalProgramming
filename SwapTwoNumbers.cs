using System;
namespace BasicCoreProblems
{
	public class SwapTwoNumbers
	{
		public static void SwapNumbers()
		{
			int a;
			int b;

			Console.WriteLine("Enter 1st Number");
			string ainput = Console.ReadLine();

			Console.WriteLine("Enter 2nd Number");
			string binput = Console.ReadLine();

            if (!int.TryParse(ainput, out a) || !int.TryParse(binput, out b))
            {
                Console.WriteLine("Invalid input. Both inputs should be integers.");
                return;
            }

			int temp = a;
			a = b;
			b = temp;

			Console.WriteLine("After Swapping");
			Console.WriteLine("1st Number={0}", a);
			Console.WriteLine("2nd Number={0}", b);

        }
	}
}

