using System;

namespace _01._Number_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int current = 1;
            bool isBigger = false;

            for (int rows = 1; rows <= n; rows++)
            {
                for (int cols = 0; cols <= rows; cols++)
                {
                    if (current > 1)
                    {
                        isBigger = true;
                        break;
                    }
                    Console.WriteLine(current + " ");
                    current++;
                }

            if (isBigger)
            {
            break;

            }
                Console.WriteLine();
            }
        }
    }
}
