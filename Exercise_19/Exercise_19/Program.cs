using System.Net;
using System;
using System.IO;

namespace Exercise_19
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			bool download;
			string uri = "http://upload.wikimedia.org/wikipedia/commons/8/83/Alice-white-rabbit.jpg";
			Console.WriteLine("This program download and image from the web");
			using(WebClient webClient = new WebClient())
			{
				try
				{
					Stream stream = webClient.OpenRead(uri);
					if (stream == null)
					{
						download = false;
					}
					else
					{
						download = true;
						webClient.DownloadFile(uri, "rabbit.jpg");
						Console.WriteLine("Download compleated!");
					}
				}
				catch 
				{
					download = false;
					Console.WriteLine("Error, url dosen't exist.");
				}
			}
		}
	}
}