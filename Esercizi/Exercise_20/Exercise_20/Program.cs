using System;

namespace Exercise_20
{
	class Program
	{
		static void Main (string[] args)
		{
			Console.WriteLine ("Enter a text separated by backslashes (\\)");
			string text = Console.ReadLine ();
			string[] words = text.Split ('\\');
			for (int i = 0; i < words.Length; i++) 
			{
				Console.WriteLine (words [i]);
			}
		}
	}
}
