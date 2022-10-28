using System;

namespace Assignment1
{
    internal class Arraydemo
    {
        public static void Main()
        {
            int[] n = new int[10];
            int i, j;
            for (i = 0; i < 10; i++)
            {
                n[i] = i + 10;
            }
            for (j = 0; j < 10; j++)
            {
              Console.WriteLine("Element[{0}] = {1}", j, n[j]);
            }
            Console.ReadKey();

        }
    }
}
