using System;

namespace SumOfChars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                char c = char.Parse(Console.ReadLine());

                int code = (int)c;

                sum += code;
            }

            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
