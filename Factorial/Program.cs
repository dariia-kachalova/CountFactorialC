using System;
using System.Collections.Generic;
using System.Linq;

namespace Program
{
    public static class Factorial
    {
        static void Main()
        {
            IEnumerable<int> ints = Enumerable.Range(1, 4);
            int factorial = ints.Aggregate((i, j) => i * j);

            Console.WriteLine(factorial);

        }
    }

}
