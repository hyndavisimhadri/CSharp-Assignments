using System;
class AssignQ4
{
    static void Main(string[] args)
    {
        int num1, num2, temp;
        Console.WriteLine("Enter the first number");
        num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the Second number");
        num2 = int.Parse(Console.ReadLine());
        temp = num1;
        num1 = num2;
        num2 = temp;
        Console.WriteLine("After Swapping");
        Console.WriteLine("First number is: " + num1);
        Console.WriteLine("Second  number is: " + num2);
        Console.ReadLine();




    }
}

