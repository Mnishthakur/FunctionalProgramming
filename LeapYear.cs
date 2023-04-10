using System;
namespace BasicCoreProblems
{
	internal class LeapYear
	{

		public static void LeapYearOrNot()

		{
            int year;
            bool isLeapYear;

            Console.WriteLine("Enter 4 digit number");
            string input = Console.ReadLine();

			if(!int.TryParse(input, out year) || input.Length != 4)


            {
                Console.WriteLine("Invalid input. Please enter only 4 digits");
				return;


			}
			isLeapYear = (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0));

			if (isLeapYear)
			{
				Console.WriteLine("{0} is a Leap year", year);
				
			}
			else
			{
				Console.WriteLine("{0} is not a Leap year", year);
			}
		}
	}
}

