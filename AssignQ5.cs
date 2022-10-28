using System;
using System.Security.Cryptography.X509Certificates;

class AssignQ5
{
    static void Main()
    {
        double r, Area;
        const double PI = 3.14;
        Console.WriteLine("Program to calculate area and circumfrence of circle");
        Console.WriteLine("\nEnter the radius of circle");
        r = Convert.ToDouble(Console.ReadLine());
        Area = PI * r * r;
        Console.WriteLine("\nThe area of circle is {0}",Area);
        Console.WriteLine("\nThe circumference of a circle is {0}", 2 * PI * r);
        Console.ReadKey();

    }



}