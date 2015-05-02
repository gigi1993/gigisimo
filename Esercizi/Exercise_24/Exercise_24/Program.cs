using System;
using System.Text;
namespace Exercise_24
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine ("Enter the chiper:");
			string chiper = Console.ReadLine();
			Console.WriteLine ("Enter the text:");
			string text = Console.ReadLine();
			StringBuilder coded = new StringBuilder();
			for (int i = 0; i < text.Length; i++)
			{
				if (i == 0)
				{
					coded.AppendFormat("\\u{0:x4}", text[i]^chiper[i]);
				}
				else
					coded.AppendFormat("\\u{0:x4}", text[i]^chiper[i % chiper.Length]);
			}
			coded.ToString();
			Console.Write ("The encoded text is: ");
			Console.Write(coded);
		}
	}
}