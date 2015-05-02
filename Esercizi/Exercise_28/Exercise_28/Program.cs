using System;

namespace Exercise_28
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine ("Enter the text:");
			string text = Console.ReadLine();
			string[] words = text.Split(' ');
			int l = words.Length;
			Array.Sort (words);
			string[] countwords = new string[l];
			int[] cnt = new int[l];
			int differentwords = 0;
			for (int i = 0; i < l; i++)
			{
				for (int j = 0; j < l; j++)
				{
					if (countwords[j] == string.Empty || countwords[j] != words[i])
					{
						countwords[differentwords] = words[i];
						differentwords++;
						break;
					}
				}
			}
			for (int i = 0; i < l; i++)
			{
				for (int j = 0; j < l; j++)
				{
					if (countwords[j] == words[i])
					{
						cnt[j]++;
						break;
					}
				}
			}
			Print (differentwords, cnt, countwords);
		}

		static void Print (int number, int [] counter, string [] words)
		{
			for (int k = 0; k < number; k++) 
			{
				if (counter [k] != 0) 
				{
					Console.WriteLine ("{0} :\t{1}", words [k], counter [k]);
				}
			}
		}
	}
}
