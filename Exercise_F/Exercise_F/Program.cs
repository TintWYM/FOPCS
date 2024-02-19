using System;

namespace Exercise_F {
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Count vowels! Enter string: ");

            String s = Console.ReadLine();

            String vowels = "aeiou";

            int[] count = new int[5];

            s = s.ToLower();

            for (int i = 0; i < s.Length; i++)
            {
                for (int j = 0; j < vowels.Length; j++)
                {
                    if (s[i] == vowels[j])
                    {
                        count[j]++;
                    }
                }
                for (int j = 0; j < vowels.Length; j++)
                {
                    Console.WriteLine("Number of " + vowels[j] + " : " + count[j]);
                }
            }
        }
    }
            
}