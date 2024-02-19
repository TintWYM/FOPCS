using System;
namespace Exercise_B
{
	public class Program5
	{
		public static void Main(string[]args)
		{
			Console.Write("Enter the value of x: ");
			int x = Convert.ToInt32(Console.ReadLine());
			double sqr = Math.Pow(x,2);
			double y = 5 * sqr - 4 * x + 3;
			Console.WriteLine("Output value of y is: " + y);
		}
	}
}

