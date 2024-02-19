using System;
namespace Exercise_A
{
	public class Program4
	{
		public static void Main() {
			Console.Write("Please enter double :");
			double num = Convert.ToDouble(Console.ReadLine());
			double sqr = Math.Pow(num, 2);
			Console.WriteLine("Square of {0} is: {1}", num, sqr);
        }
	}
}

