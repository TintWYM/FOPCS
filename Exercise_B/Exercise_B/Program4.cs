using System;
namespace Exercise_B
{
	public class Program4
	{
		public static void Main(string[]args)
		{
			Console.Write("Enter centigrade: ");
			double C = Convert.ToDouble(Console.ReadLine());
			double F = (1.8 * C) + 32;
			Console.WriteLine("Temperature in Fahrenheit is: " + F);
		}
	}
}

