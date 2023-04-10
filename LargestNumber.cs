using System;
namespace BasicCoreProblems
{
	public class LargestNumber
	{
		public static void Number()
		{
            {
                int num1, num2, num3;

                Console.Write("Enter the first number: ");
                num1 = int.Parse(Console.ReadLine());

                Console.Write("Enter the second number: ");
                num2 = int.Parse(Console.ReadLine());

                Console.Write("Enter the third number: ");
                num3 = int.Parse(Console.ReadLine());

                if (num1 > num2 && num1 > num3)
                {
                    Console.WriteLine("{0} is the largest number", num1);
                }
                else if (num2 > num1 && num2 > num3)
                {
                    Console.WriteLine("{0} is the largest number", num2);
                }
                else
                {
                    Console.WriteLine("{0} is the largest number", num3);
                }

                Console.ReadLine();
            }
        }
	}
}

