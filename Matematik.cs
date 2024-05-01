using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MitBibliotek
{
    internal class Matematik
    {
        public static void LogiskOperator()
        {
            int a = 13;
            int b = 5;
            int orOperator = a | b;
            Console.WriteLine($"{a} | {b} = " + orOperator);
            int andOperator = a & b;
            Console.WriteLine($"{a} & {b} = " + andOperator);
            int xorOperator = a ^ b;
            Console.WriteLine($"{a} ^ {b} = " + xorOperator);
        }
    }
}
