using System;

namespace _03._Sum_Prime_Non_Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            // n > 1
            // n == 2 -> true
            // n % 2 == 0 -> false
            // for i = 3 to n/2
            // if n % i = 0 -> false

            int primeSum = 0;
            int nonPrimeSum = 0;
            string input = Console.ReadLine();
            while (input != "stop")
            {
                int num = int.Parse(input);
                if (num < 0)
                {
                    Console.WriteLine("Number is negative.");
                }
                else if (num <= 1)
                {
                    nonPrimeSum += num;
                }
                else if (num == 2)
                {
                    primeSum += num;
                }
                else if (num % 2 == 0)
                {
                    nonPrimeSum += num;
                }
                else
                {
                    int bound = (int)Math.Floor(Math.Sqrt(num));
                    bool isPrime = true;
                    for (int i = 3; i <= bound; i++)
                    {
                        if (num % i == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                    if (isPrime)
                    {
                        primeSum += num;
                    }
                    else
                    {
                        nonPrimeSum += num;
                    }
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Sum of all prime numbers is: {primeSum}");
            Console.WriteLine($"Sum of all non prime numbers is: {nonPrimeSum}");

        }
    }
}
