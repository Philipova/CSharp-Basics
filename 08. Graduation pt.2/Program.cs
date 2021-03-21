using System;

namespace _08._Graduation_pt._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double score = double.Parse(Console.ReadLine());
            double sum = 0;
            double count = 1;
            //double result = 0;

            //for (int i = 1; i <= 12; i++)
            //{
            //    int score = int.Parse(Console.ReadLine());
            //}

            ;
            while (count <= 12)
            {

                sum += score;
                if (score < 4)

                {
                    break;
                }

                if (count == 12)


                {
                    double result = sum / count;
                    Console.WriteLine($"{name} graduated. Average grade: {result:F2}");

                    break;

                }


                count += 1;
                score = double.Parse(Console.ReadLine());

            }
            while (count < 12)
            {


                score = double.Parse(Console.ReadLine());


                if (score < 4)

                {
                    Console.WriteLine($"{name} has been excluded at {count} grade");
                    break;

                }

                sum += score;
                count += 1;

                if (count == 12)

                {
                    double result2 = sum / count;
                    Console.WriteLine($"{name} graduated. Average grade: {result2:F2}");
                    break;

                }

            }

        }
    }
}
