using System;

namespace _01._Change_exam
{
    class Program
    {
        static void Main(string[] args)
        {
            double bitcoin = double.Parse(Console.ReadLine());
            double cny = double.Parse(Console.ReadLine());
            double commissionPercent = double.Parse(Console.ReadLine());

            double bgn1 = 0;
            double bgn2 = 0;

            double dollar = 0;
            double euro1 = 0;
            double euro2 = 0;

            bgn1 = 1168 * bitcoin; // v leva
            euro1 = bgn1 / 1.95; // v euro
            dollar = 0.15 * cny; // v $$
            bgn2 = 1.76 * dollar; // v LV
            euro2 = bgn2 / 1.95; // Euro
            double totalEuro = euro1 + euro2;

            double afterCommission = totalEuro - ((commissionPercent/100) * totalEuro);
           
            Console.WriteLine($"{afterCommission:F2}");
        }
    }
}
