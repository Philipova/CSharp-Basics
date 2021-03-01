using System;

namespace _04._Train_The_Trainers
{
    class Program
    {
        static void Main(string[] args)
        {
            // read jury count
            int juryCount = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            double marksSum = 0;
            int presentationCount = 0;
            // while ! Finish -> read presentation name
            while (input != "Finish")
            {
                presentationCount++; 
                double markSum = 0;
                
                for (int i = 1; i <= juryCount; i++)
                {
                    double mark = double.Parse(Console.ReadLine());
                    markSum += mark;
                }
                double avgMark = markSum / juryCount;
                marksSum += avgMark;
                Console.WriteLine($"{input} - {avgMark:F2}.");
                input = Console.ReadLine();
            }
            // for 1 to jurycount
            // read mark
            // calculate avg mark from presentation
            // print avg mark
            // print total result
            double finalMark = marksSum / presentationCount;
            Console.WriteLine($"Student's final assessment is {finalMark:F2}.");
        }
    }
}
