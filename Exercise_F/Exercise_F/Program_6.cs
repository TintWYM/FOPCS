using System;
namespace Exercise_F
{
	public class Program_6
	{
		public static void Main(string[] args) {
			Console.Write("Enter number: ");
			string matri = Console.ReadLine();

			if (IsValid(matri))
			{
				Console.WriteLine("Valid");
			}
			else {
				Console.WriteLine("Invalid");
			}
		}

		private static bool IsValid(string s) {

			int sum = 0;
			string checksum = "OPQRS";

			if (s.Length != 7) {
				return false;
			}

			s = s.ToUpper();

			for (int i = 1; i < s.Length - 1; i++) {
                sum += Convert.ToInt32(s[i]) * (s.Length - 1);
            }

			sum %= 5;

			if (s[6] != checksum[sum])
			{
				return false;
			}
			else {
				return true;
			}
		}
    }
}

