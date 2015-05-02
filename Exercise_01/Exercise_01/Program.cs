using System;

namespace Exercise_01
{
	class MainClass
	{
		
		// cancellato il main
		
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
