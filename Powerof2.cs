using System;
namespace BasicCoreProblems
{
	internal class Power
	{
		public static void Powerof2()
		{
			Console.WriteLine("Enter a value:");
			int N = Convert.ToInt32(Console.ReadLine());
			int result = 1;
			for(int i=1; i <N; i++)
			{
				result *= 2;
			}
			Console.WriteLine(result);
		}
	}
}

