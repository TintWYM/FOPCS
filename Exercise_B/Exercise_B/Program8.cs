using System;
namespace Exercise_B
{
	public class Program8
	{
		public static void Main()
		{
			Console.Write("Input is: ");
            double km = Convert.ToDouble(Console.ReadLine());
            double fare = 2.4 + km * 0.4;
            double fare_down = Math.Round(fare, 1);
			Console.WriteLine("Output is: " + $"{fare_down:0.00}");
			
		}
	}
}

