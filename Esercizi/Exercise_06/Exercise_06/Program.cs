using System;

namespace Exercise_06
{
	class Program
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Enter the first number");
			string FirstNumber = Console.ReadLine();
			Console.WriteLine ("Enter the second number");
			string SecondNumber = Console.ReadLine();
			int[] ArrFirst;
			int[] ArrSecond;
			int [] Sum;
			bool marker = true;
			if (FirstNumber.Length >= SecondNumber.Length) 
			{
				Sum = new int[FirstNumber.Length];
				ArrFirst = new int[FirstNumber.Length];
				ArrSecond = new int[FirstNumber.Length];

			} 
			else 
			{
				Sum = new int[SecondNumber.Length];
				ArrFirst = new int[SecondNumber.Length];
				ArrSecond = new int[SecondNumber.Length];
				marker = false;
			}
			StringToArray (FirstNumber, ArrFirst, SecondNumber);
			StringToArray (SecondNumber, ArrSecond, FirstNumber);
			ArrSum (Sum, ArrFirst, ArrSecond, marker);

			Console.Write ("Their sum is:\t");
			if (marker) 
			{
				for (int i = 0; i <= FirstNumber.Length - 1; i++) 
				{
					Console.Write ("{0}", Sum [i]);
				}
			} 
			else 
			{
				for (int i = 0; i <= SecondNumber.Length -1; i++) 
				{
					Console.Write ("{0}", Sum [i]);
				}
			}
		}

		public static  void StringToArray (string Number, int [] Array, string Other)
		{
			for (int i = 0; i < Number.Length; i++)
			{
				Array[i] = Number[i] - '0';
			}
		}

		public static int [] ArrSum (int [] sum, int [] arr1, int [] arr2, bool m)
		{
			int Resto = 0;
			if (m) {
				for (int i = 0; i < arr2.Length; i++) 
				{
					if ((arr1 [i] + arr2 [i] + Resto) > 9) 
					{
						sum [i] = ((arr1 [i] + arr2 [i]) % 10);
						sum [i - 1] = sum [i - 1] + 1;
						Resto = 1;
					} 
					else 
					{
						sum [i] = ((arr1 [i] + arr2 [i]) % 10);
						Resto = 0;
					}                
				}
				for (int j = arr2.Length; j < arr1.Length; j++) {
					sum [j] = ((arr1 [j]) % 10);
				}
			} 
			else 
			{
				for (int i = 0; i < arr1.Length; i++) 
				{
					if ((arr1 [i] + arr2 [i] + Resto) > 9) 
					{
						sum [i] = ((arr1 [i] + arr2 [i]) % 10);
						sum [i - 1] = sum [i - 1] + 1;
						Resto = 1;
					} 
					else 
					{
						sum [i] = ((arr1 [i] + arr2 [i]) % 10);
						Resto = 0;
					}                
				}
				for (int j = arr1.Length; j < arr2.Length; j++) 
				{
					sum [j] = ((arr2 [j]) % 10);
				}
			}
			//if (Resto == 1) 
			//	sum[sum.Length + 1] = sum[sum.Length + 1] + 1;     
			return sum;
		}
	}
}
