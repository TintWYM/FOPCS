using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Exercise_A
{
	public class Program3
	{
		public static void Main() {
			Console.Write("Please input integer: ");
			int num = Convert.ToInt16(Console.ReadLine());
			double sqr = Math.Pow(num, 2);
			Console.WriteLine("Square of {0} is: {1}", num, sqr);
		}
	}
}