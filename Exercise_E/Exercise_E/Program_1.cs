using System;

namespace Exercise_E {
    public class Program_1 {
        public static void Main(string[] args) {
            Console.Write("Enter Number: ");

            int n = Convert.ToInt32(Console.ReadLine());

            int fact1 = 1, fact2 = n;

            if (n < 0)
            {
                Console.WriteLine("Invalid Number");
            }
            else if (n == 0 || n == 1)
            {
                fact1 = 1;
                fact2 = 1;
            }
            else {
                for (int i = 1; i < n; i++) {
                    fact1 = fact1 * (i + 1);
                }
                for (int i = n; i > 1; i--) {
                    fact2 = fact2 * (i - 1);
                }
            }

            Console.WriteLine("Fact1 is: " + fact1 + "\n" + "Fact2 is: " + fact2);
        }
    }
}