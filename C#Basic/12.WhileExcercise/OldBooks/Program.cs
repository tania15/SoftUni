using System;

namespace OldBooks
{
    class Program
    {
        static void Main(string[] args)
        {
            string favoriteBook = Console.ReadLine();
            string book = Console.ReadLine();
            int count = 0;

            while (book != "No more Books" && book != favoriteBook)
            {
                count++;
                book = Console.ReadLine();
            }

            if (book == "No More Books")
            {
                Console.WriteLine($"The book you search is not here! You checked {count} books.");
            }
            else
            {
                Console.WriteLine($"You checked {count} books and found it.");
            }
        }
    }
}
