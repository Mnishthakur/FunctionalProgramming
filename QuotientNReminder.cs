using System;
namespace BasicCoreProblems
{
	public class QuotientNReminder
	{
		public static void QuotientReminder()
		{
			
			int divident;
            int divisor;

            Console.WriteLine("Enter Divident");
			string dividentinput = Console.ReadLine();

			Console.WriteLine("EnterDivisor");
			string divisorinput = Console.ReadLine();

            if (!int.TryParse(dividentinput, out divident) || !int.TryParse(divisorinput, out divisor) || divisor == 0)
            {
                Console.WriteLine("Invalid input. The dividend and divisor should be integers, and the divisor should be non-zero.");
                return;
            }


            int quotient = divident / divisor;
            int remainder = divident % divisor;

            Console.WriteLine("The quotient of {0} divided by {1} is {2}.", divident, divisor, quotient);
            Console.WriteLine("The remainder of {0} divided by {1} is {2}.", divident, divisor, remainder);


        }
	}
}

