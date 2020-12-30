using System;

namespace MiddleCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            PrintMiddleCharacters(str);
        }

        static void PrintMiddleCharacters(string str)
        {
            if (str.Length % 2 == 1)
            {
                Console.WriteLine(str[str.Length / 2]);
            }
            else
            {
                Console.WriteLine($"{str[str.Length / 2 - 1]}{str[str.Length / 2]}");
            }
        }
    }
}
