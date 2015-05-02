using System;

namespace Exercise_02
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int size, pos;
			Console.WriteLine ("Enter the size of the array");										// initialization of the array
			size = int.Parse (Console.ReadLine ());
			int[] numbers = new int[size];
			for (int j = 0; j < size; j++)
			{
				Console.WriteLine ("Enter a number ({0}/{1})",j,size-1);
				numbers[j] = int.Parse(Console.ReadLine());
			}
			pos = GreaterPosition (numbers, size);
			Console.WriteLine("the number in the position {0} ({1}) is greater then his neighbours", pos, numbers[pos]);

		}

		static int GreaterPosition (int[] Arr, int s)
		{
			for (int i = 0; i < s; i++)
			{
				bool is_greater = GreaterThanNeighbours(Arr ,i);								// invoke the method
				if (is_greater) {
					return i;
				}
			}
			return -1;
		}

		static bool GreaterThanNeighbours(int[] array,int p)									// method
		{
			if (array.Length == 1) {																// if there is just one element
				return true;
			} else if (p > 0 && p < array.Length - 1) {								// if the position in in the middle of the array
				int number = array [p];
				int prev_number = array [p - 1];
				int next_number = array [p + 1];
				if (number > prev_number && number > next_number)									// compare to previous element
					return true;
			} else if (p == 0) {																// if the position is the first
				int number = array [p];
				int next_number = array [p + 1];
				if (number > next_number)
					return true;
			} else if (p == array.Length - 1) {												// if the position is the last
				int number = array [p];
				int prev_number = array [p - 1];
				if (number > prev_number)
					return true;
			}
			return false;
		}
	}
}
