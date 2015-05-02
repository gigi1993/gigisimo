using System;
using System.Text;

namespace Exercise_29
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine("Enter the text to analyze");
			string text = Console.ReadLine();
			StringBuilder correct_text = new StringBuilder();
			char letter = text[0];
			correct_text.Append(text[0]);
			for (int i = 0; i < text.Length; i++){
				if (letter == text[i])
					continue;
				else{
					correct_text.Append(text[i]);
					letter = text[i];
				}
			}
			correct_text.ToString();
			Console.WriteLine(correct_text);
		}
	}
}