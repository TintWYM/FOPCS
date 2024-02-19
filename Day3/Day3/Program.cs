using System;

namespace Day3 {
    public class Program {
        public static void Main(string[] args) {
            const double gadget = 500;

            Console.WriteLine("Welcome to ISS Gadget Shop");
            Console.Write("Number of items to purchase: ");

            int quantity = Convert.ToInt32(Console.ReadLine());

            double total = quantity * gadget;
            double discount = 0;

            if (total > 2000 && total <= 3000) {
                discount = 0.03;
            } else if (total > 3000 && total <= 6000) {
                discount = 0.05;
            } else if (total > 6000)
            {
                discount = 0.08;
            }

            double discountAmount = total * discount;
            double discountPrice = total - discountAmount;

            Console.WriteLine("Please pay " + "$" + $"{discountPrice:0,0.00}");
        }
    }
}