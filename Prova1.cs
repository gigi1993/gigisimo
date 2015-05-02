using System;

namespace Exercise_07
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			int n;
			Console.Write("Enter n");
			n = int.Parse(Console.ReadLine());
			int[] cnt = new int[n];
			Loop(n, 0, cnt);
		}
		static void Loop(int n,int index,int[] counter)
		{
			if (index == n){
				for (int j = 0; j < n; j++){
					Console.Write(counter[j]);
					if (j < n - 1) {
						Console.Write(" ");
					}
				}
				Console.WriteLine();
				return;
			} else {
				for (int j = 1; j <= n; j++){
					counter[index] = j;
					Loop(n, index + 1, counter);
				}
			}
		}
	}
}
