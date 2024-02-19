using System;

namespace Exercise_C {
    public class Program {
        public static void Main(string[] args) {
            Console.Write("Enter your name: ");
            string name=Console.ReadLine();
            Console.Write("Enter your gender: ");
            string gender = Console.ReadLine();

            if (gender == "M")
            {
                Console.WriteLine("Good Morning Mr.{0}", name);
            }
            else if (gender == "F")
            {
                Console.WriteLine("Good Morning Mrs.{0}", name);
            }
            else {
                Console.WriteLine("Try again!");
            }
               
        }
    }
}