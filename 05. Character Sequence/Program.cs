﻿using System;

namespace _05._Character_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                char letter = input[1];
            }
              for (int i = 0; i < input.Length; i++)
            {
                char letter = input[i];
                Console.WriteLine(letter);
            }

        }
    }
}
