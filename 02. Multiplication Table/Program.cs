﻿using System;

namespace _02._Multiplication_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int num1 = 0; num1 <= 10; num1++)
            {
                for (int num2 = 0; num2 <= 10; num2++)
                {
                    Console.WriteLine($"{num1}*{num2}={num1 * num2}");
                }
            }
           
        }
    }
}
