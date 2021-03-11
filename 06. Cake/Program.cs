using System;

namespace _06._Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());


            int totalCakeSlices = width * height;
            int finalCakeSlices = width * height;
            int totalTakenSlices = 0;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "STOP")
                {
                    break;
                }

                int takenSlices = int.Parse(input);

                totalCakeSlices -= takenSlices;
                totalTakenSlices += takenSlices;

                if (totalCakeSlices <= 0)
                {
                    //int finalCakeSlices = width * height;
                    Console.WriteLine($"No more cake left! You need {totalTakenSlices - finalCakeSlices} pieces more.");
                    break;
                }
            }

            if (totalCakeSlices > 0)
            {
                Console.WriteLine($"{totalTakenSlices - totalTakenSlices} pieces are left.");
            }
        }
    }
}
