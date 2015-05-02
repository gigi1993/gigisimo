using System;

namespace Exercise_22
{
	class MainClass
	{
		static void Main(string[] args)
		{
			string str = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
			int startindex = 0;
			int endindex = 0;
			while (startindex < str.LastIndexOf("<upcase>"))
			{
				startindex = str.IndexOf("<upcase>", startindex + 1);
				endindex = str.IndexOf("</upcase>", endindex + 1);
				string upped = str.Substring(startindex + 8, endindex - startindex - 8).ToUpper();
				string tobereplaced = str.Substring(startindex, endindex - startindex + 9);
				str = str.Replace(tobereplaced, upped);
			}
			Console.WriteLine(str);
		}
	}
}