using System;

namespace Exercise_G {
    public class Program {
        public static void Main(string[] args) {
            Console.Write("Monthly Sales");
            int[] sales = { 23, 22, 126, 47, 96, 10, 231, 2334, 728, 59, 124, 756 };
            int max = sales[0],min = sales[0];

            int highest = 0, lowest = 0, sum = 0;

            for (int i = 0; i < sales.Length; i++) {
                if (sales[i] > max) {
                    max = sales[i];
                    highest = i;
                }

                if (sales[i] < min) {
                    min = sales[i];
                    lowest = i;
                }
                sum += sales[i];
            }

            Console.WriteLine("Month with max values " + highest);
            Console.WriteLine("Month with min values " + lowest);
            Console.WriteLine("Average mwith monthly sales " + sum / 12);
        }
    }
}