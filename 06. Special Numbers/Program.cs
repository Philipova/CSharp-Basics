using System;

namespace _06._Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // read n
            int n = int.Parse(Console.ReadLine());
            // from 1111 to 9999
            // n % each digit == 0
            // write i
            for (int i = 1111; i <= 9999; i++)
            {
                bool isSpecial = true;

                for (int index = 0; index <= 3; index++)
                {
                    int digit = int.Parse(i.ToString()[index].ToString());
                    if (digit == 0)
                    {
                        isSpecial = false;
                        break;
                    }
                }
                if (isSpecial)
                {
                    Console.Write($"{i} ");
                }
            }
        }
    }
}
