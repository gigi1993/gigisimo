using System;

namespace Exercise_04
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Enter the order of the first polynomial");

			int order1 = int.Parse (Console.ReadLine ()) + 1;
			int[] Pol1 = new int[order1];
			for (int i = 0; i < order1; i++) {
				Console.WriteLine ("Enter the coefficent of X^{0}", i);
				Pol1 [i] = int.Parse (Console.ReadLine ());
			}
			Console.WriteLine ("Enter the order of the second polynomial");
			int order2 = int.Parse (Console.ReadLine ()) + 1;
			int[] Pol2 = new int[order2];
			for (int i = 0; i < order2; i++) {
				Console.WriteLine ("Enter the coefficent of X^{0}", i);
				Pol2 [i] = int.Parse (Console.ReadLine ());
			}
			int[] PolS = Sum (Pol1, Pol2);
			Console.WriteLine ("The sum of the two polynomials is:");
			for (int i = 0; i < PolS.Length; i++) {
				Console.Write ("{0}X^{1} ", PolS[i], i);
			}

		}

		static int [] Sum (int [] p1, int [] p2)
		{
			int Ord1 = p1.Length;
			int Ord2 = p2.Length;
			int k = 0;
			int n = 0;
			bool flag;
			if (Ord1 >= Ord2) {
				k = Ord2;
				n = Ord1;
				flag = true;
			} 
			else 
			{
				k = Ord1;
				n = Ord2;
				flag = false;
			}
			int [] S = new int[n];
			for (int i = 0; i < k; i++) {
				S [i] = p1 [i] + p2 [i];
			}
			if (flag)
			{
				for (int j = k; j < n; j++)
				{
					S[j] = p1[j];
				}
			}
			else
			{
				for (int j = k; j < n; j++)
				{
					S[j] = p2[j];
				}
			}
			return S;
		}
	}
}
