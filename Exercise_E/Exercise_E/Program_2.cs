using System;
namespace Exercise_E
{
	public class Program_2
	{
		public static void Main(string[]args)
		{
			Console.WriteLine("Print number between 1 - 10 inverse ");
            Console.WriteLine("No\tInverse\t\tSqrt\tSquare");
            Console.WriteLine("=========================================================");

			for (double i = 1; i <= 10; i++) {
				Console.WriteLine($"{i:F1}\t\t{1 / i:F3}\t\t{Math.Sqrt(i):F3}\t\t{Math.Pow(i, 2):F2}");
			}
		}
	}
}

