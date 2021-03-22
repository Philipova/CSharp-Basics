using System;

namespace _08._On_Time_for_the_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. вход
            int hourExam = int.Parse(Console.ReadLine());
            int minutesExam = int.Parse(Console.ReadLine());
            int hourArrived = int.Parse(Console.ReadLine());
            int minutesArrived = int.Parse(Console.ReadLine());

            // 2. преобразуване в минути -> (часове * 60) + минути
            int examInMinutes = (hourExam * 60) + minutesExam; //час на изпита в минути
            int arriveInMinutes = (hourArrived * 60) + minutesArrived; //час за пристигане в минути

            //3. проверка дали сме Late, Ontime или Early
            //Late
            if (arriveInMinutes > examInMinutes)
            {
                Console.WriteLine("Late");
                int lateInMinutes = arriveInMinutes - examInMinutes;
                if (lateInMinutes < 60)
                {
                    Console.WriteLine($"{lateInMinutes} minutes after the start");
                }
                else
                {
                    // над 60 минути -> часове и минути
                    int lateHours = lateInMinutes / 60;
                    int lateMinutes = lateInMinutes % 60;
                    Console.WriteLine($"{lateHours}:{lateMinutes:D2} hours after the start");
                }
            }
            //On time
            else if (arriveInMinutes == examInMinutes || arriveInMinutes - examInMinutes < 30)
            {
                Console.WriteLine("On time");
                if (arriveInMinutes != examInMinutes)
                {
                    Console.WriteLine($"{examInMinutes - arriveInMinutes} minutes before the start");
                }

            }
            //Early
            else if (examInMinutes - arriveInMinutes > 30)
            {
                Console.WriteLine("Early");
                // ⦁“mm minutes before the start” за идване по-рано с по-малко от час.
                int earlyInMinutes = examInMinutes - arriveInMinutes; // с колко подраняваме
                if (earlyInMinutes < 60)
                {
                    Console.WriteLine($"{earlyInMinutes} minutes before the start");
                }
                //“hh: mm hours before the start” за подраняване с 1 час или повече.Минутите винаги печатайте с 2 цифри, например “1:05”.
                else
                {
                    // подраняване в минути -> да се преобразува в часове и минути
                    int earlyHour = earlyInMinutes / 60;
                    int earlyMinutes = earlyInMinutes % 60;

                    Console.WriteLine($"{earlyHour}: {earlyMinutes:D2} hours before the start)");
                }
            }
        }
    }
}
