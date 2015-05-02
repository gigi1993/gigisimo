using System;

namespace Exercise_09
{
	class MainClass
	{
		static int k;
		static int n;
		static string[] given_strings;
		static void CalculateCombinations(int index, int[] vector, int added)
		{
			if (index == k){
				foreach (int i in vector)
					Console.Write("{0} ", given_strings[i]);
				Console.WriteLine();
				return;
			}
			for (int i = 0; i < n; i++){
				if (i > added){
					vector[index] = i;
					CalculateCombinations(index + 1, vector, i);
				}
			}

		}
		public static void Main (string[] args)
		{
			Console.WriteLine ("Enter n");
			n=int.Parse(Console.ReadLine());
			given_strings=new string[n];
			for (int i = 0; i < n; i++){
				Console.WriteLine ("Enter a string");
				given_strings[i]=Console.ReadLine();
			}
			Console.WriteLine ("Enter k");
			k = int.Parse(Console.ReadLine());
			int[] combinations = new int[k];
			CalculateCombinations(0, combinations, -1);
		}

	}
}