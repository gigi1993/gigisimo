using System;

namespace Exercise_11
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			double first_cathetus, second_cathetus, huypotenuse;
			Console.WriteLine ("Enter the first cathetus");
			first_cathetus= int.Parse(Console.ReadLine());
			Console.WriteLine ("Enter the second cathetus");
			second_cathetus= int.Parse(Console.ReadLine());
			while (first_cathetus <= 0 || second_cathetus <= 0)
			{
				Console.WriteLine("Incorrect data");
				Console.WriteLine ("Enter the first cathetus");
				first_cathetus= int.Parse(Console.ReadLine());
				Console.WriteLine ("Enter the second cathetus");
				second_cathetus= int.Parse(Console.ReadLine());
			}
			huypotenuse = ApplyPithagoras (first_cathetus, second_cathetus);
			Console.WriteLine(huypotenuse);
		}
		static double ApplyPithagoras (double first_side, double second_side){
			double third_side = Math.Sqrt (Math.Pow (first_side, 2) + Math.Pow (second_side, 2));
			return third_side;
		}
	}
}