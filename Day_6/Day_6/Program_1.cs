using System;namespace Day_6
{
    class Program_1
    {
        static int[] minIncomeArray = new int[] { 20000, 30000, 40000, 80000, 120000, 160000, 200000, 320000 };
        static double[] taxRateArray = new double[] { 0.02, 0.035, 0.07, 0.115, 0.15, 0.17, 0.18, 0.20 };
        static int[] basePayableAmountArray = new int[] { 0, 200, 550, 3350, 7950, 13950, 20750, 42350 };
        static void Main(string[] args)
        {
            int annualIncome = AskForIncome();
            int taxBracket = GetTaxBracket(annualIncome);
            double taxPayable = CalculateIncomeTax(annualIncome, taxBracket);
            PrintResult(annualIncome, taxPayable);
            return;
        }

        private static int AskForIncome() {
            Console.Write("Please enter your annual taxable income: ");
            int x = Convert.ToInt32(Console.ReadLine());
            return x;
        }

        private static int GetTaxBracket(int annualIncome) {
            for (int i = minIncomeArray.Length - 1; i >= 0; i--) {

                if (annualIncome >= minIncomeArray[i]) {
                    return i;
                }
            }
            return -1;
        }

        private static double CalculateIncomeTax(int annualIncome, int taxBracket) {
            double tax = 0;

            if (taxBracket == -1)
            {
                tax = 0;
            }
            else {
                tax = (annualIncome - minIncomeArray[taxBracket]) * taxRateArray[taxBracket] + basePayableAmountArray[taxBracket];
            }
            return tax;
        }

        private static void PrintResult(int annualIncome, double payableTaxAmount) {
            Console.WriteLine("Annual Income is {0:c} , Payable tax amount is ${1:#,##0.00}", annualIncome, payableTaxAmount);
        }
    }
}