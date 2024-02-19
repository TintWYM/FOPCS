using System;

namespace Exercise_H {
    public class Program_1 {
        public static void Main(string[] args) {

            int n = ReadInteger("Enter Number: ");
            Console.WriteLine("Your number is " + n);
        }

        private static int ReadInteger(string msg) {
            int n;
            string s = "";

            while (true) {
                Console.Write(msg);

                s = Console.ReadLine();

                try
                {
                    n = Convert.ToInt32(s);
                    return n;
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Not a valid number!");
                }
                catch (FormatException) {
                    Console.WriteLine("Valid Number!");
                }
            }
        }
    }
}