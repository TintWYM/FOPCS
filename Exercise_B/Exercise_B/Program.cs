﻿using System;

namespace Exercise_B {
    public class Program {
        public static void Main(string[] args) {
            Console.Write("Enter double value: ");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Math.Sqrt(a);
            Console.WriteLine("Square root of " + a + " is: " + b);
        }
    }
}