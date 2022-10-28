using System;

class AssignQ1
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the action to be performed");
        Console.WriteLine("Press 1 for Addition");
        Console.WriteLine("Press 2 for Subtraction");
        Console.WriteLine("Press 3 for Multiplication");
        Console.WriteLine("Press 4 for Division");
        int action = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter 1st input");
        int input1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter 2nd input");
        int input2 = Convert.ToInt32(Console.ReadLine());
        int result = 0;
        switch (action)
        {
            case 1:
                {
                    action = input1 + input2;
                    Console.WriteLine("Answer is");
                    Console.WriteLine(action);
                    break;
                }
            case 2:
                {
                    action = input1 - input2;
                    Console.WriteLine("Answer is");
                    Console.WriteLine(action);
                    break;
                }
            case 3:
                {
                    action = input1 * input2;
                    Console.WriteLine("Answer is");
                    Console.WriteLine(action);
                    break;
                }
            case 4:
                {
                    action = input1 / input2;
                    Console.WriteLine("Answer is");
                    Console.WriteLine(action);
                    break;
                }
            default:
                Console.WriteLine("Wrong action!! try again");
                break;
        }

    }
}
