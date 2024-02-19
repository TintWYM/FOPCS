using System;
namespace Exercise_F
{
	public class Program_2
	{
		public static void Main(string[]args)
		{
			Console.Write("Enter a string: ");

			string s = Console.ReadLine();

			if (isPalindrome(s))
			{
				Console.WriteLine($"{s} is a palindrome.");
			}
			else {
				Console.WriteLine($"{s} is not a palindrome.");
			}

			static bool isPalindrome(string str) {
				int i = 0;
				int j = str.Length - 1 ;

				while (i < j) {
					if (str[i] != str[j]) {
						return false;
					}
					i++;
					j--;
                }
				return true;
			}
		}
	}
}

