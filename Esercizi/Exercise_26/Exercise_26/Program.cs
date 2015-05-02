using System;

namespace Exercise_26
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine ("Enter a text, I'll look for any palindrome inside:");
			string  text = Console.ReadLine();
			char[] splitters = new char[] { ' ', '.', ','};
			string[] words = text.Split(splitters,StringSplitOptions.RemoveEmptyEntries);
			Console.WriteLine("The following words are palindromes:");
			for (int i = 0; i < words.Length; i++)
			{
				if (Palin(words[i]))
				{
					Console.WriteLine (words [i]);
				}
			}
		}

		static bool Palin(string ispal)
		{
			for (int i = 0; i < ispal.Length/2; i++)
			{
				if (ispal[i]==ispal[ispal.Length - 1 - i])
				{
					continue;
				}
				else
				{
					return false;
				}
			}
			return true;
		}
	}
}