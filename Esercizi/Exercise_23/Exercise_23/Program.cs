using System;

namespace Exercise_23
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string word;
			Console.WriteLine ("Enter the world to analyze");
			word = Console.ReadLine();
			for (int j = 0; j < word.Length; j++){
				Console.Write("\\u{0:x4}", (ushort)word[j]);
			}
			Console.WriteLine();
		}
	}
}