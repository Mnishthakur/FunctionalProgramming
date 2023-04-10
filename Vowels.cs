using System;
namespace BasicCoreProblems
{
	public class VowelsOrConsonent
	{
		public static void Vowels()
        {
            char ch;

            Console.Write("Enter an alphabet: ");
            string chInput = Console.ReadLine();

            if (!char.TryParse(chInput, out ch))
            {
                Console.WriteLine("Invalid input. The input should be a single alphabet.");
                return;
            }

            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' ||
                ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
            {
                Console.WriteLine("{0} is a vowel.", ch);
            }
            else
            {
                Console.WriteLine("{0} is a consonant.", ch);
            }
		}
	}
}

