using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    class Program3
    {
        static void Main()
        {
            int a = 1;

       

            Console.WriteLine(a++); // write a, then inc a

            a = 1;
            Console.WriteLine(++a); // inc a, then write a
            
            //round example
            double x = 3.5934723;
            Console.WriteLine(Math.Round(x, 2)); //3.59
            Console.WriteLine(Math.Round(x, 1)); //3.6
            Console.WriteLine(Math.Round(x, 0)); //4
            Console.WriteLine(Math.Round(x, 5)); //3.59347

            Console.WriteLine(Math.Floor(x));//3

            Console.WriteLine(Math.Max(1, 2)); //2
            double dx = -12.534565; 
            Console.WriteLine("Rounded value of " + dx +
                          " is " + Math.Round(dx));
        }
    }
}
