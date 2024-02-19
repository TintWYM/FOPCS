using System;

namespace Exercise_B
{
	public class Program10
	{
		public static void Main(string[]args)
		{
			Console.Write("Enter A: ");
			int A = Convert.ToInt32(Console.ReadLine());
			Console.Write("Enter B: ");
			int B = Convert.ToInt32(Console.ReadLine());
			Console.Write("Enter C: ");
			int C = Convert.ToInt32(Console.ReadLine());

			int s = (A + B + C) / 2;

			if ((A * B * C) == 0) {
                Console.WriteLine("NaN");
            }
			else if ((A + B) < C || (A + C) < B || (B + C) < A)
			{
				Console.WriteLine("NaN");
			}
			else
			{
				double area = Math.Sqrt(s * (s - A) * (s - B) * (s - C));
				Console.WriteLine("Area of Triangle is: " + area);
			}
		}
	}
}

