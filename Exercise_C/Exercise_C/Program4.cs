using System;
namespace Exercise_C
{
	public class Program4
	{
		public static void Main(string[]args)
		{
			Console.Write("Enter distance in km: ");
			double km = Convert.ToDouble(Console.ReadLine());
			double fare = 0.0;

			km = Math.Ceiling(km * 10.0) / 10.0;

			if (km < 0)
			{
				Console.WriteLine("Invalid distance");
			}
			else if (km <= 0.5)
			{
				Console.WriteLine("Fare $2.4");
			}
			else if (km <= 9)
			{
				fare = ((km - 0.5) * 0.4) + 2.4;
				Console.WriteLine($"Fare ${fare:0.0}");
			}
			else {
				fare = ((km - 9) * 0.5) + (8.5 * 0.4) + 2.4;
				Console.WriteLine($"Fare ${fare:0.0}");
			}
		}
	}
}

