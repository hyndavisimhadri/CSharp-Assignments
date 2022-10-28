using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Class3
    {
        public static void Main()
        {
            int a = 0, b = 1, c, i, num;
            num = 10;
            Console.WriteLine("Fibonacci series: ");
            Console.WriteLine(a + " " + b + " ");
            for(i = 2; i < num; ++i)
            {
                c = a + b;
                Console.WriteLine(c + " ");
                a = b;
                b = c;
            }
        }
    }
}
