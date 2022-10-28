using System;

namespace Assignment1
{
    internal class PrimeNumber
    {
        public static void Main()
        {
            int n, i, m = 0, flag = 0;
            Console.WriteLine("Enter the Number");
            n = int.Parse(Console.ReadLine());
            m = n / 2;
            for(i = 2; i <= m; i++)
            {
                if(n%i ==0)
                {
                    Console.WriteLine("Number is not prime");
                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
            Console.WriteLine("Number is Prime");
            Console.ReadKey();
        }
    }
}
