using System;

namespace _09._Left_and_Right_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int leftSum = 0;
            int rightSum = 0;
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                sum = int.Parse(Console.ReadLine());
                leftSum += sum;
            }
            for (int i = 0; i < n; i++)
            {
                sum = int.Parse(Console.ReadLine());
                rightSum += sum;
            }

            if (leftSum == rightSum)
            {
                Console.WriteLine("Yes, sum = " + leftSum);
            }
            else
            {
                //int diff = Math.Abs(rightSum - leftSum);
                //Console.WriteLine("No, diff = " + diff);
                Console.WriteLine("No, diff = {0}", Math.Abs(leftSum - rightSum));
            }
        }
    }
}
