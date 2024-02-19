using System;

namespace Day4 {
    public class Program
    {
        public static void Main(string[] args)
        {
            const int pin = 123456;

            int attempts = 0;
            bool authenticated = false;

            while (attempts < 3)
            {
                Console.WriteLine("Welcome to the Bank of ISS!");
                Console.Write("Enter Your PIN: ");

                int enteredPIN = Convert.ToInt32(Console.ReadLine());
                if (enteredPIN == pin)
                {
                    authenticated = true;
                    break;
                }
                else {
                    attempts++;
                    Console.WriteLine("Incorrect PIN. Please try again.");
                }
            }

            if (authenticated)
            {
                Console.WriteLine("PIN accepted. You can access your account now.");
            }
            else {
                Console.WriteLine("Too many wrong PIN entries. Your account is now locked.");
            }
        }
    }
}