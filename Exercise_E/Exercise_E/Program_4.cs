using System;
namespace Exercise_E
{
	public class Program_4
	{
		public static void Main(string[]args)
		{
			Console.Write("Enter number: ");
			int x = Convert.ToInt32(Console.ReadLine());

            if (Perfect(x))
            {
                Console.WriteLine("Perfect");
            }
            else {
                Console.WriteLine("Not Perfect");
            }
		}

		private static bool Perfect(int n) {
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

