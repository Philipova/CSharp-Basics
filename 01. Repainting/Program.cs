using System;

namespace _01._Repainting
{
    class Program
    {
        static void Main(string[] args)
        {
            double nylonQuantity = double.Parse(Console.ReadLine());
            double paintQuantity = double.Parse(Console.ReadLine());
            double thinnerQuantity = double.Parse(Console.ReadLine());
            double hours = double.Parse(Console.ReadLine());

            double nylonAdditionalSquareMeter = 2;
            double paintAdditionalSquareMeter = 1.10;
            double bagsPrice = 0.4;
            double nylonSquareMeter = 1.5;
            double paintLiter = 14.5;
            double thinnerLiter = 5.0;
            double totalMaterials = ((nylonQuantity + nylonAdditionalSquareMeter) * nylonSquareMeter 
                + (paintQuantity)* paintAdditionalSquareMeter * paintLiter 
                + thinnerLiter * thinnerQuantity 
                + bagsPrice);

            double priceLaber = totalMaterials * 0.3;

            double final = totalMaterials + priceLaber*hours;

            //double totalExpences = (nylonQuantity + nylonAdditionalSquareMeter) * nylonSquareMeter + (paintAdditionalSquareMeter + paintQuantity) * paintLiter + thinnerLiter * thinnerQuantity + bagsPrice + hours * pricePerHour;
            Console.WriteLine($"Total expenses: {final:F2} lv.");
        }
    }
}
