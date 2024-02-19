using System;
namespace Exercise_E
{
	public class Program_6
	{
		public static void Main(string[] args) {
			Console.Write("All perfect from 5 - 1000 ");

            for (int x = 5; x <= 1000; x++) {
                if (Perfect(x)) {
                    Console.WriteLine(x);
                }
            }
		}

        private static bool Perfect(int n)
        {
            if (n < 6)
            {
                return false;
            }

            int j = 0;

            for (int i = 1; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    j += i;
                }
            }

            if (n == j)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

