using System;

namespace CharctersInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            char start = char.Parse(Console.ReadLine());
            char end = char.Parse(Console.ReadLine());

            PrintChars(start, end);
        }

        static void PrintChars(char first, char last)
        {
            int start = (int)first;
            int end = (int)last;

            if (start > end)
            {
                int t = start;
                start = end;
                end = t;
            }

            for (int i = start + 1; i < end; i++)
            {
                Console.Write($"{(char)(i)} ");
            }
        }
    }
}
