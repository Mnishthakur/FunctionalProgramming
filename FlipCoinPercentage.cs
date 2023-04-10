using System;
namespace BasicCoreProblems
{
	internal class FlipCoinPercentage
	{
        public static void Coin()
        {
            int numFlips = 100;
            int numHeads = 0;
            Random random = new Random();

            for (int i = 0; i < numFlips; i++)
            {
                if (random.NextDouble() < 0.5)
                {
                    numHeads++;
                }
            }

            int numTails = numFlips - numHeads;

            Console.WriteLine("Heads: {0:0.00}%", (numHeads / (double)numFlips) * 100);
            Console.WriteLine("Tails: {0:0.00}%", (numTails / (double)numFlips) * 100);
        }
    }
}


