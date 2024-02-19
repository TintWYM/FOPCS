using System;
using System.Text.RegularExpressions;

namespace Exercise_F
{
    public class Program_3
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter a string: ");

            string s = Console.ReadLine();

            if (isPalindrome(s))
            {
                Console.WriteLine($"{s} is a palindrome.");
            }
            else
            {
                Console.WriteLine($"{s} is not a palindrome.");
            }

            static bool isPalindrome(string str)
            {
                string cS = Regex.Replace(str, @"[^a-zA-Z0-9]", "").ToLower();

                int i = 0;
                int j = str.Length - 1;

                while (i < j)
                {
                    if (cS[i] != cS[j])
                    {
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

