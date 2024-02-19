using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    class ConditionDemo
    {
        static void Main()
        {
            int X = 3, Y = 5, Z = 6, A = 1;
            if (X < Y)
                if (X < Z)
                    if (X < A)
                    {
                        X = 0;
                        Console.WriteLine(X);
                    }
                    else
                    {
                        X = 1;
                        Console.WriteLine(X);
                    }

        }
    }
}
