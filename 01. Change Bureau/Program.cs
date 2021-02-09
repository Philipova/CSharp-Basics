using System;

namespace _01._Change_Bureau
{
    class Program
    {
        static void Main(string[] args)
        {
            double bitcoin = double.Parse(Console.ReadLine());
            decimal cny = decimal.Parse(Console.ReadLine());
            decimal commissionPercent = decimal.Parse(Console.ReadLine());
            decimal bgn1 = 0;
            decimal bgn2 = 0;

            decimal dollar = 0;
            decimal euro1 = 0;
            double euro2 = 0;

            decimal totalSum = 0;

            bgn1 = 1168 * bitcoin;
            euro1 = bgn1 / 1.95;
            dollar = 1.65 * cny;
            bgn2 = 1.76 * dollar;
            euro2 = bgn2 / 1.95;
            decimal totalEuro = euro1 + euro2;


            //result = (bitcoin + dollar)/ bgn;
            commission = commissionPercent * totalEuro;
            totalSum = totalEuro - commission;

            Console.WriteLine($"{totalSum}:F2");
        }
    }
}
