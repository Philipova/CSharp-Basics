using System;

namespace _02._Family_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int nightCount = int.Parse(Console.ReadLine());
            double nightPrice = double.Parse(Console.ReadLine());
            int percent = int.Parse(Console.ReadLine());

            if (nightCount > 7)
            {
                nightPrice = nightPrice * 0.95;
            }

            double totalNightPrice = nightCount * nightPrice;
            double additionalCosts = budget * (percent / 100.0);

            double totalPrice = totalNightPrice + additionalCosts;
            if (totalPrice > budget)
            {
                double moneyNeed = totalPrice - budget;
                Console.WriteLine($"{moneyNeed:F2} leva needed.");
            }
            else
            {
                double moneyLeft = budget - totalPrice;
                Console.WriteLine($"Ivanovi will be left with {moneyLeft:F2} leva after vacation.");
            }
        }
    }
}
