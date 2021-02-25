using System;

namespace _04._Fishing_Boat
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string sezon = Console.ReadLine();
            int fishers = int.Parse(Console.ReadLine());
            double boatPrice = 0;
                
                //double.Parse(Console.ReadLine());

            //double totalPrice = 0;

            switch (sezon)
            {
                case "Spring":
                    boatPrice = 3000;
                    break;
                case "Summer":
                case "Autumn":
                    boatPrice = 4200;
                    break;
                case "Winter":
                    boatPrice = 2600;
                    break;
            }

            if (fishers <= 6)
            {
                boatPrice = boatPrice - (boatPrice * 0.10);
            }

            if (fishers >= 7 && fishers <= 11)
            {
                boatPrice = boatPrice - (boatPrice * 0.15);
            }

            if (fishers > 12)
            {
                boatPrice = boatPrice - (boatPrice * 0.25);
            }


            if (fishers % 2 == 0 && sezon != "Autumn")
            {
                boatPrice = boatPrice - (boatPrice * 0.05);
            }


            if (budget >= boatPrice)
            {

                double a = (budget - boatPrice);
                Console.WriteLine($"Yes! You have {a:F2} leva left.");

            }
            else
            {
                double needMoney = boatPrice - budget;
                Console.WriteLine($"Not enough money! You need {needMoney:F2} leva.");
            }
        }
    }
}

            