using System;

namespace Exercise_30
{
	class Program
	{
		static void Main (string[] args)
		{
			Console.WriteLine ("Enter a text separated by commas");
			string text = Console.ReadLine ();
			string[] words = text.Split (',');
			Array.Sort (words);
			for (int i = 0; i < words.Length; i++) 
			{
				Console.WriteLine (words [i]);
			}
		}
	}
}