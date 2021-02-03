using System;

namespace _01._Old_Books
{
    class Program
    {
        static void Main(string[] args)
        {
            string favouriteBook = Console.ReadLine();
            bool isFound = false;
            int countOfBooks = 0;

            while (true)
            {
                string currentBook = Console.ReadLine();

                if (currentBook == favouriteBook)
                {
                    isFound = true;
                    break;
                }
                else if (currentBook == "No More Books")
                {
                    break;
                }

                countOfBooks++;
            }

            if (isFound == true)
            {
                Console.WriteLine($"You checked {countOfBooks} books and found it.");
            }
            else
            {
                Console.WriteLine($"The book you search is not here!");
                Console.WriteLine($"You checked {countOfBooks} books.");
            }

        }
    }
}
