using System;
using System.IO;

namespace Exercise_17
{
	public class FileParseException : Exception 
	{
		public string FileName 
		{
			get; 
			private set; 
		}
		public long Row 
		{
			get; 
			private set; 
		}
		public string Message
		{
			get;
			private set;
		}
		public FileParseException(string message, string file_name, long row)
		{
			FileName = file_name;
			Row = row;
			Message = message;
		}
	}
	class MainClass
	{
		public static void Main (string[] args)
		{
			const string file_name = "file.txt";
			long row = 0;
			int lineInt = 0;
			StreamReader reader = new StreamReader(file_name);
			using(reader)
			{
				string line = reader.ReadLine();
				while (line != null)
				{
					row++;
					try
					{
						if(int.TryParse(line, out lineInt))
						{
							Console.WriteLine(lineInt);
						}
						else
						{
							throw new FileParseException("Parsing faild in file", file_name, row);
						}
					}
					catch (FileParseException fpe)
					{
						Console.WriteLine("{0} {1} on line {2}.", fpe.Message, fpe.FileName, fpe.Row); 
					}
					line = reader.ReadLine();
				}
			}
		}
	}
}