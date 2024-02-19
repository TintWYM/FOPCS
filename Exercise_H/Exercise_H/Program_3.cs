using System;
namespace Exercise_H
{
	public class Program_3
	{
		public static void Main(string[] args) {
			Console.WriteLine("Substitue()");

			string s = "Happy";

			s = Substitue(s, 'p', 'b');
		}

		private static string Substitue(string s, char c1, char c2) {
			string s2 = s.Replace(c1,c2);

			return s2;
		}
	}
}

