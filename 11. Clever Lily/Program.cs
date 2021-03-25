using System;

namespace _11._Clever_Lily
{
    class Program
    {
        static void Main(string[] args)
        {
            var old = int.Parse(Console.ReadLine());
            var priceForPeralnq = double.Parse(Console.ReadLine());
            var priceForToy = double.Parse(Console.ReadLine());

            double toy = 0;
            double savedMoneyFromBirthDay = 0.0;

            double totalMoney;
            double secondMoney = 0;
            double counter = 0;
            double priceFromToy = 0;

            for (int i = 1; i <= old; i++)
            {
                if (i % 2 == 0)
                {
                    savedMoneyFromBirthDay = savedMoneyFromBirthDay + 10;
                    secondMoney = secondMoney + savedMoneyFromBirthDay;
                    counter++;
                }
                else
                {
                    toy++;
                }

            }
            priceFromToy = toy * priceForToy;

            totalMoney = secondMoney + priceFromToy - counter;

            if (totalMoney >= priceForPeralnq)
            {
                Console.WriteLine("Yes! {0:f2}", Math.Abs(totalMoney - priceForPeralnq));
            }
            else
            {
                Console.WriteLine("No! {0:F2}", Math.Abs(priceForPeralnq - totalMoney));
            }
        }
    }
}
