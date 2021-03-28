using System;

namespace DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());
            double commission = 0;
            bool isCityAndSales = false;

            switch (city)
            {
                case "Sofia":
                    if (0 <= sales && sales <= 500)
                    {
                        commission = 0.05;
                        isCityAndSales = true;
                    }
                    else if (500 < sales && sales <= 1000)
                    {
                        commission = 0.07;
                        isCityAndSales = true;
                    }
                    else if (1000 < sales && sales <= 10000)
                    {
                        commission = 0.08;
                        isCityAndSales = true;
                    }
                    else if (sales < 10000)
                    {
                        commission = 0.12;
                        isCityAndSales = true;
                    }
                    break;

                case "Varna":
                    if (0 <= sales && sales <= 500)
                    {
                        commission = 0.045;
                        isCityAndSales = true;
                    }
                    else if (500 < sales && sales <= 1000)
                    {
                        commission = 0.075;
                        isCityAndSales = true;
                    }
                    else if (1000 < sales && sales <= 10000)
                    {
                        commission = 0.1;
                        isCityAndSales = true;
                    }
                    else if (sales < 10000)
                    {
                        commission = 0.13;
                        isCityAndSales = true;
                    }
                    break;

                case "Plovdiv":
                    if (0 <= sales && sales <= 500)
                    {
                        commission = 0.055;
                        isCityAndSales = true;
                    }
                    else if (500 < sales && sales <= 1000)
                    {
                        commission = 0.08;
                        isCityAndSales = true;
                    }
                    else if (1000 < sales && sales <= 10000)
                    {
                        commission = 0.12;
                        isCityAndSales = true;
                    }
                    else if (sales < 10000)
                    {
                        commission = 0.145;
                        isCityAndSales = true;
                    }
                    break;
            }
            if (isCityAndSales == true)
            {
                double result = sales * commission;
                Console.WriteLine($"{result:F2}");
            }
            else if (isCityAndSales == false)
            {
                Console.WriteLine("error");
            }
        }
    }
}
