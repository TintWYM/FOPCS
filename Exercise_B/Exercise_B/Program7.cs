using System;
namespace Exercise_B
{
	public class Program7
	{
		public static void Main(string[]args)
		{
			Console.Write("Input Taxi fare in km: ");
			double km = Convert.ToDouble(Console.ReadLine());
			double fare = 2.4 + km * 0.4;
			Console.WriteLine("Total fare is: " + fare);
		}
	}
}

