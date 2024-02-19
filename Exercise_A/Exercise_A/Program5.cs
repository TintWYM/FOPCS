using System;
namespace Exercise_A
{
	public class Program5
	{
		public static void Main()
		{
			Console.Write("Enter double value:");
			double num = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine($"{num:0.00}");
		}
	}
}

