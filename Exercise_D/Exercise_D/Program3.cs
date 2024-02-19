using System;
namespace Exercise_D
{
	public class Program3
	{
		public static void Main(string[]args)
		{
			Console.Write("Guess number from 0 - 9 :");
			int num = 0, tries = 0;

			Random rnd = new Random();
			int randNum = rnd.Next(9);

			while (num != randNum)
			{
				if (tries != 0) {
					Console.WriteLine("Try again!");
				}

				num = Convert.ToInt32(Console.ReadLine());
				tries++;
			}

			if (tries <= 2)
			{
				Console.WriteLine("You are a wizard!");
			}
			else if (tries == 3)
			{
				Console.WriteLine("You are a good guess!");
			}
			else {
				Console.WriteLine("You are lousy!");
			}
		}
	}
}

