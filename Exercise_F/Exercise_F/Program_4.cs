using System;
namespace Exercise_F
{
	public class Program_4
	{
		public static void Main(string[]args)
		{
			Console.Write("Enter string: ");
			String s = Console.ReadLine();
			string[] ab = s.Split(' ');

			for (int i = 0; i < ab.Length; i++) {
				Console.Write(FirstToUpper(ab[i])+" ");
			}
		}

        private static string FirstToUpper(string s)
        {
            if (s.Length > 1)
                return char.ToUpper(s[0]) + s.Substring(1); // makes first char uppercase. returns first char + remaining substring

            return s.ToUpper(); // if only 1 character
        }
    }
}

