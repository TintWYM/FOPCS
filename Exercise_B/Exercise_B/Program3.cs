using System;
using System.Globalization;

namespace Exercise_B
{
	public class Program3
	{
		public static void Main(string[]args)
		{
			Console.Write("Enter salary: ");
			double salary = Convert.ToDouble(Console.ReadLine());
			double housing = 0.1 * salary;
			double trans = 0.03 * salary;
			double total = salary + housing + trans;
			Console.WriteLine("$"+$"{total:#,###.00}");
		}
	}
}

