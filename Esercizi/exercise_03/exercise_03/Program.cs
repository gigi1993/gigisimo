using System;

namespace exercise_03
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int user_choice;
			Console.WriteLine ("Press\t1 to reverse a number\n\t2 for calculate the average of a sequence\n\t3 for solve a linear equation");
			user_choice = int.Parse(Console.ReadLine());
			switch (user_choice)
			{
			case 1:
				Reverse();
				break;
			case 2:
				Average();
				break;
			case 3:
				Equation();
				break;
			default:
				Console.WriteLine ("Invalid choice.");
				break;
			}
		}
		static void Reverse()
		{
			long number_to_reverse;
			string string_to_reverse, reversed_string;
			Console.WriteLine ("Enter the number to reverse");
			number_to_reverse = long.Parse(Console.ReadLine());
			while (number_to_reverse < 0 || number_to_reverse > 50000000) {
				Console.WriteLine ("Invalid number! It must be from 1 to 50,000,000.");
				Console.WriteLine ("Enter the number to reverse");
				number_to_reverse = int.Parse(Console.ReadLine());
			}
			string_to_reverse = number_to_reverse.ToString();
			reversed_string = null;
			for (int j = string_to_reverse.Length - 1; j >= 0; j--){
				reversed_string = reversed_string + string_to_reverse[j];
			}
			Console.WriteLine ("The reverse number is "+reversed_string);
		}

		static void Average()
		{
			int size, sum=0;
			double average;
			Console.WriteLine ("Enter the the lenght of the sequence");
			size = int.Parse(Console.ReadLine());
			while (size < 1) {
				Console.WriteLine ("Invalid number, it must be a positive integer");
				Console.WriteLine ("Enter the the lenght of the sequence");
				size = int.Parse(Console.ReadLine());
			}
			int[] sequence = new int[size];
			for (int j = 0; j < size; j++){
				Console.WriteLine ("Enter a number ({0}/{1})",j+1,size);	
				sequence[j] = int.Parse(Console.ReadLine());
			}
			for (int j =0;j<size;j++){
				sum += sequence[j];
			}
			average = (double)(sum / size);
			Console.WriteLine("The average is "+average);
		}
		static void Equation()
		{
			int coefficient_a, coefficient_b;
			Console.WriteLine ("ax+b=0\nEnter the coefficient 'a'");
			coefficient_a = int.Parse(Console.ReadLine());
			double solution;
			while (coefficient_a == 0){
				Console.WriteLine ("Invalid number, it must be non-zero");
				Console.WriteLine ("Enter the coefficient 'a'");
				coefficient_a = int.Parse(Console.ReadLine());
			}
			Console.WriteLine ("Enter the coefficient 'b'");
			coefficient_b = int.Parse(Console.ReadLine());
			if (coefficient_b == 0)
				solution = 0;
			else
				solution = -1 * coefficient_b / coefficient_a;
			Console.WriteLine("The solution is "+solution);
		}
	}
}