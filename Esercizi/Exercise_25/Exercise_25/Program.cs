using System;
using System.Text.RegularExpressions;

namespace Exercise_25
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Enter a text");
			string text = Console.ReadLine();
			string[] words = text.Split(' ');

			for (int j= 0; j < words.Length; j++)
			{
				if (CheckEMailAdress(words[j]))
				{
					Console.WriteLine(words[j]);
				}
			}
		}

		static bool CheckEMailAdress(string email_address)
		{
			Regex reStrict = new Regex(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");

			bool is_an_adress = reStrict.IsMatch(email_address);

			return is_an_adress;
		}
	}
}