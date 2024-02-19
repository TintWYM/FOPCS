using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    class Day2Quiz
    {
        static void Main()
        {
            Console.Write("Please enter length in cm:");
            double length = Convert.ToDouble(Console.ReadLine());
            double lengthInInch = length / 2.54;
            Console.WriteLine("{0:0.000}",lengthInInch);          
        }
    }
}
