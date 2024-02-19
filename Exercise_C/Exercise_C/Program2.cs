using System;
namespace Exercise_C
{
	public class Program2
	{
		public static void Main(string[] args) {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your gender: ");
            string gender = Console.ReadLine();
            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            if (gender == "M")
            {
                if(0 < age && age >= 40) {
                    Console.WriteLine("Good Morning Uncle {0}", name);
                }
                else {
                    Console.WriteLine("Good Morning Mr.{0}", name);
                }
            }
            else if (gender == "F")
            {
                if(0 < age && age >= 40) { 
                    Console.WriteLine("Good Morning Aunty {0}", name);
                }
                else
                {
                    Console.WriteLine("Good Morning Mrs.{0}", name);
                }
            }
            else
            {
                Console.WriteLine("Try again!");
            }
        }
	}
}

