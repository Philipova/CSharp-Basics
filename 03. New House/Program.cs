using System;

namespace _03._New_House
{
    class Program
    {
        static void Main(string[] args)
        {
            string flowers = Console.ReadLine();
            double numberFlowers = double.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());
            double price = 0;
            double result = 0;
            double totalResult = 0;


            if (flowers == "Roses" && numberFlowers <= 80)
            {
                price = 5;
            }
            else if (flowers == "Roses" && numberFlowers > 80)
            {
                price = 5 * 0.9;
            }

            if (flowers == "Dahlias" && numberFlowers <= 90)
            {
                price = 3.8;
            }
            else if (flowers == "Dahlias" && numberFlowers > 90)
            {
                price = 3.8 * 0.85;
            }

            if (flowers == "Tulips" && numberFlowers <= 80)
            {
                price = 2.8;
            }
            else if (flowers == "Tulips" && numberFlowers > 80)
            {
                price = 2.8 * 0.85;
            }

            if (flowers == "Narcissus" && numberFlowers < 120)
            {
                price = 3.0;
            }
            else if (flowers == "Narcissus" && numberFlowers < 120)
            {
                price = 3.0 * 0.85;
            }

            if (flowers == "Gladiolus" && numberFlowers < 80)
            {
                price = 2.50;
            }
            else if (flowers == "Gladiolus" && numberFlowers < 80)
            {
                price = 2.5 * 1.2;
            }

            result = budget-(numberFlowers * price);
            totalResult = Math.Abs((numberFlowers * price) - budget);
           
            if (budget >= (numberFlowers*price))
            {
                Console.WriteLine($"Hey, you have a great garden with {numberFlowers} {flowers} and {result:F2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {(totalResult-1):F2} leva more.");
            }
        }
    }
}
