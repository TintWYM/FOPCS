using System;

namespace Exercise_E
{
	public class Program_3
	{
		public static void Main(string[] args) {
			Console.Write("Enter a number that is a prime number or not: ");

			int j = Convert.ToInt32(Console.ReadLine());

			if (j <= 0)
			{
				Console.WriteLine("Invalid Number");
			}
			else {
                if (Prime(j))
                {
                    Console.WriteLine("It is prime");
                }
                else {
                    Console.WriteLine("It is not prime");
                }
            }
		}

        private static bool Prime(int x)
        {
            if (x == 1 || x == 2)
            {
                return true;
            }

            for (int i = 2; i <= x/2; i++)
            {
                if (x % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

    }
}

