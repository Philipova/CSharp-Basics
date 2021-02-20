using System;

namespace _03._Odd_and_Even_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            double oddSum = 0;
            double oddMax = double.MinValue;
            double oddMin = double.MaxValue;

            double evenSum = 0;
            double evenMax = double.MinValue;
            double evenMin = double.MaxValue;

            for (int i = 1; i <= count; i++)
            {
                double num = double.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    evenSum += num;
                    if (evenMax < num)
                    {
                        evenMax = num;
                    }

                    if (evenMin > num)
                    {
                        evenMin = num;
                    }
                }

                else
                {
                    oddSum += num;
                    if (oddMax < num)
                    {
                        oddMax = num;
                    }
                    if (oddMin > num)
                    {
                        oddMin = num;
                    }
                }
            }
                Console.WriteLine($"OddSum={oddSum:F2},");
                if (oddSum == 0)
                {
                    Console.WriteLine($"OddMin=No,");
                    Console.WriteLine($"OddMax=No,");
                }
                else
                {
                    Console.WriteLine($"OddMin={oddMin:F2},");
                    Console.WriteLine($"OddMax={oddMax:F2},");
                }

                Console.WriteLine($"EvenSum={evenSum:F2},");
                if (evenSum == 0)
                {
                    Console.WriteLine($"EvenMin=No,");
                    Console.WriteLine($"EvenMax=No");
                }
                else
                {
                    Console.WriteLine($"EvenMin={evenMin:F2},");
                    Console.WriteLine($"EvenMax={evenMax:F2}");
                }
        }
    }
}
