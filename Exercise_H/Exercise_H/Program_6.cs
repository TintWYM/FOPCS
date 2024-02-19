using System;
namespace Exercise_H
{
	public class Program_6
	{
		public static void Main(string[] args) {
			for (int j = 0; j < 100; j++) {
				Console.WriteLine("{0} is a prime number.");
			}
		}

		public static bool IsPrime(int n) {
			bool prime = false;

			if (n <= 1)
			{
				return false;
			}
			else {
				for (int i = 2; i < n; i++) {
					if (n % i == 0) {
						return false;
					}
				}

				return true;
			}
		}
	}
}

