using System;

namespace _01._Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());
            double incomes = 0;

            if (type == "Premiere")
            {
                incomes = rows * columns * 12.00;
            }
            else if (type == "Normal")
            {
                incomes = rows * columns * 7.50;
            }
            else if (type == "Discount")
            {
                incomes = rows * columns * 5.00;
            }

            //Console.WriteLine("{ 0:f2} leva", incomes);
            Console.WriteLine($"{incomes:F2} leva");
        }
    }
}
