using System;
namespace Exercise_D
{
	public class Program2
	{
		public static void Main(string[]args)
		{
			Console.WriteLine("LCM and HCF for 2 integer ");
			int a = 0, b = 0, lcm = 0, a1, b1;

            Console.Write("Enter int a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter int b: ");
            b = Convert.ToInt32(Console.ReadLine());

			a1 = a;
			b1 = b;

			while (a != b) {
				if (a > b)
				{
					a -= b;
				}
				else {
					b -= a;
				}
			}

			lcm = (a1 * b1) / a;

			Console.WriteLine("A: " + a1 + " B: " + b1 + " HCF: " + a + " LCM: " + lcm);
        }
	}
}

