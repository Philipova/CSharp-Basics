using System;

namespace _01._Pool_ex_exam
{
    class Program
    {
        static void Main(string[] args)
        {
            double people = double.Parse(Console.ReadLine());
            double entranceTax = double.Parse(Console.ReadLine());
            double loungePrice = double.Parse(Console.ReadLine());
            double umbrellaPrice = double.Parse(Console.ReadLine());

            double totalEntrancePrice = people * entranceTax;
            double umbrella = Math.Ceiling(people / 2);
            double lounge = Math.Ceiling(people * 0.75);

            double totalPrice = totalEntrancePrice + lounge * loungePrice + umbrella * umbrellaPrice;

            Console.WriteLine($"{totalPrice:F2} lv.");
        }
    }
}
