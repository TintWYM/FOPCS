using System;
namespace Exercise_B
{
	public class Program6
	{
		public static void Main(string[]args)
		{
			Console.Write("Enter x1: ");
			double x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter x2: ");
            double x2 = Convert.ToDouble(Console.ReadLine());
			Console.Write("Enter y1: ");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter y2: ");
            double y2 = Convert.ToDouble(Console.ReadLine());
			double distance = Math.Sqrt(Math.Pow(x2-x1,2) + Math.Pow(y2-y1,2));
			Console.WriteLine("Distance is:" + distance);
        }
	}
}

