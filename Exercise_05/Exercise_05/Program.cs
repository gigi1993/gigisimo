using System;

namespace Exercise_05
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int[] multiplicand = EnterAPolynomial();
			int[] multiplier = EnterAPolynomial();
			int[] result = Multiply(multiplicand, multiplier);
			for (int j = 0; j < result.Length; j++) {
				Console.Write ("{0}x^{1} ",result[j],j);
			}
		}
		static int[] EnterAPolynomial()
		{
			Console.WriteLine("Enter the degree");
			int degree = int.Parse(Console.ReadLine());
			int[] polynomial = new int[degree+1];
			for (int j=0; j <= degree; j++){
				Console.WriteLine ("Enter the coefficient a{0}",j);
				polynomial[j] = int.Parse(Console.ReadLine());
			}

			return polynomial;
		}
		static int[] Multiply(int[] first_polynomial, int[] second_polynomial)
		{
			int result_length = first_polynomial.Length + second_polynomial.Length - 1;
			int[] result = new int[result_length];

			for (int first_degree = 0; first_degree < first_polynomial.Length; first_degree++){
				for (int second_degree = 0; second_degree < second_polynomial.Length; second_degree++){
					int total_degree = first_degree + second_degree;
					int multiplier = first_polynomial[first_degree] * second_polynomial[second_degree];
					result[total_degree] += multiplier;
				}
			}

			return result;
		}
	}
}
