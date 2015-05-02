using System;

namespace Exercise_21
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Enter the text to analyze:");
			string text = Console.ReadLine();
			Console.WriteLine ("Enter the substring to search:");
			string substring = Console.ReadLine();
			int counter = SearchSubstring (text, substring);
			Console.WriteLine("The substring occurs {0} times", counter);
		}
		static int SearchSubstring (string a, string b)
		{
			string current_word = string.Empty;
			int cnt = 0;
			for (int i = 0; i < a.Length; i++){
				current_word += a[i];
				if (current_word.Length == b.Length){
					if (current_word.ToLower() == b.ToLower())
						cnt++;
					current_word = string.Empty;
					current_word += a[i];
				}
			}
			return cnt;
		}
	}
}