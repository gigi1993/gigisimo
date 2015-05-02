using System;

namespace Exercise_01
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int size, position;
			Console.WriteLine ("Enter the size of the array");										// initialization of the array
			size = int.Parse (Console.ReadLine ());
			int[] numbers = new int[size];
			for (int j = 0; j < size; j++){
				Console.WriteLine ("Enter a number ({0}/{1})",j+1,size);
				numbers[j] = int.Parse(Console.ReadLine());
			}
			Console.WriteLine ("Enter the position you want to check (from 0 to {0})",size-1);		// position to check
			position = int.Parse(Console.ReadLine());
			while (position < 0 || position > size-1) {
				Console.WriteLine ("Enter the position you want to check (from 0 to {0})",size-1);	// check for a valid position
				position = int.Parse(Console.ReadLine());
			}
			bool is_greater = GreaterThanNeighbours(numbers ,position);									// invoke the method
			Console.WriteLine(is_greater);
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
