using System;

namespace Exercise_08
{
	class Program
	{

		static int[] array;
		static int k;
		static int n;
		static void Main(string[] args)
		{
			Console.WriteLine ("Enter n:");
			n = int.Parse(Console.ReadLine());
			Console.WriteLine ("Enter k:");
			k = int.Parse(Console.ReadLine());
			array = new int[k];
			Nasted();
		}

		static void Nasted(int begin = 1, int current = 1)
		{
			for (int i = begin; i <= n; i++)
			{
				array[current - 1] = i;
				if (current < k)
				{
					Nasted(begin, current + 1);
					begin++;
				}
				else
				{
					PrintNumbers(array);
				}
			}
		}

		static void PrintNumbers(int[] arrtoprint)
		{
			for (int i = 0; i < arrtoprint.Length; i++)
			{
				Console.Write(arrtoprint[i] + " ");
			}
			Console.WriteLine();
		}
	}
}