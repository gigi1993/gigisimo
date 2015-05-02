using System;

namespace Esercizio_27
{
	class MainClass
	{
		static int[] cnt = new int[256];
		public static void Main (string[] args)
		{
			Console.WriteLine ("Enter the text to analyze");
			string text = Console.ReadLine();
			CountLetters (text);
			for (int i = 0; i < 256; i++){
				if (cnt[i] != 0)
					Console.WriteLine("{0} - {1}", (char)i, cnt[i]);
			}
		}
		static void CountLetters(string txt)
		{
			for (int i = 0; i < txt.Length; i++){
				for (int j = 0; j < 256; j++){
					if ((int)txt[i] == j)
						cnt[j]++;
				}
			}
		}
	}
}