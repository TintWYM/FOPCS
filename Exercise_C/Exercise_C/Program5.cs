using System;
namespace Exercise_C
{
	public class Program5
	{
		public static void Main(string[]args)
		{
			Console.Write("Enter three digit number: ");
			int num = Convert.ToInt32(Console.ReadLine());

			int i = num / 100;
			int j = (num % 100) / 100;
			int k = (num % 100) / 10;

			int x = Convert.ToInt32(Math.Pow(i, 3) + Math.Pow(j, 3) + Math.Pow(k, 3));

			if (num == x)
			{
				Console.WriteLine("True");
			}
			else {
				Console.WriteLine("False");
			}
		}
	}
}

