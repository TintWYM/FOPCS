using System;

namespace Day2 {

    public class Program {
        public static void Main(string[] args) {
            Console.Write("Please enter the length in cm: ");
            double cm = Convert.ToDouble(Console.ReadLine());
            double inch = cm / 2.54;
            Console.WriteLine($"{inch:0.000}");
        }
    }
}