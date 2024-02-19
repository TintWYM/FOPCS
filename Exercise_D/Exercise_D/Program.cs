using System;

namespace Exercise_D {
    public class Program {
        public static void Main(string[] args) {
            Console.Write("Repeat till 88 appeared ");
            string s = "";

            while (s != "88") {
                s = Console.ReadLine();
            }

            Console.WriteLine("Lucky You......");
        }
    }
}