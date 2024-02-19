using System;
namespace Exercise_E
{
	public class Program_5
	{
		public static void Main(string[]args)
		{
            Console.Write("All prime from 5 - 10000 ");
            for (int x = 5; x <= 100; x++) {
                if (Prime(x))
                {
                    Console.WriteLine(x);
                }
            }
		}

        private static bool Prime(int x)
        {
            if (x == 1 || x == 2)
            {
                return true;
            }

            for (int i = 2; i <= x / 2; i++)
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

