using System;
namespace Exercise_C
{
	public class Program3
	{
		public static void Main(String[]args)
		{
			Console.Write("Enter your mark: ");
			int marks = int.Parse(Console.ReadLine());

			if (marks >= 0 && marks < 40)
			{
				Console.WriteLine("F");
			}
			else if (marks >= 40 && marks < 60)
			{
				Console.WriteLine("C");
			}
			else if (marks >= 60 && marks < 80)
			{
				Console.WriteLine("B");
			}
			else if (marks >= 80 && marks < 100)
			{
				Console.WriteLine("A");
			}
			else {
				Console.WriteLine("Error");
			}
		}
	}
}

