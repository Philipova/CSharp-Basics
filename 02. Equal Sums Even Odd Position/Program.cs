using System;

namespace _02._Equal_Sums_Even_Odd_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            // for from start to end
            // generate number (start+1)
            // toString ()
            // for 0 to len
            // sum odd and even digits
            //
            // if equal prints
            //
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());

            for (int i = number1; i <= number2; i++)
            {
                string num = i.ToString();

                int evenSum = 0;
                int oddSum = 0;

                for (int j = 0; j < num.Length; j++)
                {
                    char magic = num[j];
                    int digit = int.Parse(magic.ToString());

                    if (j % 2 == 0)
                    {
                        evenSum += digit;
                    }
                    else
                    {
                        oddSum += digit;
                    }
                }
                if (evenSum == oddSum)
                {
                    Console.Write($"{i} ");
                }
            }
        }
    }
}
