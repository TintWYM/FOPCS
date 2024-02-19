using System;
namespace Exercise_B
{
	public class Program9
	{
		public static void Main(string[]args)
		{
            Console.Write("Input is: ");
            double km = Convert.ToDouble(Console.ReadLine());
            double fare = 2.4 + km * 0.4;
            double fare_up = Math.Ceiling(fare * 100.0) / 100.0;
            Console.WriteLine("Output is: " + $"{fare_up:0.0}");
        }
	}
}

