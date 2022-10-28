using System;
using System.Security.Cryptography.X509Certificates;

namespace Assignment1
{
    internal class Large
    {
        public static void Main()
        {
            int num1, num2, MaxNum;
            Console.WriteLine("Enter the First number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Second  number: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            if (num1 > num2)
            {
                MaxNum = num1;
            }
            else 
            {
                MaxNum = num2;
            }
            Console.Write("Maximum number is: " + MaxNum);
            Console.ReadKey();
        }
    }
}
